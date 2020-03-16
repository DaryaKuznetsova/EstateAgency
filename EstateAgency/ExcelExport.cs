using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;

namespace EstateAgency
{
    class ExcelExport
    {
        public static void ExportFiles(System.Data.DataTable dt, string filename)
        {
            var app = new Excel.Application();
            app.Visible = true;
            var wb = app.Workbooks.Add();
            var ws = wb.Worksheets[1] as Excel.Worksheet;
            ws.Cells[1, 1].Value = 567;
            wb.SaveAs(filename);
            app.Quit();
        }

        private static string[,] ArrRange(int rowStart, int columnStart, int rowEnd, int columnEnd, Excel.Worksheet ws)
        {
            rowEnd++;
            columnEnd++;
            Excel.Range range = (Excel.Range)ws.Range[ws.Cells[rowStart, columnStart], ws.Cells[rowEnd, columnEnd]]; // Читаем значения ячеек с листа
            object[,] temp = range.Value2; // Записываем значения в массив
            string[,] returnstring = new string[rowEnd - rowStart, columnEnd - columnStart]; // Работаем с массивом строк
            for (int p = 1; p <= rowEnd - rowStart; p++)
                for (int q = 1; q <= columnEnd - columnStart; q++)
                {
                    if(temp[p, q]!=null)
                    returnstring[p - 1, q - 1] = temp[p, q].ToString(); // Переписываем значения
                }

            return returnstring;
        }

        private static void GetCellValue(Excel.Worksheet sheet, SqlConnection sqlConnection)
        {
            int lastRow = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row; // Последняя заполненная строка
            string[,] mas = new string[lastRow, 4]; // Выделяем память под массив строк

            mas = ArrRange(2, 1, lastRow, 12, sheet); // Получаем данные с листа

            for (int l = 0; l < lastRow - 1; l++) // Заполняем массив
            {
                int statusId = Convert.ToInt32(mas[l, 0]);
                int ownerId = Convert.ToInt32(mas[l, 1]);
                float price = (float)Convert.ToDouble(mas[l, 2]);
                string addres = mas[l, 3];
                int district = Convert.ToInt32(mas[l, 4]);
                string description = mas[l, 5];
                int realtytype = Convert.ToInt32(mas[l, 6]);
                int tradetype = Convert.ToInt32(mas[l, 7]);
                float area = (float)Convert.ToDouble(mas[l, 8]);
                byte rooms = Convert.ToByte(mas[l, 9]);
                string landdescription = mas[l, 10];
                float landarea = (float)Convert.ToDouble(mas[l, 11]);
                try
                {
                    if (realtytype == 3) EstateObjects.Insert(sqlConnection, statusId, ownerId, price, addres, district, description, realtytype, tradetype, area, rooms, landdescription, landarea);
                    if (realtytype == 1) EstateObjects.Insert(sqlConnection, statusId, ownerId, price, addres, district, description, realtytype, tradetype, area, rooms);
                    if (realtytype == 2) EstateObjects.Insert(sqlConnection, statusId, ownerId, price, addres, district, description, realtytype, tradetype, area);

                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

        }

        public static void InsetExcel(string filename, SqlConnection sqlConnection)
        {
            Excel.Application ex = new Excel.Application();
            Excel.Workbooks wbs = null;
            Excel.Workbook xlWB;

            Excel.Worksheet xlSht;
            wbs = ex.Workbooks;

            try
            {
                xlWB = wbs.Open(filename, 
  Type.Missing, Type.Missing, Type.Missing, Type.Missing,
  Type.Missing, Type.Missing, Type.Missing, Type.Missing,
  Type.Missing, Type.Missing, Type.Missing, Type.Missing,
  Type.Missing, Type.Missing); //открываем файл 
                xlSht = xlWB.Worksheets[1];
                GetCellValue(xlSht, sqlConnection);
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
            }

            wbs.Close();
            ex.Quit();
        }


    }
}
