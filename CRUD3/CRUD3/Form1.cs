using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace CRUD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartForm();
        }

        private readonly string connectionString = "Data Source=PEDRO\\SQLEXPRESS;Initial Catalog=Crud3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection? con;

        private void StartForm()
        {
            cityBox.SelectedIndex = 0;
            genderBox.SelectedIndex = 0;
            connectToDatabase();
        }

        private void MessagePrompt(string message, Color color)
        {
            promptBox.Text = message;
            promptBox.ForeColor = color;
        }

        private void connectToDatabase()
        {
            try
            {
                SqlConnection connection = new(connectionString);
                connection.Open();
                con = connection;
                MessagePrompt($"You have been sucessfully connected {DateTime.Now:d}", Color.DarkBlue);
            }
            catch (Exception)
            {
                MessagePrompt($"We couldnt connect you to the database {DateTime.Now:d}", Color.DarkRed);
            }
        }

        private void searchEmployee()
        {
            try
            {
                using (SqlCommand cmd = new("spSearchEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    int id = 0;
                    if (int.TryParse(searchBox.Text, out id))
                        cmd.Parameters.AddWithValue("@Id", searchBox.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@Name", searchBox.Text);
                    }

                    using (SqlDataAdapter adapter = new(cmd))
                    {
                        using (DataTable dataTable = new())
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count <= 0)
                            {
                                MessagePrompt("We didnt found anything;", Color.DarkBlue);
                                sqlView.DataSource = null;
                            }
                            sqlView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while parsing your command" + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckBoxes()
        {
            if (nameBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Name box.", Color.DarkBlue);
                return false;
            }
            if (cityBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the City box.", Color.DarkBlue);
                return false;
            }
            if (genderBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Gender box.", Color.DarkBlue);
                return false;
            }
            if (phoneBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Phone box.", Color.DarkBlue);
                return false;
            }
            if (emailBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Email box.", Color.DarkBlue);
                return false;
            }
            if (departmentBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Department box.", Color.DarkBlue);
                return false;
            }
            return true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Search box.", Color.DarkBlue);
                return;
            }
            searchEmployee();
        }

        private void LoadTable()
        {
            using (SqlDataAdapter adapter = new("spLoadEmployees", con))
            {
                using (DataTable dataTable = new())
                {
                    adapter.Fill(dataTable);
                    sqlView.DataSource = dataTable;
                }
            }
        }

        private void deleteEmployee()
        {
            try
            {
                using (SqlCommand cmd = new("spDeleteEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    int id = 0;
                    if (int.TryParse(idBox.Text, out id))
                        cmd.Parameters.AddWithValue("@Id", idBox.Text);
                    else
                    {
                        MessagePrompt("We couldnt use your Id.", Color.DarkRed);
                        return;
                    }

                    int result = 0;
                    DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to delete the employee id {id}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        result = cmd.ExecuteNonQuery();
                        LoadTable();
                    }

                    MessagePrompt($"{result} changed rows.", Color.DarkGreen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while parsing your command " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Id box.", Color.DarkBlue);
                return;
            }

            deleteEmployee();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTable();
            MessagePrompt("We refreshed the table.", Color.DarkBlue);
        }

        private void InsertEmployee()
        {
            try
            {
                using (SqlCommand cmd = new("spInsertEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", genderBox.Text);
                    cmd.Parameters.AddWithValue("@City", cityBox.Text);
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentBox.SelectedIndex + 1);

                    int result = cmd.ExecuteNonQuery();
                    MessagePrompt($"inserted {result} rows.", Color.DarkGreen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while parsing your command" + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (!CheckBoxes())
                return;

            InsertEmployee();
            LoadTable();
        }

        private void UpdateEmployee()
        {
            try
            {
                using (SqlCommand cmd = new("spUpdateEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    int id = 0;
                    if (int.TryParse(idBox.Text, out id))
                        cmd.Parameters.AddWithValue("@Id", idBox.Text);
                    else
                    {
                        MessagePrompt("We couldnt convert your Id to a number.", Color.DarkBlue);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", genderBox.Text);
                    cmd.Parameters.AddWithValue("@City", cityBox.Text);
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentBox.SelectedIndex + 1);

                    int result = cmd.ExecuteNonQuery();
                    MessagePrompt($"updated {result} rows.", Color.DarkGreen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while parsing your command" + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the Id box.", Color.DarkBlue);
                return;
            }
            if (!CheckBoxes())
                return;

            UpdateEmployee();
            LoadTable();
        }

        private void SelectCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = sqlView.Rows[e.RowIndex];
                string? id = row.Cells["Id"].Value.ToString();
                if (id == null || id == "") return;
                string? name = row.Cells["Name"].Value.ToString();
                string? email = row.Cells["Email"].Value.ToString();
                string? phone = row.Cells["Phone"].Value.ToString();
                string? gender = row.Cells["Gender"].Value.ToString();
                string? city = row.Cells["City"].Value.ToString();
                string? department = row.Cells["Department"].Value.ToString();

                idBox.Text = id;
                nameBox.Text = name;
                emailBox.Text = email;
                phoneBox.Text = phone;
                genderBox.Text = gender;
                cityBox.Text = city;
                departmentBox.Text = department;

                MessagePrompt("We inserted your values into the boxes.", Color.DarkGreen);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
            nameBox.Text = "";
            emailBox.Text = "";
            phoneBox.Text = "";
            departmentBox.Text = "";
        }
    }
}