using System.Data;
using System.Data.SqlClient;

namespace LastTestWork
{
    public partial class Form1 : Form
    {
        const string ConnectionString = "Server=localhost,1433;Database=crud;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true;";
        public SqlConnection Connection { get; set; }
        public Form1()
        {
            InitializeComponent();
            Startup();
        }

        private void PromptMessage(string message, Color color)
        {
            promptMessages.Text = message;
            promptMessages.ForeColor = color;
        }

        private void Startup()
        {
            SqlConnection sqlConnection = new(ConnectionString);
            sqlConnection.Open();
            Connection = sqlConnection;
            PromptMessage($"Welcome its {DateTime.Now:D}", Color.Chartreuse);
            tableBox.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableBox.SelectedIndex == (int)Table.Person)
                {
                    using var sqlCommand = new SqlCommand("spSearchPerson", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    if (searchBox.Text.Length > 0)
                    {
                        if (int.TryParse(searchBox.Text, out var id))
                        {
                            sqlCommand.Parameters.AddWithValue("@Id", id);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Name", searchBox.Text);
                        }
                    }
                    using var adapter = new SqlDataAdapter(sqlCommand);
                    using var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    sqlView.DataSource = dataTable;
                }
                else
                {
                    using var sqlCommand = new SqlCommand("spSearchProduct", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    if (searchBox.Text.Length > 0)
                    {
                        if (int.TryParse(searchBox.Text, out var id))
                        {
                            sqlCommand.Parameters.AddWithValue("@Id", id);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Name", searchBox.Text);
                        }
                    }
                    using var adapter = new SqlDataAdapter(sqlCommand);
                    using var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    sqlView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                PromptMessage($"Someone went wrong while updating the table {tableBox.SelectedText}", Color.DarkRed);
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBoxes(int index)
        {
            if (index == (int)Table.Person)
            {
                using var sqlCommand = new SqlCommand("spSearchAllPerson", Connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                using var adapter = new SqlDataAdapter(sqlCommand);
                using var dataTable = new DataTable();
                adapter.Fill(dataTable);
                sqlView.DataSource = dataTable;
            }
            else
            {
                using var sqlCommand = new SqlCommand("spSearchAllProducts", Connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                using var adapter = new SqlDataAdapter(sqlCommand);
                using var dataTable = new DataTable();
                adapter.Fill(dataTable);
                sqlView.DataSource = dataTable;
            }
        }

        private void TablesBoxUpdate(object sender, EventArgs e)
        {
            try
            {
                if (tableBox.SelectedIndex == (int)Table.Person)
                {
                    UpdateBoxes(1);
                }
                else
                {
                    UpdateBoxes(0);
                }
            }
            catch (Exception ex)
            {
                PromptMessage($"Someone went wrong while updating the table {tableBox.SelectedText}", Color.DarkRed);
                MessageBox.Show(ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableBox.SelectedIndex == (int)Table.Person)
                {
                    using var sqlCommand = new SqlCommand("spInsertPerson", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Name", nameBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Age", priceBox.Text);
                    int rows = sqlCommand.ExecuteNonQuery();
                    PromptMessage($"{rows} lines changed.", Color.Bisque);
                    if (rows >= 1)
                        UpdateBoxes(1);
                }
                else
                {
                    using var sqlCommand = new SqlCommand("spInsertProduct", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Name", nameBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Price", priceBox.Text);
                    sqlCommand.Parameters.AddWithValue("@UpdateDate", DateTime.Now);
                    int rows = sqlCommand.ExecuteNonQuery();
                    PromptMessage($"{rows} lines changed.", Color.Bisque);
                    if (rows >= 1)
                        UpdateBoxes(0);
                }
            }
            catch (Exception ex)
            {
                PromptMessage($"Someone went wrong while updating the table {tableBox.SelectedText}", Color.DarkRed);
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableBox.SelectedIndex == (int)Table.Person)
                {
                    using var sqlCommand = new SqlCommand("spAlterPerson", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", idBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Name", nameBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Age", priceBox.Text);
                    int rows = sqlCommand.ExecuteNonQuery();
                    PromptMessage($"{rows} lines changed.", Color.Bisque);
                    if (rows >= 1)
                        UpdateBoxes(1);
                }
                else
                {
                    using var sqlCommand = new SqlCommand("spAlterProduct", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", idBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Name", nameBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Price", priceBox.Text);
                    sqlCommand.Parameters.AddWithValue("@UpdateDate", DateTime.Now);
                    int rows = sqlCommand.ExecuteNonQuery();
                    PromptMessage($"{rows} lines changed.", Color.Bisque);
                    if (rows >= 1)
                        UpdateBoxes(0);
                }
            }
            catch (Exception ex)
            {
                PromptMessage($"Someone went wrong while updating the table {tableBox.SelectedText}", Color.DarkRed);
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableBox.SelectedIndex == (int)Table.Person)
                {
                    using var sqlCommand = new SqlCommand("spDeletePerson", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", idBox.Text);
                    int rows = sqlCommand.ExecuteNonQuery();
                    PromptMessage($"{rows} lines changed.", Color.Bisque);
                    if (rows >= 1)
                        UpdateBoxes(1);
                }
                else
                {
                    using var sqlCommand = new SqlCommand("spDeleteProduct", Connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", idBox.Text);
                    int rows = sqlCommand.ExecuteNonQuery();
                    PromptMessage($"{rows} lines changed.", Color.Bisque);
                    if (rows >= 1)
                        UpdateBoxes(0);
                }
            }
            catch (Exception ex)
            {
                PromptMessage($"Someone went wrong while updating the table {tableBox.SelectedText}", Color.DarkRed);
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateOnClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = sqlView.Rows[e.RowIndex];

                idBox.Text = row.Cells["Id"].Value.ToString();
                nameBox.Text = row.Cells["Name"].Value.ToString();
                priceBox.Text = row.Cells["Price"].Value.ToString();
                registerDate.Text = row.Cells["RegisterDate"].Value.ToString();
                updateDate.Text = row.Cells["UpdateDate"].Value.ToString();
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime RegisterDate { get; set; }
    }

    public enum Table
    {
        Product = 0,
        Person = 1
    }
}