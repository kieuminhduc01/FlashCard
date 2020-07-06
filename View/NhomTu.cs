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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}


