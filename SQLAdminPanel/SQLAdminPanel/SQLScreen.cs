using System;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace SQLAdminPanel
{
    public partial class SQLScreen : Form
    {
        private SqlConnection connection;
        public SQLScreen(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection to the database is open.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening the database connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateList();
        }
        private void UpdateList()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DataTable dt = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM users", connection))
                {
                    adapter.Fill(dt);
                }

                viewGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldnt Refresh List." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO users VALUES (@FirstName, @LastName, @Age, @Email)", connection);
                cmd.Parameters.AddWithValue("@FirstName", firstNameBox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameBox.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(ageBox.Text));
                cmd.Parameters.AddWithValue("@Email", emailBox.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Insert operation successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Insert operation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error performing insert operation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Close the connection when the form is closed
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Connection to the database is closed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshButton_onClick(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand delete = new SqlCommand("delete from users where id = @Id", connection);
                delete.Parameters.AddWithValue("@Id", int.Parse(idBox.Text));

                int rowsAffected = delete.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete operation successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("No rows were deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldnt delete the row" + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customCommand_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand custom = new SqlCommand($"{customBox.Text}", connection);
                int rowsAffected = custom.ExecuteNonQuery();

                if (rowsAffected > 0 )
                {
                    MessageBox.Show("You succesfully executed the command: " + customBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Your command doesnt affected any role: " + customBox.Text, "?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your command didnt worked: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportTable_Click(object sender, EventArgs e)
        {
            try
            {
                var excelApp = new Application();

                var workbook = excelApp.Workbooks.Add();

                var worksheet = (Worksheet)workbook.ActiveSheet;

                DataTable dt = (DataTable)viewGrid.DataSource;

                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1] = dt.Columns[col].ColumnName;
                }

                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1] = dt.Rows[row][col];
                    }
                }

                workbook.SaveAs("./Export.xlsx");

                workbook.Close();
                excelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("Export successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
