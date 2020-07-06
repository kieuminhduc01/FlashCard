namespace FlashCard.View
{
    partial class NhomTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnBack = new System.Windows.Forms.Panel();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbPathOfSpeech = new System.Windows.Forms.Label();
            this.lbIPA = new System.Windows.Forms.Label();
            this.pnFront = new System.Windows.Forms.Panel();
            this.lbTagName = new System.Windows.Forms.Label();
            this.lbExample = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnForget = new System.Windows.Forms.Button();
            this.btnRemembed = new System.Windows.Forms.Button();
            this.btnFlip = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numIndexWord = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnBack.SuspendLayout();
            this.pnFront.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexWord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 116);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnBack);
            this.panel2.Controls.Add(this.pnFront);
            this.panel2.Location = new System.Drawing.Point(180, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 461);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnBack
            // 
            this.pnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBack.Controls.Add(this.lbMean);
            this.pnBack.Controls.Add(this.lbPathOfSpeech);
            this.pnBack.Controls.Add(this.lbIPA);
            this.pnBack.Location = new System.Drawing.Point(3, 281);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(479, 177);
            this.pnBack.TabIndex = 4;
            // 
            // lbMean
            // 
            this.lbMean.Location = new System.Drawing.Point(124, 111);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(240, 32);
            this.lbMean.TabIndex = 2;
            this.lbMean.Text = "Mean";
            this.lbMean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMean.Click += new System.EventHandler(this.lbMean_Click);
            // 
            // lbPathOfSpeech
            // 
            this.lbPathOfSpeech.Location = new System.Drawing.Point(124, 13);
            this.lbPathOfSpeech.Name = "lbPathOfSpeech";
            this.lbPathOfSpeech.Size = new System.Drawing.Size(240, 32);
            this.lbPathOfSpeech.TabIndex = 0;
            this.lbPathOfSpeech.Text = "PathOfSpeech";
            this.lbPathOfSpeech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPathOfSpeech.Click += new System.EventHandler(this.lbPathOfSpeech_Click);
            // 
            // lbIPA
            // 
            this.lbIPA.Location = new System.Drawing.Point(124, 62);
            this.lbIPA.Name = "lbIPA";
            this.lbIPA.Size = new System.Drawing.Size(240, 32);
            this.lbIPA.TabIndex = 1;
            this.lbIPA.Text = "IPA";
            this.lbIPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIPA.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnFront
            // 
            this.pnFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFront.Controls.Add(this.lbTagName);
            this.pnFront.Controls.Add(this.lbExample);
            this.pnFront.Location = new System.Drawing.Point(3, 6);
            this.pnFront.Name = "pnFront";
            this.pnFront.Size = new System.Drawing.Size(479, 269);
            this.pnFront.TabIndex = 3;
            // 
            // lbTagName
            // 
            this.lbTagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTagName.Location = new System.Drawing.Point(67, 18);
            this.lbTagName.Name = "lbTagName";
            this.lbTagName.Size = new System.Drawing.Size(342, 34);
            this.lbTagName.TabIndex = 0;
            this.lbTagName.Text = "TagName";
            this.lbTagName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTagName.Click += new System.EventHandler(this.lbTagName_Click);
            // 
            // lbExample
            // 
            this.lbExample.Location = new System.Drawing.Point(22, 62);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(428, 178);
            this.lbExample.TabIndex = 1;
            this.lbExample.Text = "Example";
            this.lbExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExample.Click += new System.EventHandler(this.lbExample_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb30);
            this.groupBox1.Controls.Add(this.rb15);
            this.groupBox1.Controls.Add(this.rb10);
            this.groupBox1.Controls.Add(this.rb7);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 516);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch Ôn";
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Location = new System.Drawing.Point(24, 446);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(79, 21);
            this.rb30.TabIndex = 7;
            this.rb30.TabStop = true;
            this.rb30.Text = "30 days";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.rb30_CheckedChanged);
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(24, 393);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(79, 21);
            this.rb15.TabIndex = 6;
            this.rb15.TabStop = true;
            this.rb15.Text = "15 days";
            this.rb15.UseVisualStyleBackColor = true;
            this.rb15.CheckedChanged += new System.EventHandler(this.rb15_CheckedChanged);
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(24, 340);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(79, 21);
            this.rb10.TabIndex = 5;
            this.rb10.TabStop = true;
            this.rb10.Text = "10 days";
            this.rb10.UseVisualStyleBackColor = true;
            this.rb10.CheckedChanged += new System.EventHandler(this.rb10_CheckedChanged);
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(24, 287);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(71, 21);
            this.rb7.TabIndex = 4;
            this.rb7.TabStop = true;
            this.rb7.Text = "7 days";
            this.rb7.UseVisualStyleBackColor = true;
            this.rb7.CheckedChanged += new System.EventHandler(this.rb7_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(24, 234);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(71, 21);
            this.rb5.TabIndex = 3;
            this.rb5.TabStop = true;
            this.rb5.Text = "5 days";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.rb5_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(24, 181);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(71, 21);
            this.rb4.TabIndex = 2;
            this.rb4.TabStop = true;
            this.rb4.Text = "4 days";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(24, 128);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(71, 21);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "2 days";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(24, 75);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(71, 21);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 days";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(180, 479);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 3;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(598, 479);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnForget
            // 
            this.btnForget.Location = new System.Drawing.Point(270, 479);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(105, 23);
            this.btnForget.TabIndex = 5;
            this.btnForget.Text = "Ôn Lại Luôn";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // btnRemembed
            // 
            this.btnRemembed.Location = new System.Drawing.Point(487, 479);
            this.btnRemembed.Name = "btnRemembed";
            this.btnRemembed.Size = new System.Drawing.Size(105, 23);
            this.btnRemembed.TabIndex = 5;
            this.btnRemembed.Text = "thuoc roi";
            this.btnRemembed.UseVisualStyleBackColor = true;
            this.btnRemembed.Click += new System.EventHandler(this.btnRemembed_Click);
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(381, 479);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(105, 23);
            this.btnFlip.TabIndex = 6;
            this.btnFlip.Text = "Quay";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(697, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // numIndexWord
            // 
            this.numIndexWord.Location = new System.Drawing.Point(829, 239);
            this.numIndexWord.Name = "numIndexWord";
            this.numIndexWord.Size = new System.Drawing.Size(123, 22);
            this.numIndexWord.TabIndex = 9;
            this.numIndexWord.ValueChanged += new System.EventHandler(this.numIndexWord_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ số";
            // 
            // NhomTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numIndexWord);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.btnRemembed);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NhomTu";
            this.Text = "NhomTu";
            this.Load += new System.EventHandler(this.NhomTu_Load);
            this.panel2.ResumeLayout(false);
            this.pnBack.ResumeLayout(false);
            this.pnFront.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTagName;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.Button btnRemembed;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label lbIPA;
        private System.Windows.Forms.Label lbPathOfSpeech;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel pnFront;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.NumericUpDown numIndexWord;
        private System.Windows.Forms.Label label1;
    }
}