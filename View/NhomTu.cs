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

namespace FlashCard.View
{
    public partial class NhomTu : Form
    {
        List<Word> lstAllWordsByDay = new List<Word>();
        List<Word> lstWordsRemembed = new List<Word>();
        List<Word> lstWordsRepeat = new List<Word>();
        List<Word> lstAllWords = new List<Word>();

        List<Word> lstWords0 = new List<Word>();
        List<Word> lstWords1 = new List<Word>();
        List<Word> lstWords2 = new List<Word>();
        List<Word> lstWords3 = new List<Word>();
        List<Word> lstWords4 = new List<Word>();
        List<Word> lstWords5 = new List<Word>();
        List<Word> lstWords6 = new List<Word>();
        List<Word> lstWords7 = new List<Word>();

        List<Word> lstCurrentWords = new List<Word>();
        FilterEnum filterList;

        Word currentWord = new Word();
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

                currentWord = lstCurrentWords[indexWord];
                lbTagName.Text = currentWord.tagName;
                lbPathOfSpeech.Text = currentWord.pathOfSpeech;
                lbIPA.Text = currentWord.IPA;
                lbMean.Text = currentWord.mean;
                lbExample.Text = currentWord.Example;
                lbATTT.Text = currentWord.ATTT;
                currentWord.startTime = DateTime.Now;
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
                numDaysRecall.Value = lstCurrentWords[currentIndexWord].Step;
                lbTuTongSo.Text = numIndexWord.Value + "/" + (lstCurrentWords.Count() - 1);
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
            btnFlip.Enabled = false;
            btnForget.Enabled = false;
            btnRemembed.Enabled = false;

            pnFlashCard.Visible = false;


            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", this.Text + ".xlsx");

            System.Data.DataTable dtTable;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    dtTable = result.Tables[0];

                    foreach (DataRow dr in dtTable.Rows)
                    {

                        Word word = new Word();
                        word.tagName = dr[0].ToString();
                        word.mean = dr[1].ToString();
                        word.startTime = Convert.ToDateTime(dr[2].ToString());
                        word.Step = Convert.ToInt32(dr[3].ToString());
                        word.ATTT = dr[4].ToString();
                        word.IPA = dr[5].ToString();
                        word.pathOfSpeech = dr[6].ToString();
                        word.Example = dr[7].ToString();
                        word.Status = Status.willRecall;

                        lstAllWords.Add(word);
                    }
                }
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
            numDaysRecall.Value = currentWord.Step;

            try
            {
                currentWord.Step = Convert.ToInt32(numDaysRecall.Value);
            }
            catch
            {

            }
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
            numDaysRecall.Value = currentWord.Step;

            try
            {
                currentWord.Step = Convert.ToInt32(numDaysRecall.Value);
            }
            catch
            {

            }
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
                numDaysRecall.Value = currentWord.Step;
            }
            catch
            {

            }


        }

        private void numDaysRecall_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                currentWord.Step = Convert.ToInt32(numDaysRecall.Value);
                currentWord.startTime = DateTime.Now;
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
            filterList = FilterEnum.AllList;
            pnFlashCard.Visible = true;

            btnListTuDaThuoc.Enabled = true;
            btnTuChuaThuoc.Enabled = true;
            btnPre.Enabled = true;
            btnNext.Enabled = true;
            btnFlip.Enabled = true;
            btnForget.Enabled = true;
            btnRemembed.Enabled = true;


            lstCurrentWords = lstAllWords;
            currentWord = lstCurrentWords[0];
            currentIndexWord = 0;
            numIndexWord.Maximum = lstCurrentWords.Count() - 1;
            HienThe(currentIndexWord);
            ButtonShowOrNot();
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
            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", this.Text + ".xlsx");

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)app.ActiveSheet;
            app.Visible = false;
            ws.Cells[1, 1] = "tagName";
            ws.Cells[1, 2] = "mean";
            ws.Cells[1, 3] = "StartTime";
            ws.Cells[1, 4] = "Step";
            ws.Cells[1, 5] = "ATTT";
            ws.Cells[1, 6] = "IPA";
            ws.Cells[1, 7] = "pathOfSpeech";
            ws.Cells[1, 8] = "Example";
            int i = 2;
            foreach (Word item in lstAllWords)
            {
                ws.Cells[i, 1] = item.tagName;
                ws.Cells[i, 2] = item.mean;
                ws.Cells[i, 3] = item.startTime;
                ws.Cells[i, 4] = item.Step;
                ws.Cells[i, 5] = item.ATTT;
                ws.Cells[i, 6] = item.IPA;
                ws.Cells[i, 7] = item.pathOfSpeech;
                ws.Cells[i, 8] = item.Example;
                i++;
            }
            try
            {
                wb.SaveAs(filePath, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            }
            catch { }
            finally
            {
                wb.Close();
                app.Quit();
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
            btnFlip.Enabled = true;
            btnForget.Enabled = true;
            btnRemembed.Enabled = true;
            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", this.Text + ".xlsx");


            foreach (Word w in lstAllWords)
            {
                w.Status = Status.willRecall;

                DateTime dateTimePicked = monthCalendar1.SelectionStart.Date;
                int timeStep = dateTimePicked.Day - w.startTime.Day;
                if (timeStep % w.Step == 0)
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

            MessageBox.Show(monthCalendar1.SelectionStart.Date.ToString());

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
    }
}


