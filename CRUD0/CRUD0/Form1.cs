using System.Data;
using System.Data.SqlClient;

namespace CRUD0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetBaseValues();
            outputLabel.Text = $"{DateTime.Now.ToString("dd/MM/yyy -- hh:mm:ss")}";
            outputLabel.ForeColor = Color.GreenYellow;
        }

        private void SetBaseValues()
        {
            genderBox.SelectedIndex = 0;
            cityBox.SelectedIndex = 0;
            tableBox.SelectedIndex = 0;
        }
        SqlConnection connection = new SqlConnection("Data Source=PEDRO\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private bool CheckIfAllFilled()
        {
            outputLabel.ForeColor = Color.DarkRed;
            if (nameBox.Text.Equals(""))
            {
                outputLabel.Text = "You need to insert the name";
                return false;
            }
            if (cityBox.Text.Equals(""))
            {
                outputLabel.Text = "You need to select the city";
                return false;
            }
            if (genderBox.Text.Equals(""))
            {
                outputLabel.Text = "You need to select the gender";
                return false;
            }
            return true;
        }
        #region insertValue
        private void InsertValue()
        {
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_InsertUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@City", cityBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", genderBox.Text);
                    cmd.Parameters.AddWithValue("@Create_Date", DateTime.Now);
                    int rowsChanged = cmd.ExecuteNonQuery();
                    if (rowsChanged <= 0)
                    {
                        outputLabel.Text = "No changes happened.";
                        outputLabel.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        outputLabel.Text = $"{rowsChanged} columns were changed.";
                        outputLabel.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We couldnt execute the command " + ex.Message, "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            finally { connection.Close(); }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (CheckIfAllFilled())
            {
                InsertValue();
                LoadRecords();
            }
        }
        #endregion
        #region UpdateTable
        private void LoadRecords()
        {
            try
            {
                connection.Open();
                using (SqlDataAdapter adapter = new("SP_UsersTable", connection))
                {
                    DataTable dataTable = new();
                    adapter.Fill(dataTable);

                    sqlView.DataSource = dataTable;
                    outputLabel.Text = "Parsed succesfully";
                    outputLabel.ForeColor = Color.GreenYellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We couldnt load the table " + " error: " + ex.Message + "\nDEBUG: " + ex, "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            finally { connection.Close(); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }
        #endregion
        #region UpdateTable
        private int UpdateValue()
        {
            connection.Open();
            try
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateTable", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Identifier", int.Parse(idBox.Text));
                    command.Parameters.AddWithValue("@Name", nameBox.Text);
                    command.Parameters.AddWithValue("@City", cityBox.Text);
                    command.Parameters.AddWithValue("@Gender", genderBox.Text);
                    int rows = command.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        outputLabel.Text = "No changes happened.";
                        outputLabel.ForeColor = Color.GreenYellow;
                    }
                    return rows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We couldnt update the table " + " error: " + ex.Message, "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return 0;
            }
            finally { connection.Close(); }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (CheckIfAllFilled() && !idBox.Text.Equals(""))
            {
                int amount = UpdateValue();
                LoadRecords();
                outputLabel.Text = $"Successfully changed {amount} rows.";
                outputLabel.ForeColor = Color.AliceBlue;
            }
        }
        #endregion

        #region delete
        private void DeleteRow(int id)
        {
            connection.Open();
            try
            {
                using (SqlCommand cmd = new("SP_DeleteRow"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        outputLabel.Text = "Didnt affected any rows.";
                        outputLabel.ForeColor = Color.DarkRed;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We couldnt delete the row " + " error: " + ex.Message, "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            finally { connection.Close(); } 
        }
        #endregion

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inputId = idBox.Text;
                int outputId;
                if (int.TryParse(inputId, out outputId))
                {
                    DeleteRow(outputId);
                }
                else
                {
                    outputLabel.Text = "Couldnt transform the ID into a number.";
                    outputLabel.ForeColor = Color.DarkRed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong when parsing the user ID " + " error: " + ex.Message, "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }
    }
}