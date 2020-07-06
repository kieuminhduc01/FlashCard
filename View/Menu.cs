using FlashCard.Model;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void EventForButtonGroup(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            NhomTu nhomTu = new NhomTu();
            nhomTu.Text = btn.Text;
            nhomTu.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChuDe chuDe = new ChuDe(this);
            chuDe.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            string folderPath = @"C:\Users\admin\Desktop\PhanMemFLashCard\FlashCard\Data";
            string[] files = System.IO.Directory.GetFiles(folderPath, "*.csv");

            foreach (string s in files)
            {
                Button btnNewGroup = new Button();
                btnNewGroup.Size = new Size(280, 60);
                btnNewGroup.Text = Path.GetFileName(s).Replace(".csv","");
                btnNewGroup.BackColor = Color.White;
                btnNewGroup.Font = new Font("Arial", 15, FontStyle.Bold);
                btnNewGroup.TextAlign = ContentAlignment.MiddleLeft;
                btnNewGroup.Click += new EventHandler(this.EventForButtonGroup);

                this.pnShow.Controls.Add(btnNewGroup);
            }
        }
    }
}
