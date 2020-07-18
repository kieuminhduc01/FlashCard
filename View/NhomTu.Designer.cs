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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomTu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTuTongSo = new System.Windows.Forms.Label();
            this.pnBack = new System.Windows.Forms.Panel();
            this.lbATTT = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.lbTuTongSo);
            this.panel2.Controls.Add(this.pnBack);
            this.panel2.Controls.Add(this.btnForget);
            this.panel2.Controls.Add(this.btnRemembed);
            this.panel2.Controls.Add(this.pnFront);
            this.panel2.Location = new System.Drawing.Point(9, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 609);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbTuTongSo
            // 
            this.lbTuTongSo.AutoSize = true;
            this.lbTuTongSo.Location = new System.Drawing.Point(257, 25);
            this.lbTuTongSo.Name = "lbTuTongSo";
            this.lbTuTongSo.Size = new System.Drawing.Size(88, 17);
            this.lbTuTongSo.TabIndex = 6;
            this.lbTuTongSo.Text = "Tu/TongSo";
            // 
            // pnBack
            // 
            this.pnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBack.Controls.Add(this.lbATTT);
            this.pnBack.Controls.Add(this.lbMean);
            this.pnBack.Controls.Add(this.lbPathOfSpeech);
            this.pnBack.Controls.Add(this.lbIPA);
            this.pnBack.Location = new System.Drawing.Point(12, 329);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(539, 266);
            this.pnBack.TabIndex = 4;
            // 
            // lbATTT
            // 
            this.lbATTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbATTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbATTT.Location = new System.Drawing.Point(36, 151);
            this.lbATTT.Name = "lbATTT";
            this.lbATTT.Size = new System.Drawing.Size(478, 87);
            this.lbATTT.TabIndex = 3;
            this.lbATTT.Text = "Mean";
            this.lbATTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMean
            // 
            this.lbMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMean.Location = new System.Drawing.Point(150, 104);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(270, 32);
            this.lbMean.TabIndex = 2;
            this.lbMean.Text = "Mean";
            this.lbMean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMean.Click += new System.EventHandler(this.lbMean_Click);
            // 
            // lbPathOfSpeech
            // 
            this.lbPathOfSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPathOfSpeech.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPathOfSpeech.Location = new System.Drawing.Point(150, 4);
            this.lbPathOfSpeech.Name = "lbPathOfSpeech";
            this.lbPathOfSpeech.Size = new System.Drawing.Size(270, 32);
            this.lbPathOfSpeech.TabIndex = 0;
            this.lbPathOfSpeech.Text = "PathOfSpeech";
            this.lbPathOfSpeech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPathOfSpeech.Click += new System.EventHandler(this.lbPathOfSpeech_Click);
            // 
            // lbIPA
            // 
            this.lbIPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIPA.Location = new System.Drawing.Point(150, 54);
            this.lbIPA.Name = "lbIPA";
            this.lbIPA.Size = new System.Drawing.Size(270, 32);
            this.lbIPA.TabIndex = 1;
            this.lbIPA.Text = "IPA";
            this.lbIPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIPA.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.SystemColors.Control;
            this.btnForget.FlatAppearance.BorderSize = 0;
            this.btnForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForget.Image = ((System.Drawing.Image)(resources.GetObject("btnForget.Image")));
            this.btnForget.Location = new System.Drawing.Point(495, 16);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(48, 35);
            this.btnForget.TabIndex = 5;
            this.btnForget.UseVisualStyleBackColor = false;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // btnRemembed
            // 
            this.btnRemembed.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemembed.FlatAppearance.BorderSize = 0;
            this.btnRemembed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemembed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemembed.Image = ((System.Drawing.Image)(resources.GetObject("btnRemembed.Image")));
            this.btnRemembed.Location = new System.Drawing.Point(12, 16);
            this.btnRemembed.Name = "btnRemembed";
            this.btnRemembed.Size = new System.Drawing.Size(48, 35);
            this.btnRemembed.TabIndex = 5;
            this.btnRemembed.UseVisualStyleBackColor = false;
            this.btnRemembed.Click += new System.EventHandler(this.btnRemembed_Click);
            // 
            // pnFront
            // 
            this.pnFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFront.Controls.Add(this.lbTagName);
            this.pnFront.Controls.Add(this.lbExample);
            this.pnFront.Location = new System.Drawing.Point(12, 57);
            this.pnFront.Name = "pnFront";
            this.pnFront.Size = new System.Drawing.Size(539, 266);
            this.pnFront.TabIndex = 3;
            // 
            // lbTagName
            // 
            this.lbTagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTagName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTagName.Location = new System.Drawing.Point(80, 18);
            this.lbTagName.Name = "lbTagName";
            this.lbTagName.Size = new System.Drawing.Size(385, 34);
            this.lbTagName.TabIndex = 0;
            this.lbTagName.Text = "TagName";
            this.lbTagName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTagName.Click += new System.EventHandler(this.lbTagName_Click);
            // 
            // lbExample
            // 
            this.lbExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExample.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbExample.Location = new System.Drawing.Point(32, 52);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(482, 133);
            this.lbExample.TabIndex = 1;
            this.lbExample.Text = "Example";
            this.lbExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExample.Click += new System.EventHandler(this.lbExample_Click);
            // 
            // btnFlip
            // 
            this.btnFlip.BackColor = System.Drawing.SystemColors.Control;
            this.btnFlip.FlatAppearance.BorderSize = 0;
            this.btnFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFlip.Image = ((System.Drawing.Image)(resources.GetObject("btnFlip.Image")));
            this.btnFlip.Location = new System.Drawing.Point(269, 668);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(50, 42);
            this.btnFlip.TabIndex = 6;
            this.btnFlip.UseVisualStyleBackColor = false;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(469, 668);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 42);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPre.Location = new System.Drawing.Point(9, 668);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(106, 42);
            this.btnPre.TabIndex = 3;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 34);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // numIndexWord
            // 
            this.numIndexWord.Location = new System.Drawing.Point(173, 492);
            this.numIndexWord.Name = "numIndexWord";
            this.numIndexWord.Size = new System.Drawing.Size(138, 22);
            this.numIndexWord.TabIndex = 9;
            this.numIndexWord.ValueChanged += new System.EventHandler(this.numIndexWord_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(17, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ thứ";
            // 
            // numDaysRecall
            // 
            this.numDaysRecall.Location = new System.Drawing.Point(173, 529);
            this.numDaysRecall.Name = "numDaysRecall";
            this.numDaysRecall.Size = new System.Drawing.Size(138, 22);
            this.numDaysRecall.TabIndex = 9;
            this.numDaysRecall.ValueChanged += new System.EventHandler(this.numDaysRecall_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(17, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày ôn lại";
            // 
            // btnTuChuaThuoc
            // 
            this.btnTuChuaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnTuChuaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuChuaThuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTuChuaThuoc.Location = new System.Drawing.Point(406, 3);
            this.btnTuChuaThuoc.Name = "btnTuChuaThuoc";
            this.btnTuChuaThuoc.Size = new System.Drawing.Size(174, 44);
            this.btnTuChuaThuoc.TabIndex = 11;
            this.btnTuChuaThuoc.Text = "Các từ học lại";
            this.btnTuChuaThuoc.UseVisualStyleBackColor = false;
            this.btnTuChuaThuoc.Click += new System.EventHandler(this.btnTuChuaThuoc_Click);
            // 
            // btnListTuDaThuoc
            // 
            this.btnListTuDaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnListTuDaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTuDaThuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListTuDaThuoc.Location = new System.Drawing.Point(9, 3);
            this.btnListTuDaThuoc.Name = "btnListTuDaThuoc";
            this.btnListTuDaThuoc.Size = new System.Drawing.Size(172, 44);
            this.btnListTuDaThuoc.TabIndex = 12;
            this.btnListTuDaThuoc.Text = "Các từ đã nhớ";
            this.btnListTuDaThuoc.UseVisualStyleBackColor = false;
            this.btnListTuDaThuoc.Click += new System.EventHandler(this.btnTuDaThuoc_Click);
            // 
            // btnAllTu
            // 
            this.btnAllTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnAllTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAllTu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllTu.Image = ((System.Drawing.Image)(resources.GetObject("btnAllTu.Image")));
            this.btnAllTu.Location = new System.Drawing.Point(93, 253);
            this.btnAllTu.Name = "btnAllTu";
            this.btnAllTu.Size = new System.Drawing.Size(124, 41);
            this.btnAllTu.TabIndex = 12;
            this.btnAllTu.Text = "Tất cả";
            this.btnAllTu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllTu.UseVisualStyleBackColor = false;
            this.btnAllTu.Click += new System.EventHandler(this.btnAllTu_Click_1);
            // 
            // cbCaiDatHienThi
            // 
            this.cbCaiDatHienThi.FormattingEnabled = true;
            this.cbCaiDatHienThi.Items.AddRange(new object[] {
            "Mặt trước",
            "Mặt sau",
            "2 mặt"});
            this.cbCaiDatHienThi.Location = new System.Drawing.Point(176, 568);
            this.cbCaiDatHienThi.Name = "cbCaiDatHienThi";
            this.cbCaiDatHienThi.Size = new System.Drawing.Size(136, 24);
            this.cbCaiDatHienThi.TabIndex = 14;
            this.cbCaiDatHienThi.SelectedIndexChanged += new System.EventHandler(this.cbCaiDatHienThi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(17, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mặt Hiện";
            // 
            // pnFlashCard
            // 
            this.pnFlashCard.Controls.Add(this.btnNext);
            this.pnFlashCard.Controls.Add(this.panel2);
            this.pnFlashCard.Controls.Add(this.btnPre);
            this.pnFlashCard.Controls.Add(this.btnFlip);
            this.pnFlashCard.Controls.Add(this.btnTuChuaThuoc);
            this.pnFlashCard.Controls.Add(this.btnListTuDaThuoc);
            this.pnFlashCard.Location = new System.Drawing.Point(512, 34);
            this.pnFlashCard.Name = "pnFlashCard";
            this.pnFlashCard.Size = new System.Drawing.Size(585, 723);
            this.pnFlashCard.TabIndex = 16;
            // 
            // NhomTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 769);
            this.Controls.Add(this.pnFlashCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCaiDatHienThi);
            this.Controls.Add(this.btnAllTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDaysRecall);
            this.Controls.Add(this.numIndexWord);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NhomTu";
            this.Text = "NhomTu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhomTu_FormClosing);
            this.Load += new System.EventHandler(this.NhomTu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lbTuTongSo;
        private System.Windows.Forms.Label lbATTT;
    }
}