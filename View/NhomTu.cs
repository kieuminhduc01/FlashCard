using FlashCard.Model;
using FlashCard.Model.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FlashCard.Controller;
using System.Threading;

namespace FlashCard.View
{
    public partial class NhomTu : Form
    {
        List<Word> dsTatCaCacTu = new List<Word>();
        List<Word> lstTuChuaCoLichOn = new List<Word>();
        List<Word> dsTuHienTai = new List<Word>();
        ChiaDanhSach loaiDsChiaTu;
        Word tuHienTai = new Word();
        int currentIndexWord = 0;
        int side = 0;//0 is front,1 is back,2 is both of them

        public NhomTu()
        {
            InitializeComponent();
        }
        private void HienThe(int indexWord)
        {
            try
            {
                tuHienTai = dsTuHienTai[indexWord];
                #region set thành phần hiển thị
                if (cbHienAmThanhTuongTu.Checked)
                {
                    lbATTT.Visible = true;
                }
                else
                {
                    lbATTT.Visible = false;
                }


                lbTagName.Text = tuHienTai.tagName;
                lbPathOfSpeech.Text = tuHienTai.pathOfSpeech;
                lbIPA.Text = tuHienTai.IPA;
                lbMean.Text = tuHienTai.mean;
                lbExample.Text = tuHienTai.Example;
                lbATTT.Text = tuHienTai.ATTT;
                if (tuHienTai.Status == Status.forget)
                {
                    pnBack.BackColor = Color.FromArgb(211, 59, 2);
                    pnFront.BackColor = Color.FromArgb(211, 59, 2);
                }
                else if (tuHienTai.Status == Status.remember)
                {
                    pnBack.BackColor = Color.Green;
                    pnFront.BackColor = Color.Green;
                }
                if (tuHienTai.Status == Status.willRecall)
                {
                    pnBack.BackColor = Color.Gray;
                    pnFront.BackColor = Color.Gray;
                }

                dtpkSetTgOn.SetDate(tuHienTai.startTime);
                lbTuTongSo.Text = (currentIndexWord + 1).ToString() + "/" + dsTuHienTai.Count.ToString();
                #endregion
            }
            catch
            {
            }
        }

        private void btnAllTu_Click_1(object sender, EventArgs e)
        {
            dsTuHienTai = dsTatCaCacTu;
            if (dsTuHienTai.Count > 0)
            {
                loaiDsChiaTu = ChiaDanhSach.AllList;
                dsTuHienTai = dsTatCaCacTu;
                tuHienTai = dsTuHienTai[0];
                currentIndexWord = 0;
                HienThe(currentIndexWord);
            }
            else
            {
                MessageBox.Show("Danh sách trống");

            }

        }

        private void NhomTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Trước khi đóng form bạn nhớ phải lưu thay đổi trước đã?", "chú ý!!!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    FileEvent.LuuFileTuVung(this.Text, dsTatCaCacTu);
                    MessageBox.Show("Lưu thành công!!");
                }
                catch (Exception ed)
                {
                    MessageBox.Show("Lỗi khi lưu");
                    e.Cancel = true;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstTuChuaCoLichOn = FileEvent.DocDanhSachTuChuaCoLichOn(dsTatCaCacTu);
            if (lstTuChuaCoLichOn.Count() > 0)
            {
                loaiDsChiaTu = ChiaDanhSach.LichOnTrongQuaKhu;
                dsTuHienTai = lstTuChuaCoLichOn;
                tuHienTai = dsTuHienTai[0];
                currentIndexWord = 0;
                HienThe(currentIndexWord);
            }
            else
            {
                MessageBox.Show("Không có từ nào có lịch ôn trong quá khứ");
            }
        }

        private void cbHienAmThanhTuongTu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienAmThanhTuongTu.Checked)
            {
                lbATTT.Visible = true;
            }
            else
            {
                lbATTT.Visible = false;
            }
        }

        private void dtpkSetTgOn_DateChanged(object sender, DateRangeEventArgs e)
        {
            tuHienTai.startTime = dtpkSetTgOn.SelectionRange.Start;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileEvent.LuuFileTuVung(this.Text, dsTatCaCacTu);
                MessageBox.Show("Lưu thành công!!");
            }
            catch
            {
                MessageBox.Show("Lỗi khi lưu");
            }

        }
        private void NhomTu_Load(object sender, EventArgs e)
        {
            try
            {
                var dsTuThread = new Thread(() => dsTatCaCacTu = FileEvent.DocDanhSachTatCaTuVung(this.Text));
                dsTuThread.Start();
            }
            catch
            {
                MessageBox.Show("Lỗi đọc file");
            }
        }

        private void NhomTu_KeyUp(object sender, KeyEventArgs e)
        {

            #region control key
            if (e.KeyCode == Keys.Insert)
            {
                lstTuChuaCoLichOn = FileEvent.DocDanhSachTuChuaCoLichOn(dsTatCaCacTu);
                if (lstTuChuaCoLichOn.Count() > 0)
                {
                    loaiDsChiaTu = ChiaDanhSach.LichOnTrongQuaKhu;
                    dsTuHienTai = lstTuChuaCoLichOn;
                    tuHienTai = dsTuHienTai[0];
                    currentIndexWord = 0;
                    HienThe(currentIndexWord);
                }
                else
                {
                    MessageBox.Show("Không có từ nào có lịch ôn trong quá khứ");
                }
            }
            if (e.KeyCode == Keys.Divide)
            {
                if (cbHienAmThanhTuongTu.Checked)
                {
                    cbHienAmThanhTuongTu.Checked=false;
                    lbATTT.Visible = false;
                }
                else
                {
                    cbHienAmThanhTuongTu.Checked = true;
                    lbATTT.Visible = true;
                }
            }
            if (e.KeyCode == Keys.Add)
            {
                PlusDays(1);
                return;
            }
            if (e.KeyCode == Keys.Subtract)
            {
                PlusDays(-1);
                return;
            }
            if (e.KeyCode == Keys.Multiply)
            {
                ResetTime();
                return;
            }

            if (e.KeyCode == Keys.S)
            {
                pnFront.Visible = false;
                pnBack.Visible = true;
                side = 0;
                return;
            }
            if (e.KeyCode == Keys.W)
            {
                pnFront.Visible = true;
                pnBack.Visible = false;
                side = 1;
                return;

            }
            if (e.KeyCode == Keys.D)
            {
                if (currentIndexWord == dsTuHienTai.Count - 1)
                {
                    return;
                }
                currentIndexWord++;
                tuHienTai = dsTuHienTai[currentIndexWord];
                HienThe(currentIndexWord);
                return;

            }
            if (e.KeyCode == Keys.A)
            {
                if (currentIndexWord == 0)
                {
                    return;
                }
                currentIndexWord--;
                tuHienTai = dsTuHienTai[currentIndexWord];
                HienThe(currentIndexWord);
                return;

            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                pnBack.Visible = true;
                pnFront.Visible = true;
                return;

            }
           
            #endregion
        }

        private void PlusDays(int numOfDays)
        {
            tuHienTai.startTime = tuHienTai.startTime.AddDays(numOfDays);
            dtpkSetTgOn.SetDate(tuHienTai.startTime);
        }
        private void ResetTime()
        {
            tuHienTai.startTime = DateTime.Now;
            dtpkSetTgOn.SetDate(tuHienTai.startTime);
        }
    }
}


