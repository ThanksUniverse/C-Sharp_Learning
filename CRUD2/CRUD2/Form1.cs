using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace CRUD2
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=PEDRO\\SQLEXPRESS;Initial Catalog=Crud2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection? con;
        public Form1()
        {
            InitializeComponent();
            connectSql();
            InitializeStartValues();
        }

        private void connectSql()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                con = connection;
            }
            catch
            {
                MessageBox.Show("We couldnt connect you to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InitializeStartValues()
        {
            notifyPrompt.Text = "";
        }

        private void MessagePrompt(string message, Color color)
        {
            notifyPrompt.Text = message;
            notifyPrompt.ForeColor = color;
        }

        private bool verifySearch()
        {
            if (searchBox.Text == "" && idBox.Text == "" && nameBox.Text == "" && emailBox.Text == "")
            {
                MessagePrompt("You need to fill at least the search box to search", Color.DarkRed);
                return false;
            }
            return true;
        }

        private void searchDatabase()
        {
            try
            {
                using (SqlCommand cmd = new("spSearchEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    int idValue = 0;
                    bool hasFound = false;

                    if (searchBox.Text.Length > 0)
                    {
                        if (int.TryParse(searchBox.Text, out idValue))
                            cmd.Parameters.AddWithValue("@Id", idValue);
                        else if (searchBox.Text.Length > 0)
                        {
                            cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                            cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                        }

                        hasFound = true;
                    }

                    bool isNumber = !hasFound && int.TryParse(idBox.Text, out idValue);
                    if (isNumber)
                    {
                        cmd.Parameters.AddWithValue("@Id", idValue);
                        hasFound = true;
                    }
                    if (nameBox.Text != "" && !hasFound)
                    {
                        cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                        hasFound = true;
                    }
                    if (emailBox.Text != "" && !hasFound)
                    {
                        cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                        hasFound = true;
                    }

                    using (SqlDataAdapter adapter = new(cmd))
                    {
                        using (DataTable dataTable = new())
                        {
                            adapter.Fill(dataTable);
                            int rows = dataTable.Rows.Count;
                            if (rows <= 0)
                            {
                                MessagePrompt("There was no results.", Color.AliceBlue);
                                sqlView.DataSource = null;
                                return;
                            }
                            MessagePrompt($"There was {rows} results.", Color.AliceBlue);
                            sqlView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessagePrompt($"We couldnt deal with your request." + ex.Message, Color.AliceBlue);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!verifySearch())
                return;

            searchDatabase();
        }

        private void closedForm(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("We safely disconnected you from the database", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con?.Close();
        }

        private void SetValues(string? id, string? name, string? email, string? phone, string? gender, string? city, int? departmentId)
        {
            idBox.Text = id;
            nameBox.Text = name;
            emailBox.Text = email;
            phoneBox2.Text = phone;
            genderBox.Text = gender;
            cityBox.Text = city;
            EDepartment department = (EDepartment)departmentId;
            departmentBox.Text = department.ToString();
            MessagePrompt($"Values updated for {name}.", Color.AliceBlue);
        }

        private void sqlView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = sqlView.Rows[e.RowIndex];

                if (row.Cells["Id"].Value == null)
                    return;

                string? id = row.Cells["Id"].Value.ToString();
                if (id == null || id == "") return;
                string? name = row.Cells["Name"].Value.ToString();
                string? email = row.Cells["Email"].Value.ToString();
                string? phone = row.Cells["Phone"].Value.ToString();
                string? gender = row.Cells["Gender"].Value.ToString();
                string? city = row.Cells["City"].Value.ToString();
                int? department = int.Parse(row.Cells["DepartmentId"].Value.ToString());
                SetValues(id, name, email, phone, gender, city, department);
            }
        }

        private void insertValues()
        {
            try
            {
                using (SqlCommand cmd = new("spInsertEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneBox2.Text);
                    cmd.Parameters.AddWithValue("@Gender", genderBox.Text);
                    cmd.Parameters.AddWithValue("@City", cityBox.Text);
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentBox.SelectedIndex + 1);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessagePrompt($"You inserted your new value in the database.\n{rows} changed.", Color.DarkSeaGreen);
                    else
                        MessagePrompt("Nothing happened.", Color.DarkRed);
                }
            }
            catch (Exception ex)
            {
                MessagePrompt($"We couldnt deal with your request." + ex.Message, Color.DarkBlue);
            }
        }

        private bool checkValues()
        {
            if (nameBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the name box", Color.DarkBlue);
                return false;
            }
            if (emailBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the email box", Color.DarkBlue);
                return false;
            }
            if (phoneBox2.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the phone box", Color.DarkBlue);
                return false;
            }
            if (genderBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the gender box", Color.DarkBlue);
                return false;
            }
            if (cityBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the city box", Color.DarkBlue);
                return false;
            }
            if (departmentBox.Text.Length <= 0)
            {
                MessagePrompt("You need to fill the department box", Color.DarkBlue);
                return false;
            }
            return true;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (!checkValues())
                return;

            insertValues();
            searchDatabase();
        }

        private void updateValues()
        {
            try
            {
                using (SqlCommand cmd = new("spUpdateEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    int Id = 0;
                    bool isId = int.TryParse(idBox.Text, out Id);
                    if (!isId)
                    {
                        MessagePrompt($"We couldnt convert your id.", Color.DarkBlue);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phoneBox2.Text);
                    cmd.Parameters.AddWithValue("@Gender", genderBox.Text);
                    cmd.Parameters.AddWithValue("@City", cityBox.Text);
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentBox.SelectedIndex + 1);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessagePrompt($"You updated your new value in the database.", Color.DarkSeaGreen);
                    else
                        MessagePrompt("Nothing happened.", Color.DarkRed);
                }
            }
            catch (Exception ex)
            {
                MessagePrompt($"We couldnt deal with your request." + ex.Message, Color.DarkBlue);
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!checkValues())
                return;

            updateValues();
            searchDatabase();
        }

        private void deleteValues()
        {
            try
            {
                using (SqlCommand cmd = new("spDeleteEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    int Id = 0;
                    bool isId = int.TryParse(idBox.Text, out Id);
                    if (!isId)
                    {
                        MessagePrompt($"We couldnt convert your id.", Color.DarkBlue);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@Id", Id);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessagePrompt($"You deleted a value in the database.", Color.DarkSeaGreen);
                    else
                        MessagePrompt("Nothing happened.", Color.DarkRed);
                }
            }
            catch (Exception ex)
            {
                MessagePrompt($"We couldnt deal with your request." + ex.Message, Color.DarkBlue);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessagePrompt("Fill your ID", Color.DarkBlue);
                return;
            }

            deleteValues();
            searchDatabase();
        }
    }
}