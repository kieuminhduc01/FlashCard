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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnBack = new System.Windows.Forms.Panel();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbPathOfSpeech = new System.Windows.Forms.Label();
            this.lbIPA = new System.Windows.Forms.Label();
            this.btnForget = new System.Windows.Forms.Button();
            this.btnRemembed = new System.Windows.Forms.Button();
            this.pnFront = new System.Windows.Forms.Panel();
            this.lbTagName = new System.Windows.Forms.Label();
            this.lbExample = new System.Windows.Forms.Label();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numIndexWord = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numDaysRecall = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTuChuaThuoc = new System.Windows.Forms.Button();
            this.btnListTuDaThuoc = new System.Windows.Forms.Button();
            this.btnAllTu = new System.Windows.Forms.Button();
            this.cbCaiDatHienThi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnFlashCard = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnBack.SuspendLayout();
            this.pnFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysRecall)).BeginInit();
            this.pnFlashCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnBack);
            this.panel2.Controls.Add(this.btnForget);
            this.panel2.Controls.Add(this.btnRemembed);
            this.panel2.Controls.Add(this.pnFront);
            this.panel2.Location = new System.Drawing.Point(8, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 471);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnBack
            // 
            this.pnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBack.Controls.Add(this.lbMean);
            this.pnBack.Controls.Add(this.lbPathOfSpeech);
            this.pnBack.Controls.Add(this.lbIPA);
            this.pnBack.Location = new System.Drawing.Point(11, 254);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(479, 200);
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
            // btnForget
            // 
            this.btnForget.Location = new System.Drawing.Point(11, 6);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(105, 23);
            this.btnForget.TabIndex = 5;
            this.btnForget.Text = "Ôn Lại Luôn";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // btnRemembed
            // 
            this.btnRemembed.Location = new System.Drawing.Point(385, 6);
            this.btnRemembed.Name = "btnRemembed";
            this.btnRemembed.Size = new System.Drawing.Size(105, 23);
            this.btnRemembed.TabIndex = 5;
            this.btnRemembed.Text = "thuoc roi";
            this.btnRemembed.UseVisualStyleBackColor = true;
            this.btnRemembed.Click += new System.EventHandler(this.btnRemembed_Click);
            // 
            // pnFront
            // 
            this.pnFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFront.Controls.Add(this.lbTagName);
            this.pnFront.Controls.Add(this.lbExample);
            this.pnFront.Location = new System.Drawing.Point(11, 35);
            this.pnFront.Name = "pnFront";
            this.pnFront.Size = new System.Drawing.Size(479, 200);
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
            this.lbExample.Location = new System.Drawing.Point(28, 52);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(428, 133);
            this.lbExample.TabIndex = 1;
            this.lbExample.Text = "Example";
            this.lbExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExample.Click += new System.EventHandler(this.lbExample_Click);
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(212, 551);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(105, 23);
            this.btnFlip.TabIndex = 6;
            this.btnFlip.Text = "Quay";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(436, 551);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(8, 551);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 3;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // numIndexWord
            // 
            this.numIndexWord.Location = new System.Drawing.Point(157, 483);
            this.numIndexWord.Name = "numIndexWord";
            this.numIndexWord.Size = new System.Drawing.Size(123, 22);
            this.numIndexWord.TabIndex = 9;
            this.numIndexWord.ValueChanged += new System.EventHandler(this.numIndexWord_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ số";
            // 
            // numDaysRecall
            // 
            this.numDaysRecall.Location = new System.Drawing.Point(157, 526);
            this.numDaysRecall.Name = "numDaysRecall";
            this.numDaysRecall.Size = new System.Drawing.Size(123, 22);
            this.numDaysRecall.TabIndex = 9;
            this.numDaysRecall.ValueChanged += new System.EventHandler(this.numDaysRecall_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số ngày ôn lại";
            // 
            // btnTuChuaThuoc
            // 
            this.btnTuChuaThuoc.Location = new System.Drawing.Point(352, 10);
            this.btnTuChuaThuoc.Name = "btnTuChuaThuoc";
            this.btnTuChuaThuoc.Size = new System.Drawing.Size(146, 30);
            this.btnTuChuaThuoc.TabIndex = 11;
            this.btnTuChuaThuoc.Text = "List Tu Chua Thuoc";
            this.btnTuChuaThuoc.UseVisualStyleBackColor = true;
            this.btnTuChuaThuoc.Click += new System.EventHandler(this.btnTuChuaThuoc_Click);
            // 
            // btnListTuDaThuoc
            // 
            this.btnListTuDaThuoc.Location = new System.Drawing.Point(19, 3);
            this.btnListTuDaThuoc.Name = "btnListTuDaThuoc";
            this.btnListTuDaThuoc.Size = new System.Drawing.Size(146, 30);
            this.btnListTuDaThuoc.TabIndex = 12;
            this.btnListTuDaThuoc.Text = "List Tu Da Thuoc";
            this.btnListTuDaThuoc.UseVisualStyleBackColor = true;
            this.btnListTuDaThuoc.Click += new System.EventHandler(this.btnTuDaThuoc_Click);
            // 
            // btnAllTu
            // 
            this.btnAllTu.Location = new System.Drawing.Point(76, 289);
            this.btnAllTu.Name = "btnAllTu";
            this.btnAllTu.Size = new System.Drawing.Size(146, 30);
            this.btnAllTu.TabIndex = 12;
            this.btnAllTu.Text = "All Tu";
            this.btnAllTu.UseVisualStyleBackColor = true;
            this.btnAllTu.Click += new System.EventHandler(this.btnAllTu_Click_1);
            // 
            // cbCaiDatHienThi
            // 
            this.cbCaiDatHienThi.FormattingEnabled = true;
            this.cbCaiDatHienThi.Items.AddRange(new object[] {
            "Mặt trước",
            "Mặt sau",
            "2 mặt"});
            this.cbCaiDatHienThi.Location = new System.Drawing.Point(158, 555);
            this.cbCaiDatHienThi.Name = "cbCaiDatHienThi";
            this.cbCaiDatHienThi.Size = new System.Drawing.Size(121, 24);
            this.cbCaiDatHienThi.TabIndex = 14;
            this.cbCaiDatHienThi.SelectedIndexChanged += new System.EventHandler(this.cbCaiDatHienThi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cài đặt hiển thị";
            // 
            // pnFlashCard
            // 
            this.pnFlashCard.Controls.Add(this.btnNext);
            this.pnFlashCard.Controls.Add(this.panel2);
            this.pnFlashCard.Controls.Add(this.btnPre);
            this.pnFlashCard.Controls.Add(this.btnFlip);
            this.pnFlashCard.Controls.Add(this.btnTuChuaThuoc);
            this.pnFlashCard.Controls.Add(this.btnListTuDaThuoc);
            this.pnFlashCard.Location = new System.Drawing.Point(313, 24);
            this.pnFlashCard.Name = "pnFlashCard";
            this.pnFlashCard.Size = new System.Drawing.Size(520, 588);
            this.pnFlashCard.TabIndex = 16;
            // 
            // NhomTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 626);
            this.Controls.Add(this.pnFlashCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCaiDatHienThi);
            this.Controls.Add(this.btnAllTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDaysRecall);
            this.Controls.Add(this.numIndexWord);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "NhomTu";
            this.Text = "NhomTu";
            this.Load += new System.EventHandler(this.NhomTu_Load);
            this.panel2.ResumeLayout(false);
            this.pnBack.ResumeLayout(false);
            this.pnFront.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numIndexWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysRecall)).EndInit();
            this.pnFlashCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTagName;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
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
        private System.Windows.Forms.NumericUpDown numDaysRecall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTuChuaThuoc;
        private System.Windows.Forms.Button btnListTuDaThuoc;
        private System.Windows.Forms.Button btnAllTu;
        private System.Windows.Forms.ComboBox cbCaiDatHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnFlashCard;
    }
}