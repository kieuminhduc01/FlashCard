using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace FlashCard.Controller
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public Excel()
        {
        }

        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        public string ReadCell(int row, int column)
        {
            var noiDungCell = ws.Cells[row, column].Value2;
            if (noiDungCell != null)
            {
                return noiDungCell + "";
            }
            else
            {
                return "";
            }
        }
        public void WriteToCell(int row, int column, string noiDungCuaCell)
        {
            ws.Cells[row, column].Value2 = noiDungCuaCell;
        }
        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
        public void Close()
        {
            wb.Close(true);
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        }
    }
}
