using System.Data;
using System.Data.SqlClient;

namespace LastTest
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLConsole;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            var connect = new SqlConnection(connectionString);
            connection = connect;
            connect.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
            connection.Dispose();
            MessageBox.Show("Your connection has been closed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new SqlCommand(commandBox.Text, connection);
                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    MessageBox.Show("Nothing happened while executing your command.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail while trying to execute your command." + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string updateTable = "select * from dbo.Person";
                var adapter = new SqlDataAdapter(updateTable, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                sqlView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail while trying to load your table." + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}