using Dapper;
using DependencyStore.Models;
using Microsoft.Data.SqlClient;

namespace DependencyStore.Repositories.Contracts;

public class PromoCodeRepository : IPromoCodeRepository
{
    private readonly SqlConnection _connection;

    public PromoCodeRepository(SqlConnection connection)
        => _connection = connection;   
    public async Task<PromoCode?> GetPromoCodeAsync(string promoCode)
    {
        const string query = "SELECT * FROM PROMO_CODES WHERE CODE=@code";
        return await _connection.QueryFirstOrDefaultAsync<PromoCode>(query, new { code = promoCode });
    }
}