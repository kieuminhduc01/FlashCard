using FlashCard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FlashCard.Controller;

namespace FlashCard.View
{
    public partial class Menu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Menu()
        {
            InitializeComponent();
        }
        public void EventForButtonGroup(object sender, EventArgs e)
        {
            if (pnMain.Controls.Count > 0)
            {
                MessageBox.Show("bạn phải đóng form đang hiện trước");
                return;
            }
            Button btn = sender as Button;
            NhomTu nhomTu = new NhomTu() { TopLevel = false, TopMost = true }; ;
            nhomTu.Text = btn.Text;
            this.pnMain.Controls.Add(nhomTu);
            nhomTu.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChuDe chuDe = new ChuDe(this);
            chuDe.Show(); 
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            string folderPath = @"..\..\Data";
            string[] files = System.IO.Directory.GetFiles(folderPath, "*.xlsx");

            foreach (string s in files)
            {

                Button btnNewGroup = new Button();
                btnNewGroup.Size = new Size(280, 60);
                btnNewGroup.Text = Path.GetFileName(s).Replace(".xlsx", "");

                #region style for button
                btnNewGroup.BackColor = Color.FromArgb(0, 173, 116);
                btnNewGroup.FlatStyle = FlatStyle.Flat;
                btnNewGroup.FlatAppearance.BorderSize = 0;
                btnNewGroup.ForeColor = Color.White;
                btnNewGroup.Font = new Font("Arial", 15, FontStyle.Bold);
                btnNewGroup.ImageAlign = ContentAlignment.MiddleLeft;
                btnNewGroup.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnNewGroup.Image = Image.FromFile(@"..\..\Picture\words.png");
                #endregion

                
                btnNewGroup.Click += MouseClick;
                btnNewGroup.Click += new EventHandler(this.EventForButtonGroup);


                if (File.ReadAllLines(s).Length == 1)
                {
                    btnNewGroup.BackColor = Color.FromArgb(22, 131, 94);
                    btnNewGroup.Enabled = false;
                }
                this.pnShow.Controls.Add(btnNewGroup);
            }
        }

        private void MouseClick(object sender, EventArgs e)
        {
            foreach (Button btn in pnShow.Controls)
            {
                if (btn.BackColor == Color.FromArgb(22, 131, 94))
                {
                    btn.Enabled = false;
                    continue;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(0, 173, 116);
                }

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pnMain.Controls.Count > 0)
            {
                MessageBox.Show("save thay doi truoc khi dong form");
                e.Cancel = true;
            }
        }

        private void btnMoThuMucData_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\"));
        }
    }
}
