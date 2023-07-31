using System.IO.Compression;
using System.Text;
using System.Text.Json.Serialization;
using BlogLast;
using BlogLast.Data;
using BlogLast.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);
ConfigureMvc(builder);
ConfigureServices(builder);
var app = builder.Build();
LoadConfiguration(app);
LoadAuthenticators(app);

app.MapControllers();

if (app.Environment.IsProduction())
    Console.WriteLine("Production")

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsStagging())
    Console.WriteLine("Stagging")

app.UseHttpsRedirection();

app.Run();

void LoadConfiguration(WebApplication app)
{
    Configuration.JwtKey = app.Configuration.GetValue<string>("JwtKey");
    Configuration.ApiKeyName = app.Configuration.GetValue<string>("ApiKeyName");
    Configuration.ApiKey = app.Configuration.GetValue<string>("ApiKey");

    var smtp = new Configuration.SmtpConfiguration();
    app.Configuration.GetSection("Smtp").Bind(smtp);
    Configuration.Smtp = smtp;
}

void ConfigureAuthentication(WebApplicationBuilder builder)
{

    var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
    builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(x =>
    {
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false,
        };
    });
}

void ConfigureMvc(WebApplicationBuilder builder)
{
    builder.Services.AddMemoryCache();
    builder.Services.AddResponseCompression(options =>
    {
        options.Providers.Add<GzipCompressionProvider>();
    });
    builder.Services.Configure<GzipCompressionProviderOptions>(options =>
    {
        options.Level = CompressionLevel.Optimal;
    });

    builder
        .Services
        .AddControllers()
        .ConfigureApiBehaviorOptions(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        })
        .AddJsonOptions(x =>
        {
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; // Ignore infinite loop
            x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
        });
}

void ConfigureServices(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString(options => {
        options.UseSqlServer(connectionString);
    });
    builder.Services.AddEndPointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddDbContext<BlogDataContext>();
    builder.Services.AddTransient<EmailService>();
    builder.Services.AddTransient<TokenService>(); // Sempre cria uma nova instancia.
    //builder.Services.AddSingleton(); // Cria uma nova instancia por transacao, enquanto a transacao durar ela existe.
    //builder.Services.AddScoped(); // 1 por aplicativo.
}

void LoadAuthenticators(WebApplication app)
{
    app.UseAuthentication(); // Enable login
    app.UseAuthorization(); // Enable ask account
    app.UseStaticFiles(); // Enable sending files
    app.UseResponseCompression(); // Enable compression
}