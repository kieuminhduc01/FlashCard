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
        Filter filterList;

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
                if (currentWord.Status == Status.forget)
                {
                    pnBack.BackColor = Color.Yellow;
                    pnFront.BackColor = Color.Yellow;
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
            btnListTuDaThuoc.Enabled = false;
            btnTuChuaThuoc.Enabled = false;
            btnPre.Enabled = false;
            btnNext.Enabled = false;
            btnFlip.Enabled = false;
            btnForget.Enabled = false;
            btnRemembed.Enabled = false;

            pnFlashCard.Visible = false;

            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", this.Text + ".csv");
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');

                Word word = new Word();
                word.tagName = words[0];
                word.mean = words[1];
                word.startTime = Convert.ToDateTime(words[2]);
                word.Step = Convert.ToInt32(words[3]);
                word.ATTT = words[4];
                word.IPA = words[5];
                word.pathOfSpeech = words[6];
                word.Example = words[7];
                word.Status = Status.willRecall;

                int time = DateTime.Now.Day - word.startTime.Day;
                if (time % word.Step == 0)
                {
                    lstWords0.Add(word);
                }
                else if (time % word.Step == 1)
                {
                    lstWords1.Add(word);
                }
                else if (time % word.Step == 2)
                {
                    lstWords2.Add(word);
                }
                else if (time % word.Step == 3)
                {
                    lstWords3.Add(word);
                }
                else if (time % word.Step == 4)
                {
                    lstWords4.Add(word);
                }
                else if (time % word.Step == 5)
                {
                    lstWords5.Add(word);
                }
                else if (time % word.Step == 6)
                {
                    lstWords6.Add(word);
                }
                else if (time % word.Step == 7)
                {
                    lstWords7.Add(word);
                }


                lstAllWords.Add(word);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            pnFlashCard.Visible = true;
            filterList = Filter.ByDay;

            btnListTuDaThuoc.Enabled = true;
            btnTuChuaThuoc.Enabled = true;
            btnPre.Enabled = true;
            btnNext.Enabled = true;
            btnFlip.Enabled = true;
            btnForget.Enabled = true;
            btnRemembed.Enabled = true;

            MessageBox.Show(monthCalendar1.SelectionStart.Date.ToString());
            DateTime dateTimePicked = monthCalendar1.SelectionStart.Date;
            int time = dateTimePicked.Day - DateTime.Now.Day;
            if (time == 0)
            {
                lstAllWordsByDay = lstWords0;
            }
            else if (time == 1)
            {
                lstAllWordsByDay = lstWords1;
            }
            else if (time == 2)
            {
                lstAllWordsByDay = lstWords2;
            }
            else if (time == 3)
            {
                lstAllWordsByDay = lstWords3;
            }
            else if (time == 4)
            {
                lstAllWordsByDay = lstWords4;
            }
            else if (time == 5)
            {
                lstAllWordsByDay = lstWords5;
            }
            else if (time == 6)
            {
                lstAllWordsByDay = lstWords6;
            }
            else if (time == 7)
            {
                lstAllWordsByDay = lstWords7;
            }
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
            pnBack.BackColor = Color.Yellow;
            pnFront.BackColor = Color.Yellow;

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
            }
            catch
            {

            }

        }

        private void btnTuDaThuoc_Click(object sender, EventArgs e)
        {
           
            if (filterList == Filter.AllList)
            {
                lstCurrentWords = lstAllWords;
            }
            else if (filterList == Filter.ByDay)
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
            if (filterList == Filter.AllList)
            {
                lstCurrentWords = lstAllWords;
            }
            else if (filterList == Filter.ByDay)
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
            filterList = Filter.AllList;
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
    }
}


