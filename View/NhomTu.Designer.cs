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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbIPA = new System.Windows.Forms.Label();
            this.lbExample = new System.Windows.Forms.Label();
            this.lbPathOfSpeech = new System.Windows.Forms.Label();
            this.lbTagName = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 116);
            this.panel1.TabIndex = 0;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 12);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(661, 22);
            this.hScrollBar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMean);
            this.panel2.Controls.Add(this.lbIPA);
            this.panel2.Controls.Add(this.lbExample);
            this.panel2.Controls.Add(this.lbPathOfSpeech);
            this.panel2.Controls.Add(this.lbTagName);
            this.panel2.Location = new System.Drawing.Point(180, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 461);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbMean
            // 
            this.lbMean.Location = new System.Drawing.Point(82, 218);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(93, 20);
            this.lbMean.TabIndex = 2;
            this.lbMean.Text = "Mean";
            // 
            // lbIPA
            // 
            this.lbIPA.Location = new System.Drawing.Point(82, 169);
            this.lbIPA.Name = "lbIPA";
            this.lbIPA.Size = new System.Drawing.Size(93, 20);
            this.lbIPA.TabIndex = 1;
            this.lbIPA.Text = "IPA";
            this.lbIPA.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbExample
            // 
            this.lbExample.Location = new System.Drawing.Point(22, 336);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(454, 107);
            this.lbExample.TabIndex = 1;
            this.lbExample.Text = "Example";
            // 
            // lbPathOfSpeech
            // 
            this.lbPathOfSpeech.Location = new System.Drawing.Point(82, 120);
            this.lbPathOfSpeech.Name = "lbPathOfSpeech";
            this.lbPathOfSpeech.Size = new System.Drawing.Size(113, 26);
            this.lbPathOfSpeech.TabIndex = 0;
            this.lbPathOfSpeech.Text = "PathOfSpeech";
            // 
            // lbTagName
            // 
            this.lbTagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTagName.Location = new System.Drawing.Point(85, 67);
            this.lbTagName.Name = "lbTagName";
            this.lbTagName.Size = new System.Drawing.Size(342, 34);
            this.lbTagName.TabIndex = 0;
            this.lbTagName.Text = "TagName";
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
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
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
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1090, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // NhomTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 644);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
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
    }
}