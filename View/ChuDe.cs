using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string csvHeader = "tagName,mean,StartTime,Step,ATTT,IPA,pathOfSpeech,Example";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", txtGroupName.Text + ".csv");
            try
            {
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Group này đã tồn tại");
                }
                else
                {
                    File.WriteAllText(filePath, csvHeader);


                    MessageBox.Show("Tạo Group Thành Công"); 
                    
                    Button btnNewGroup = new Button();
                    btnNewGroup.Size = new Size(280, 60);
                    btnNewGroup.Text = txtGroupName.Text;
                    btnNewGroup.BackColor = Color.White;
                    btnNewGroup.Font = new Font("Arial",15,FontStyle.Bold);
                    btnNewGroup.TextAlign = ContentAlignment.MiddleLeft;
                    btnNewGroup.Click += new EventHandler(menu.EventForButtonGroup);

                    menu.pnShow.Controls.Add(btnNewGroup);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
