using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard.View
{
    public partial class ChuDe : Form
    {
        Menu menu;
        public ChuDe(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string csvHeader = "tagName,mean,StartTime,ATTT,IPA,pathOfSpeech,Example";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", txtGroupName.Text + ".xlsx");
            try
            {
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Group này đã tồn tại");
                }
                else
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "tagName";
                    ws.Cells[1, 2] = "mean";
                    ws.Cells[1, 3] = "StartTime";
                    ws.Cells[1, 4] = "Step";
                    ws.Cells[1, 5] = "IPA";
                    ws.Cells[1, 6] = "pathOfSpeech";
                    ws.Cells[1, 7] = "Example";
                    wb.SaveAs(filePath, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    wb.Close();
                    app.Quit();

                    MessageBox.Show("Tạo Group Thành Công");

                    System.Windows.Forms.Button btnNewGroup = new System.Windows.Forms.Button();
                    btnNewGroup.Size = new Size(280, 60);
                    btnNewGroup.Text = txtGroupName.Text;
                    btnNewGroup.Click += new EventHandler(menu.EventForButtonGroup);

                    #region style for button
                    btnNewGroup.BackColor = Color.FromArgb(22, 131, 94);
                    btnNewGroup.FlatStyle = FlatStyle.Flat;
                    btnNewGroup.FlatAppearance.BorderSize = 0;
                    btnNewGroup.ForeColor = Color.White;
                    btnNewGroup.Font = new System.Drawing.Font("Arial", 15, FontStyle.Bold);
                    btnNewGroup.ImageAlign = ContentAlignment.MiddleLeft;
                    btnNewGroup.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnNewGroup.Image = Image.FromFile(@"..\..\Picture\words.png");

                    #endregion
                    btnNewGroup.Enabled = false;
                    menu.pnShow.Controls.Add(btnNewGroup);
                }
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = filePath;
                    openFileDialog.Filter = "txt files (*.xlsx)|*.xlsx";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                           // fileContent = reader.ReadToEnd();
                        }
                    }
                }
                Process.Start(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\"));

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void ChuDe_Load(object sender, EventArgs e)
        {

        }
    }
}
