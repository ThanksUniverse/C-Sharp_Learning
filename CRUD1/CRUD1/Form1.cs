using System.Data.SqlClient;
using System.Data;

namespace CRUD1
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=PEDRO\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
            StartComponents();
        }

        public void StartComponents()
        {
            cityBox.SelectedIndex = 0;
            genderBox.SelectedIndex = 0;
            MessagePrompt($"Welcome its {DateTime.Now:D}", Color.DarkGreen);
        }

        public void MessagePrompt(string message, Color color)
        {
            messageLabel.Text = message;
            messageLabel.ForeColor = color;
        }

        private bool CheckId()
        {
            if (idBox.Text == "")
            {
                MessagePrompt("Please input the ID", Color.DarkRed);
                return false;
            }
            return true;
        }

        private bool CheckValues()
        {
            if (nameBox.Text == "")
            {
                MessagePrompt("Please input the name", Color.DarkRed);
                return false;
            }
            if (cityBox.Text == "")
            {
                MessagePrompt("Please input the city", Color.DarkRed);
                return false;
            }
            if (ageBox.Text == "")
            {
                MessagePrompt("Please input the age", Color.DarkRed);
                return false;
            }
            if (genderBox.Text == "")
            {
                MessagePrompt("Please input the gender", Color.DarkRed);
                return false;
            }
            if (contactBox.Text == "")
            {
                MessagePrompt("Please input the contact", Color.DarkRed);
                return false;
            }

            return true;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (!CheckValues())
                return;
            using (SqlConnection con = new(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new("spInsertEmployee", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                        cmd.Parameters.AddWithValue("@City", cityBox.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(ageBox.Text));
                        cmd.Parameters.AddWithValue("@Gender", genderBox.Text);
                        cmd.Parameters.AddWithValue("@Contact", contactBox.Text);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows <= 0)
                            MessagePrompt("Nothing happened", Color.LightGray);
                        else
                            MessagePrompt($"We inserted {rows} rows", Color.LightGray);
                    }
                    catch (Exception ex)
                    {
                        MessagePrompt("We couldnt insert your value:" + ex.Message, Color.DarkRed);
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!CheckValues())
                return;
            UpdateColumn();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new(connectionString))
                {
                    con.Open();
                    using (SqlDataAdapter adapter = new("spReadAllEmployees", con))
                    {
                        using (DataTable dataTable = new())
                        {
                            adapter.Fill(dataTable);

                            sqlView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessagePrompt("We couldnt get the list for you:" + ex.Message, Color.DarkRed);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!CheckId())
                return;
            using (SqlConnection con = new(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new("spDeleteEmployee", con))
                    {
                        cmd.Parameters.AddWithValue("@Id", int.Parse(idBox.Text));
                        cmd.CommandType = CommandType.StoredProcedure;

                        int rows = cmd.ExecuteNonQuery();
                        if (rows <= 0)
                            MessagePrompt("Nothing happened", Color.LightBlue);
                        else
                        {
                            MessagePrompt($"We deleted {rows} rows", Color.LightBlue);
                            UpdateColumn();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessagePrompt("We couldnt delete your value:" + ex.Message, Color.DarkRed);
                }

            }
        }

        private void UpdateColumn()
        {
            if (!CheckValues())
                return;
            using (SqlConnection con = new(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new("spUpdateEmployee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", idBox.Text);
                        cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                        cmd.Parameters.AddWithValue("@City", cityBox.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(ageBox.Text));
                        cmd.Parameters.AddWithValue("@Gender", genderBox.Text);
                        cmd.Parameters.AddWithValue("@Contact", contactBox.Text);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows <= 0)
                            MessagePrompt("Nothing happened", Color.LightGray);
                        else
                        {
                            MessagePrompt($"We updated {rows} rows", Color.LightGray);
                            UpdateColumn();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessagePrompt("We couldnt update your value:" + ex.Message, Color.DarkRed);
                }

            }
        }

        private void searchID_Click(object sender, EventArgs e)
        {
            if (!CheckId())
                return;
            using (SqlConnection con = new(connectionString))
            {
                con.Open();
                int rowsCount = 0;
                DateTime receiveData;
                string dateTime = "Not Loaded";
                try
                {
                    using (SqlCommand cmd = new("spFindEmployee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", int.Parse(idBox.Text));
                        {
                            using (SqlDataAdapter adapter = new(cmd))
                            {
                                using (DataTable dataTable = new())
                                {
                                    adapter.Fill(dataTable);
                                    rowsCount = dataTable.Rows.Count;
                                    if (rowsCount <= 0)
                                    {
                                        MessagePrompt("We didnt found any value", Color.LightBlue);
                                        sqlView.DataSource = null;
                                        return;
                                    }
                                    else
                                    {
                                        using (SqlDataReader reader = cmd.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                receiveData = reader.GetDateTime(reader.GetOrdinal("JoiningDate"));
                                                dateTime = $"{receiveData:D}";
                                                UpdateJoinBox(dateTime);
                                                nameBox.Text = reader.GetString(reader.GetOrdinal("Name"));
                                                cityBox.Text = reader.GetString(reader.GetOrdinal("City"));
                                                ageBox.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("Age")));
                                                genderBox.Text = reader.GetString(reader.GetOrdinal("Gender"));
                                                contactBox.Text = reader.GetString(reader.GetOrdinal("Contact"));
                                            }
                                        }
                                        sqlView.DataSource = dataTable;
                                    }

                                }

                            }
                            MessagePrompt($"We found {rowsCount} rows", Color.LightBlue);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessagePrompt("We couldnt find your value:" + ex.Message, Color.DarkRed);
                }

            }
        }

        private void UpdateJoinBox(string date)
        {
            joinBox.Text = date;
            joinBox.ForeColor = Color.DarkGreen;
        }
    }
}