using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace excelToDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void LoadExcelData(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    if (result.Tables.Count > 0)
                    {
                        DataTable dt = result.Tables[0];
                        dataGridView1.DataSource= dt;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Create a openFileDialog (The thing that you select file.)
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"; // The filter of files that will be selected
            openFileDialog.Title = "Select an Excel File"; // The title of what will be written in there

            if (openFileDialog.ShowDialog() == DialogResult.OK) // Now we check if the dialog has pressed Ok
            {
                string filePath = openFileDialog.FileName; // We get the filePath
                LoadExcelData(filePath); // And execute the LoadExcel function
            }
        }
    }
}
