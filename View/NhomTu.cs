using CsvHelper;
using FlashCard.Model;
using FlashCard.Model.Enum;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using FlashCard.Controller;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace FlashCard.View
{
    public partial class NhomTu : Form
    {
        List<Word> lstAllWordsByDay = new List<Word>();
        List<Word> lstWordsRemembed = new List<Word>();
        List<Word> dsTuOnLai = new List<Word>();
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
            this.MouseWheel += NhomTu_MouseWheel;
        }

        private void NhomTu_MouseWheel(object sender, MouseEventArgs e)
        {
            if (side == 1)
            {
                pnFront.Visible = false;
                pnBack.Visible = true;
                side = 0;
            }
            else if (side == 0)
            {
                pnFront.Visible = true;
                pnBack.Visible = false;
                side = 1;
            }
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

                numIndexWord.Value = indexWord;
                lbTuTongSo.Text = numIndexWord.Value + "/" + (dsTuHienTai.Count() - 1);
                dtpkSetTgOn.SetDate(tuHienTai.startTime);
                #endregion
            }
            catch
            {
            }
        }
        public void BatTatNutChuyenThe()
        {
            if (currentIndexWord == 0)//khoa nut quay lai
            {
                btnPre.Enabled = false;
            }
            else
            {
                btnPre.Enabled = true;
            }


            if ((dsTuHienTai.Count() - 1) == currentIndexWord)//khoa nut di tiep
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            btnPre.Enabled = true;
            currentIndexWord++;
            tuHienTai = dsTuHienTai[currentIndexWord];
            HienThe(currentIndexWord);
            BatTatNutChuyenThe();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            tuHienTai.Status = Status.forget;
            pnBack.BackColor = Color.FromArgb(211, 59, 2);
            pnFront.BackColor = Color.FromArgb(211, 59, 2);
        }

        private void btnRemembed_Click(object sender, EventArgs e)
        {
            tuHienTai.Status = Status.remember;
            pnBack.BackColor = Color.Green;
            pnFront.BackColor = Color.Green;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            currentIndexWord--;
            tuHienTai = dsTuHienTai[currentIndexWord];
            HienThe(currentIndexWord);
            BatTatNutChuyenThe();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (side == 1)
            {
                pnFront.Visible = false;
                pnBack.Visible = true;
                side = 0;
            }
            else if (side == 0)
            {
                pnFront.Visible = true;
                pnBack.Visible = false;
                side = 1;
            }
        }
        private void numIndexWord_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                currentIndexWord = Convert.ToInt32(numIndexWord.Value);
                tuHienTai = dsTuHienTai[currentIndexWord];
                HienThe(currentIndexWord);
            }
            catch
            {
            }
        }

        private void btnTuDaThuoc_Click(object sender, EventArgs e)
        {

            if (loaiDsChiaTu == ChiaDanhSach.AllList)
            {
                dsTuHienTai = dsTatCaCacTu;
            }
            else if (loaiDsChiaTu == ChiaDanhSach.ByDay)
            {
                dsTuHienTai = lstAllWordsByDay;
            }
            lstWordsRemembed.Clear();
            foreach (Word rememberWord in dsTuHienTai)
            {
                if (rememberWord.Status == Status.remember)
                {
                    lstWordsRemembed.Add(rememberWord);
                }
            }
            if (lstWordsRemembed.Count == 0)
            {
                MessageBox.Show("List Tu nay trong");
                return;
            }
            dsTuHienTai = lstWordsRemembed;
            tuHienTai = lstWordsRemembed[0];
            currentIndexWord = 0;
            numIndexWord.Maximum = dsTuHienTai.Count() - 1;
            HienThe(currentIndexWord);
            BatTatNutChuyenThe();

        }

        private void btnTuChuaThuoc_Click(object sender, EventArgs e)
        {
            if (loaiDsChiaTu == ChiaDanhSach.AllList)
            {
                dsTuHienTai = dsTatCaCacTu;
            }
            else if (loaiDsChiaTu == ChiaDanhSach.ByDay)
            {
                dsTuHienTai = lstAllWordsByDay;
            }

            dsTuOnLai.Clear();

            foreach (Word forgetWord in dsTuHienTai)
            {
                if (forgetWord.Status == Status.forget)
                {
                    dsTuOnLai.Add(forgetWord);
                }
            }
            if (dsTuOnLai.Count == 0)
            {
                MessageBox.Show("List Tu nay trong");
                return;
            }
            dsTuHienTai = dsTuOnLai;
            tuHienTai = dsTuOnLai[0];
            currentIndexWord = 0;
            numIndexWord.Maximum = dsTuHienTai.Count() - 1;
            HienThe(currentIndexWord);
            BatTatNutChuyenThe();

        }

        private void btnAllTu_Click(object sender, EventArgs e)
        {
            dsTuHienTai = lstAllWordsByDay;
            tuHienTai = dsTuHienTai[0];
            currentIndexWord = 0;
            HienThe(currentIndexWord);
            BatTatNutChuyenThe();

        }

        private void btnAllTu_Click_1(object sender, EventArgs e)
        {
            dsTuHienTai = dsTatCaCacTu;
            if (dsTuHienTai.Count > 0)
            {
                loaiDsChiaTu = ChiaDanhSach.AllList;
                pnFlashCard.Visible = true;

                btnListTuDaThuoc.Enabled = true;
                btnTuChuaThuoc.Enabled = true;
                btnPre.Enabled = true;
                btnNext.Enabled = true;
                btnForget.Enabled = true;
                btnRemembed.Enabled = true;


                dsTuHienTai = dsTatCaCacTu;
                tuHienTai = dsTuHienTai[0];
                currentIndexWord = 0;
                numIndexWord.Maximum = dsTuHienTai.Count() - 1;
                HienThe(currentIndexWord);
                BatTatNutChuyenThe();
            }
            else
            {
                MessageBox.Show("Danh sách trống");

            }

        }

        private void cbCaiDatHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCaiDatHienThi.SelectedIndex == 0)
            {
                pnBack.Visible = false;
                pnFront.Visible = true;
            }
            else if (cbCaiDatHienThi.SelectedIndex == 1)
            {
                pnBack.Visible = true;
                pnFront.Visible = false;
            }
            else if (cbCaiDatHienThi.SelectedIndex == 2)
            {
                pnBack.Visible = true;
                pnFront.Visible = true;
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
                catch(Exception ed)
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

        private void tbnTimTheoNgay_Click(object sender, EventArgs e)
        {
            lstAllWordsByDay.Clear();
            pnFlashCard.Visible = true;
            loaiDsChiaTu = ChiaDanhSach.ByDay;

            btnListTuDaThuoc.Enabled = true;
            btnTuChuaThuoc.Enabled = true;
            btnPre.Enabled = true;
            btnNext.Enabled = true;
            btnForget.Enabled = true;
            btnRemembed.Enabled = true;


            DateTime ngayOnDuocChon = dtpkDsTuOn.SelectionStart.Date;
            lstAllWordsByDay = FileEvent.DocDanhSachTuOnTheoNgay(dsTatCaCacTu, ngayOnDuocChon);

            if (lstAllWordsByDay.Count() == 0)
            {

                pnFlashCard.Visible = false;
                MessageBox.Show("Ngày này không có lịch ôn");
                return;
            }

            MessageBox.Show(dtpkDsTuOn.SelectionStart.Date.ToString());

            try
            {
                dsTuHienTai = lstAllWordsByDay;
                HienThe(0);
            }
            catch { }
            finally
            {
                numIndexWord.Maximum = dsTuHienTai.Count() - 1;
                numIndexWord.Minimum = 0;
            }

            BatTatNutChuyenThe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstTuChuaCoLichOn = FileEvent.DocDanhSachTuChuaCoLichOn(dsTatCaCacTu);
            if (lstTuChuaCoLichOn.Count() > 0)
            {
                loaiDsChiaTu = ChiaDanhSach.LichOnTrongQuaKhu;
                pnFlashCard.Visible = true;

                btnListTuDaThuoc.Enabled = true;
                btnTuChuaThuoc.Enabled = true;
                btnPre.Enabled = true;
                btnNext.Enabled = true;
                btnForget.Enabled = true;
                btnRemembed.Enabled = true;


                dsTuHienTai = lstTuChuaCoLichOn;
                tuHienTai = dsTuHienTai[0];
                currentIndexWord = 0;
                numIndexWord.Maximum = dsTuHienTai.Count() - 1;
                HienThe(currentIndexWord);
                BatTatNutChuyenThe();
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
    }
}


