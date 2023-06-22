using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SQLAdminPanel
{
    public partial class LoginScreen : Form
    {
        public string ConnectionString { get; set; }
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void PromptMessage(string message, Color color)
        {
            consolePrompt.Text = message;
            consolePrompt.ForeColor = color;
        }


        private void LoginButton(object sender, EventArgs e)
        {
            string userName = userBox.Text;
            string passWord = passBox.Text;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=databaseExport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (con.State != ConnectionState.Open)
                {
                    PromptMessage("Couldnt connect to the Database", Color.Red);
                    return;
                }
                PromptMessage("Logged in.", Color.Green);
                SQLScreen it = new SQLScreen(con);
                it.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                PromptMessage($"Error connecting to the database: {ex.Message}", Color.Red);
                return;
            }
        }
    }
}
