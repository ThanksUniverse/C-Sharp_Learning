using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAdvanced
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=PEDRO\\SQLEXPRESS;Initial Catalog=Taissa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            Initializer();
        }

        private void PromptMessage(string message, Color color)
        {
            promptBox.Text = message;
            promptBox.ForeColor = color;
        }

        private void ConnectToDatabase()
        {
            try
            {
                var con = new SqlConnection(connectionString);
                connection = con;
                con.Open();
                PromptMessage($"Welcome its {DateTime.Now:D}", Color.CadetBlue);
            }
            catch
            {
                PromptMessage("We couldnt connect you to the database, try again later.", Color.DarkRed);
            }

        }

        private void Initializer()
        {
            tableBox.SelectedIndex = 0;
            ConnectToDatabase();
            UpdateTable();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("spSearchLike", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                int id;
                if (int.TryParse(searchBox.Text, out id))
                    cmd.Parameters.AddWithValue("@Id", id);
                else
                    cmd.Parameters.AddWithValue("@Name", searchBox.Text);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        adapter.Fill(dataTable);
                        sqlView.DataSource = dataTable;
                    }
                }
            }
        }

        private void UpdateTable()
        {
            try
            {
                string searchText = "";
                if (tableBox.SelectedIndex == 0)
                    searchText = "spSearchProduct";
                else
                    searchText = "spSearchSectors";
                using (SqlCommand cmd = new SqlCommand($"{searchText}", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            sqlView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch
            {
                PromptMessage("We couldnt load your table for some reason 🥲", Color.DarkBlue);
                return;
            }
        }

        private void tableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inserText = "";
                if (tableBox.SelectedIndex == 0)
                    inserText = "spInsertProduct";
                else
                    inserText = "spInsertSector";
                using (SqlCommand cmd = new SqlCommand($"{inserText}", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                    if (tableBox.SelectedIndex == 0)
                    {
                        decimal price;
                        if (decimal.TryParse(priceBox.Text, out price))
                            cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Description", descriptionBox.Text);
                        int sector;
                        if (int.TryParse(sectorName.SelectedIndex.ToString(), out sector))
                            cmd.Parameters.AddWithValue("@SectorId", sector + 1);
                    }

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        PromptMessage($"We succesfully added your value", Color.LightGreen);
                    }

                    UpdateTable();
                }
            }
            catch
            {
                PromptMessage("We couldnt insert your value in the table for some reason 😭", Color.Crimson);
                return;
            }

        }

        private void ClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = sqlView.Rows[e.RowIndex];

            idBox.Text = row.Cells["Id"].Value.ToString();
            nameBox.Text = row.Cells["Name"].Value.ToString();
            priceBox.Text = row.Cells["Price"].Value.ToString();
            registerDate.Text = row.Cells["CreateDate"].Value.ToString();
            descriptionBox.Text = row.Cells["Description"].Value.ToString();
            sectorName.SelectedIndex = int.Parse(row.Cells["SectorId"].Value.ToString()) - 1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteProduct", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    int id;
                    if (!int.TryParse(idBox.Text, out id))
                    {
                        PromptMessage("Please insert a valid ID", Color.CadetBlue);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@Id", id);

                    DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to delete the product id {id}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int row = cmd.ExecuteNonQuery();
                        if (row <= 0)
                        {
                            PromptMessage("We executed the command but didnt deleted anything.", Color.CadetBlue);
                        }
                        else
                        {
                            PromptMessage("You sucessfully deleted one row.", Color.CadetBlue);
                        }
                        UpdateTable();
                    }
                }
            }
            catch
            {
                PromptMessage("We couldnt delete your value.", Color.Indigo);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
