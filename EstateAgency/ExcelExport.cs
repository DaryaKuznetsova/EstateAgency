using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstateAgency
{
    class ExcelExport
    {
        public static void ExportFiles(System.Data.DataTable dt, string filename)
        {

            //var app = new Application();
            //app.Visible = true;
            //var wb = app.Workbooks.Add();
            //var ws = wb.Worksheets[1] as Worksheet;
            //ws.Cells[1, 1].Value = 567;
            //wb.SaveAs(filename);
            //app.Quit();

            //Application ex = new Application();
            //ex.Visible = false;
            //Количество листов в рабочей книге
            //ex.SheetsInNewWorkbook = 1;
            //Добавить рабочую книгу
            //Workbooks wbs = ex.Workbooks;
            //Workbook workBook = wbs.Add();
            ////Excel.Workbook workBook = wbs.Add(Type.Missing);
            ////Отключить отображение окон с сообщениями
            //ex.DisplayAlerts = false;
            ////Получаем первый лист документа (счет начинается с 1)
            //Worksheet sheet = workBook.Worksheets.get_Item(1);
            //workBook.Worksheets.Add(dt, "WorksheetName");


            //var lines = new List<string>();

            //string[] columnNames = dt.Columns
            //    .Cast<DataColumn>()
            //    .Select(column => column.ColumnName)
            //    .ToArray();

            //var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            //lines.Add(header);

            //var valueLines = dt.AsEnumerable()
            //    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

            //lines.AddRange(valueLines);

            //File.WriteAllLines("excel.csv", lines);

            //try
            //{
            //    workBook.SaveAs(filename);
            //}
            //finally
            //{

            //}
            //wbs.Close();
            //ex.Quit();
        }
    }
}
