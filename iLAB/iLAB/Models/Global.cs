using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLAB.Models
{
    public class Global
    {
        public static Employee Account;

        public static int DayOfWeek = 7;
        public static int DayOfColumn = 6;

        public static int dateButtonWidth = 86;
        public static int dateButtonHeight = 50;

        public static int margin = 6;
        public static int notifyTime = 1;
        public static int notifyTimeOut = 10000;

        public static void ExportToExcel(DataGridView dtgv)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "StudentDetail";

            for (int i = 1; i < dtgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgv.Columns[i - 1].HeaderText;
            }

            for (int i = 1; i < dtgv.Rows.Count; i++)
            {
                for (int j = 0; j < dtgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 1, j + 1] = dtgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = "xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing
                    , Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive
                    , Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
