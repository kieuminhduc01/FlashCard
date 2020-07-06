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
        List<Word> lstWordsRoot = new List<Word>();
        List<Word> lstWordsRemembed = new List<Word>();
        List<Word> lstWordsRepeat = new List<Word>();

        List<Word> lstWords0 = new List<Word>();
        List<Word> lstWords1 = new List<Word>();
        List<Word> lstWords2 = new List<Word>();
        List<Word> lstWords3 = new List<Word>();
        List<Word> lstWords4 = new List<Word>();
        List<Word> lstWords5 = new List<Word>();
        List<Word> lstWords6 = new List<Word>();
        List<Word> lstWords7 = new List<Word>();

        List<Word> lstCurrentWords = new List<Word>();

        Word currentWord = new Word();
        int currentIndexWord = 0;
        int side = 0;//0 is front,1 is back,2 is both of them

        public NhomTu()
        {
            InitializeComponent();
        }
        private void HienThe(Word momentWord)
        {
            try
            {
                currentWord = momentWord;
                lbTagName.Text = currentWord.tagName;
                lbPathOfSpeech.Text = currentWord.pathOfSpeech;
                lbIPA.Text = currentWord.IPA;
                lbMean.Text = currentWord.mean;
                lbExample.Text = currentWord.Example;
                btnPre.Enabled = false;
            }
            catch
            {

            }
        }
        private void NhomTu_Load(object sender, EventArgs e)
        {
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

                lstWordsRoot.Add(word);
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

            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.Date.ToString());
            DateTime dateTimePicked = monthCalendar1.SelectionStart.Date;
            int time = dateTimePicked.Day - DateTime.Now.Day;
            if (time == 0)
            {
                lstCurrentWords = lstWords0;
            }
            else if (time == 1)
            {
                lstCurrentWords = lstWords1;
            }
            else if (time == 2)
            {
                lstCurrentWords = lstWords2;
            }
            else if (time == 3)
            {
                lstCurrentWords = lstWords3;
            }
            else if (time == 4)
            {
                lstCurrentWords = lstWords4;
            }
            else if (time == 5)
            {
                lstCurrentWords = lstWords5;
            }
            else if (time == 6)
            {
                lstCurrentWords = lstWords6;
            }
            else if (time == 7)
            {
                lstCurrentWords = lstWords7;
            }
            try
            {
                HienThe(lstCurrentWords[0]);
            }
            catch { }
            finally
            {
                numIndexWord.Maximum = lstCurrentWords.Count() - 1;
                numIndexWord.Minimum = 0;
            }
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
            HienThe(lstCurrentWords[currentIndexWord]);
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            currentWord.Status = Status.forget;
        }

        private void btnRemembed_Click(object sender, EventArgs e)
        {
            currentWord.Status = Status.remember;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            currentIndexWord--;
            currentWord = lstCurrentWords[currentIndexWord];
            HienThe(lstCurrentWords[currentIndexWord]);
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 1;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 2;
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 4;
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 5;
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 7;
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 10;
        }

        private void rb15_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 15;
        }

        private void rb30_CheckedChanged(object sender, EventArgs e)
        {
            currentWord.Step = 15;
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
                HienThe(lstCurrentWords[currentIndexWord]);
            }
            catch
            {

            }


        }
    }
}


