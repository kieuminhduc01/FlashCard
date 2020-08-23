using FlashCard.Controller;
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
            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", txtGroupName.Text + ".xlsx");
            try
            {
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Group này đã tồn tại");
                    return;
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
