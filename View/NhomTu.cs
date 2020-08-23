﻿using CsvHelper;
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

namespace FlashCard.View
{
    public partial class NhomTu : Form
    {
        List<Word> lstAllWordsByDay = new List<Word>();
        List<Word> lstWordsRemembed = new List<Word>();
        List<Word> lstWordsRepeat = new List<Word>();
        List<Word> lstAllWords = new List<Word>();
        List<Word> lstTuChuaCoLichOn = new List<Word>();


        List<Word> lstCurrentWords = new List<Word>();
        FilterEnum filterList;

        Word currentWord = new Word();
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
                if (cbHienAmThanhTuongTu.Checked)
                {
                    lbATTT.Visible = true;
                }
                else
                {
                    lbATTT.Visible = false;
                }

                currentWord = lstCurrentWords[indexWord];
                lbTagName.Text = currentWord.tagName;
                lbPathOfSpeech.Text = currentWord.pathOfSpeech;
                lbIPA.Text = currentWord.IPA;
                lbMean.Text = currentWord.mean;
                lbExample.Text = currentWord.Example;
                lbATTT.Text = currentWord.ATTT;
                if (currentWord.Status == Status.forget)
                {
                    pnBack.BackColor = Color.FromArgb(211, 59, 2);
                    pnFront.BackColor = Color.FromArgb(211, 59, 2);
                }
                else if (currentWord.Status == Status.remember)
                {
                    pnBack.BackColor = Color.Green;
                    pnFront.BackColor = Color.Green;
                }
                if (currentWord.Status == Status.willRecall)
                {
                    pnBack.BackColor = Color.Gray;
                    pnFront.BackColor = Color.Gray;
                }
                numIndexWord.Value = indexWord;
                lbTuTongSo.Text = numIndexWord.Value + "/" + (lstCurrentWords.Count() - 1);
                dtpkSetTgOn.SetDate(currentWord.startTime);
            }
            catch
            {

            }
        }
        public void ButtonShowOrNot()
        {
            if (currentIndexWord == 0)//khoa nut quay lai
            {
                btnPre.Enabled = false;
            }
            else
            {
                btnPre.Enabled = true;
            }


            if ((lstCurrentWords.Count() - 1) == currentIndexWord)//khoa nut di tiep
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }


        }
        private void NhomTu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnListTuDaThuoc.Enabled = false;
            btnTuChuaThuoc.Enabled = false;
            btnPre.Enabled = false;
            btnNext.Enabled = false;
            btnForget.Enabled = false;
            btnRemembed.Enabled = false;

            pnFlashCard.Visible = false;


            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", this.Text + ".xlsx");


            Excel excel = new Excel(filePath, 1);
            try
            {
                if (excel.ReadCell(2, 1) != "")
                {
                    int row = 2;
                    do
                    {

                        Word word = new Word();
                        word.tagName = excel.ReadCell(row, 1);
                        word.mean = excel.ReadCell(row, 2);
                        word.startTime = DateTime.FromOADate(double.Parse(excel.ReadCell(row, 3)));
                        word.ATTT = excel.ReadCell(row, 4);
                        word.IPA = excel.ReadCell(row, 5);
                        word.pathOfSpeech = excel.ReadCell(row, 6);
                        word.Example = excel.ReadCell(row, 7);
                        word.Status = Status.willRecall;

                        lstAllWords.Add(word);
                        if (word.startTime <= DateTime.Now)
                        {
                            lstTuChuaCoLichOn.Add(word);
                        }
                        row++;
                    } while (excel.ReadCell(row, 1) != "");
                }
            }
            catch (Exception ex) { }
            finally
            {
                excel.Close();
            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            btnPre.Enabled = true;
            currentIndexWord++;
            currentWord = lstCurrentWords[currentIndexWord];
            HienThe(currentIndexWord);
            ButtonShowOrNot();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            currentWord.Status = Status.forget;
            pnBack.BackColor = Color.FromArgb(211, 59, 2);
            pnFront.BackColor = Color.FromArgb(211, 59, 2);

        }

        private void btnRemembed_Click(object sender, EventArgs e)
        {
            currentWord.Status = Status.remember;
            pnBack.BackColor = Color.Green;
            pnFront.BackColor = Color.Green;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            currentIndexWord--;
            currentWord = lstCurrentWords[currentIndexWord];
            HienThe(currentIndexWord);
            ButtonShowOrNot();
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

        private void lbPathOfSpeech_Click(object sender, EventArgs e)
        {

        }

        private void lbExample_Click(object sender, EventArgs e)
        {

        }

        private void lbMean_Click(object sender, EventArgs e)
        {

        }

        private void lbTagName_Click(object sender, EventArgs e)
        {

        }

        private void numIndexWord_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                currentIndexWord = Convert.ToInt32(numIndexWord.Value);
                currentWord = lstCurrentWords[currentIndexWord];
                HienThe(currentIndexWord);
            }
            catch
            {

            }


        }

        private void btnTuDaThuoc_Click(object sender, EventArgs e)
        {

            if (filterList == FilterEnum.AllList)
            {
                lstCurrentWords = lstAllWords;
            }
            else if (filterList == FilterEnum.ByDay)
            {
                lstCurrentWords = lstAllWordsByDay;

            }
            lstWordsRemembed.Clear();
            foreach (Word rememberWord in lstCurrentWords)
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
            lstCurrentWords = lstWordsRemembed;
            currentWord = lstWordsRemembed[0];
            currentIndexWord = 0;
            numIndexWord.Maximum = lstCurrentWords.Count() - 1;
            HienThe(currentIndexWord);
            ButtonShowOrNot();

        }

        private void btnTuChuaThuoc_Click(object sender, EventArgs e)
        {
            if (filterList == FilterEnum.AllList)
            {
                lstCurrentWords = lstAllWords;
            }
            else if (filterList == FilterEnum.ByDay)
            {
                lstCurrentWords = lstAllWordsByDay;
            }
            lstWordsRepeat.Clear();
            foreach (Word forgetWord in lstCurrentWords)
            {
                if (forgetWord.Status == Status.forget)
                {
                    lstWordsRepeat.Add(forgetWord);
                }
            }
            if (lstWordsRepeat.Count == 0)
            {
                MessageBox.Show("List Tu nay trong");
                return;
            }
            lstCurrentWords = lstWordsRepeat;
            currentWord = lstWordsRepeat[0];
            currentIndexWord = 0;
            numIndexWord.Maximum = lstCurrentWords.Count() - 1;
            HienThe(currentIndexWord);
            ButtonShowOrNot();

        }

        private void btnAllTu_Click(object sender, EventArgs e)
        {
            lstCurrentWords = lstAllWordsByDay;
            currentWord = lstCurrentWords[0];
            currentIndexWord = 0;
            HienThe(currentIndexWord);
            ButtonShowOrNot();

        }

        private void btnAllTu_Click_1(object sender, EventArgs e)
        {
            if (lstCurrentWords.Count > 0)
            {
                filterList = FilterEnum.AllList;
                pnFlashCard.Visible = true;

                btnListTuDaThuoc.Enabled = true;
                btnTuChuaThuoc.Enabled = true;
                btnPre.Enabled = true;
                btnNext.Enabled = true;
                btnForget.Enabled = true;
                btnRemembed.Enabled = true;


                lstCurrentWords = lstAllWords;
                currentWord = lstCurrentWords[0];
                currentIndexWord = 0;
                numIndexWord.Maximum = lstCurrentWords.Count() - 1;
                HienThe(currentIndexWord);
                ButtonShowOrNot();
            }
            else
            {
                MessageBox.Show("Danh sách trống");

            }

        }

        private void btnHien2Mat_Click(object sender, EventArgs e)
        {

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
            filterList = FilterEnum.ByDay;

            btnListTuDaThuoc.Enabled = true;
            btnTuChuaThuoc.Enabled = true;
            btnPre.Enabled = true;
            btnNext.Enabled = true;
            btnForget.Enabled = true;
            btnRemembed.Enabled = true;

            foreach (Word w in lstAllWords)
            {
                w.Status = Status.willRecall;

                DateTime dateTimePicked = dtpkDsTuOn.SelectionStart.Date;
                if (dateTimePicked == w.startTime)
                {
                    lstAllWordsByDay.Add(w);
                }
            }


            if (lstAllWordsByDay.Count() == 0)
            {

                pnFlashCard.Visible = false;
                MessageBox.Show("Ngày này không có lịch ôn");
                return;
            }

            MessageBox.Show(dtpkDsTuOn.SelectionStart.Date.ToString());

            try
            {
                lstCurrentWords = lstAllWordsByDay;
                HienThe(0);
            }
            catch { }
            finally
            {
                numIndexWord.Maximum = lstCurrentWords.Count() - 1;
                numIndexWord.Minimum = 0;
            }

            ButtonShowOrNot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstTuChuaCoLichOn.Count() > 0)
            {
                filterList = FilterEnum.LichOnTrongQuaKhu;
                pnFlashCard.Visible = true;

                btnListTuDaThuoc.Enabled = true;
                btnTuChuaThuoc.Enabled = true;
                btnPre.Enabled = true;
                btnNext.Enabled = true;
                btnForget.Enabled = true;
                btnRemembed.Enabled = true;


                lstCurrentWords = lstTuChuaCoLichOn;
                currentWord = lstCurrentWords[0];
                currentIndexWord = 0;
                numIndexWord.Maximum = lstCurrentWords.Count() - 1;
                HienThe(currentIndexWord);
                ButtonShowOrNot();
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
            currentWord.startTime = dtpkSetTgOn.SelectionRange.Start;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileEvent.LuuFileTuVung(this.Text, lstAllWords);
                MessageBox.Show("Lưu thành công!!");
            }
            catch
            {
                MessageBox.Show("Lỗi khi lưu");
            }

        }
    }
}


