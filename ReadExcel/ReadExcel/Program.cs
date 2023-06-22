using System;
using IronXL;

namespace ReadExcel
{
    class Program
    {
        static void Main()
        {
            WorkBook workBook = WorkBook.Load("test.xlsx"); // Load excel workbook << File
            WorkSheet sheet = workBook.GetWorkSheet("Planilha1"); // Load excel sheet
            string insertColumns = ""; // Get the columns with the values
            foreach (var cell in sheet["A1:E1"])
                insertColumns += cell + ",";

            insertColumns = insertColumns.Remove(insertColumns.Length - 1);

            Cell lastCell = sheet.LastFilledCell;

            for (int row = 1; row <= lastCell.RowIndex; row++)
            { 
                string insertValue = "";
                foreach (var cell in sheet.GetRow(row)) 
                {
                    if (cell.IsEmpty)
                        break;

                    insertValue += cell + ",";
                }
                insertValue = insertValue.Remove(insertValue.Length - 1);
                Console.WriteLine($"insert into accounts ({insertColumns}) values ({insertValue})");
            }
        }
    }
}