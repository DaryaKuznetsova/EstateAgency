using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace EstateAgency
{
    class ExportWord
    {
        private static string path = @"D:\Рабочий стол\отчеты\mytemplate.docx";
        public static void Report(string name, DateTime start, DateTime end, int flats, int rooms, int houses, int total, string filename)
        {
            int managerTotal = flats + rooms + houses;

            var app = new Word.Application();
            app.Visible = false;
            var doc = app.Documents.Add(path);

            ReplaceString("{managerName}", name, doc);
            ReplaceString("{startDate}", start.ToString(), doc);
            ReplaceString("{endDate}", end.ToString(), doc);
            ReplaceString("{flatCount}", flats.ToString(), doc);
            ReplaceString("{roomCount}", rooms.ToString(), doc);
            ReplaceString("{houseCount}", houses.ToString(), doc);
            ReplaceString("{managerTotal}", managerTotal.ToString(), doc);
            ReplaceString("{agencyTotal}", total.ToString(), doc);

            doc.SaveAs2(filename);
            app.Quit();
        }

        private static void ReplaceString(string strToReplace, string text, Word.Document doc)
        {
            var range = doc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: strToReplace, ReplaceWith: text);
        }
    }
}
