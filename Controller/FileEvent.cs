using FlashCard.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Controller
{
    /// <summary>
    /// Thực hiên thao tác với file
    /// </summary>
    public static class FileEvent
    {
        /// <summary>
        /// Thêm mới file từ vựng
        /// </summary>
        /// <param name="tenFile">Tên file</param>
        /// <returns>true: khi dữ tạo file thành công, false khi có tên file bị trùng</returns>
        public static bool TaoMoiFileTuVung(string tenFile)
        {
            try
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", tenFile + ".xlsx");
                if (File.Exists(filePath))
                {
                    return false;
                }
                else
                {

                    #region Tạo file Excel
                    Excel excel = new Excel();
                    excel.CreateNewFile();
                    excel.SaveAs(filePath);
                    excel.Close();

                    excel = new Excel(filePath, 1);

                    excel.WriteToCell(1, 1, "tagName");
                    excel.WriteToCell(1, 2, "mean");
                    excel.WriteToCell(1, 3, "StartTime");
                    excel.WriteToCell(1, 4, "ATTT");
                    excel.WriteToCell(1, 5, "IPA");
                    excel.WriteToCell(1, 6, "pathOfSpeech");
                    excel.WriteToCell(1, 7, "Example");
                    excel.Save();
                    excel.Close();
                    #endregion
                }
            }
            catch
            {
                throw;
            }
            return true;
        }
        public static void LuuFileTuVung(string tenFile, List<Word> lstAllWords)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", tenFile + ".xlsx");

            Excel excel = new Excel(filePath, 1);


            try
            {
                excel.WriteToCell(1, 1, "tagName");
                excel.WriteToCell(1, 2, "mean");
                excel.WriteToCell(1, 3, "StartTime");
                excel.WriteToCell(1, 4, "ATTT");
                excel.WriteToCell(1, 5, "IPA");
                excel.WriteToCell(1, 6, "pathOfSpeech");
                excel.WriteToCell(1, 7, "Example");
                int i = 2;
                foreach (Word item in lstAllWords)
                {

                    excel.WriteToCell(i, 1, item.tagName);
                    excel.WriteToCell(i, 2, item.mean);
                    excel.WriteToCell(i, 3, item.startTime.ToString());
                    excel.WriteToCell(i, 4, item.ATTT);
                    excel.WriteToCell(i, 5, item.IPA);
                    excel.WriteToCell(i, 6, item.pathOfSpeech);
                    excel.WriteToCell(i, 7, item.Example);

                    i++;
                }
                excel.Save();
            }
            catch
            {
                throw;
            }
            finally
            {
                excel.Close();
            }
        }
        public static 
    }
}
