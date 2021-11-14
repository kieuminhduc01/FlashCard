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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomTu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTuTongSo = new System.Windows.Forms.Label();
            this.pnBack = new System.Windows.Forms.Panel();
            this.lbATTT = new System.Windows.Forms.Label();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbPathOfSpeech = new System.Windows.Forms.Label();
            this.pnFront = new System.Windows.Forms.Panel();
            this.lbTagName = new System.Windows.Forms.Label();
            this.lbExample = new System.Windows.Forms.Label();
            this.lbIPA = new System.Windows.Forms.Label();
            this.dtpkSetTgOn = new System.Windows.Forms.MonthCalendar();
            this.cbHienAmThanhTuongTu = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTuChuaCoLichOn = new System.Windows.Forms.Button();
            this.btnAllTu = new System.Windows.Forms.Button();
            this.trmProcessing = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.pnBack.SuspendLayout();
            this.pnFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTuTongSo);
            this.panel2.Controls.Add(this.pnBack);
            this.panel2.Controls.Add(this.pnFront);
            this.panel2.Location = new System.Drawing.Point(490, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 609);
            this.panel2.TabIndex = 1;
            // 
            // lbTuTongSo
            // 
            this.lbTuTongSo.AutoSize = true;
            this.lbTuTongSo.Location = new System.Drawing.Point(240, 16);
            this.lbTuTongSo.Name = "lbTuTongSo";
            this.lbTuTongSo.Size = new System.Drawing.Size(85, 16);
            this.lbTuTongSo.TabIndex = 6;
            this.lbTuTongSo.Text = "Tu/TongSo";
            // 
            // pnBack
            // 
            this.pnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBack.Controls.Add(this.lbATTT);
            this.pnBack.Controls.Add(this.lbMean);
            this.pnBack.Controls.Add(this.lbPathOfSpeech);
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
            // 
            // pnFront
            // 
            this.pnFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFront.Controls.Add(this.lbTagName);
            this.pnFront.Controls.Add(this.lbExample);
            this.pnFront.Controls.Add(this.lbIPA);
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
            // 
            // lbExample
            // 
            this.lbExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExample.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbExample.Location = new System.Drawing.Point(32, 39);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(482, 133);
            this.lbExample.TabIndex = 1;
            this.lbExample.Text = "Example";
            this.lbExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIPA
            // 
            this.lbIPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIPA.Location = new System.Drawing.Point(379, 214);
            this.lbIPA.Name = "lbIPA";
            this.lbIPA.Size = new System.Drawing.Size(155, 41);
            this.lbIPA.TabIndex = 1;
            this.lbIPA.Text = "IPA";
            this.lbIPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpkSetTgOn
            // 
            this.dtpkSetTgOn.Enabled = false;
            this.dtpkSetTgOn.Location = new System.Drawing.Point(23, 80);
            this.dtpkSetTgOn.Name = "dtpkSetTgOn";
            this.dtpkSetTgOn.TabIndex = 19;
            this.dtpkSetTgOn.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtpkSetTgOn_DateChanged);
            // 
            // cbHienAmThanhTuongTu
            // 
            this.cbHienAmThanhTuongTu.AutoSize = true;
            this.cbHienAmThanhTuongTu.Location = new System.Drawing.Point(178, 359);
            this.cbHienAmThanhTuongTu.Name = "cbHienAmThanhTuongTu";
            this.cbHienAmThanhTuongTu.Size = new System.Drawing.Size(105, 20);
            this.cbHienAmThanhTuongTu.TabIndex = 13;
            this.cbHienAmThanhTuongTu.Text = "Hiện ATTT";
            this.cbHienAmThanhTuongTu.UseVisualStyleBackColor = true;
            this.cbHienAmThanhTuongTu.CheckedChanged += new System.EventHandler(this.cbHienAmThanhTuongTu_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(23, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 41);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTuChuaCoLichOn
            // 
            this.btnTuChuaCoLichOn.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnTuChuaCoLichOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnTuChuaCoLichOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnTuChuaCoLichOn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTuChuaCoLichOn.Image = ((System.Drawing.Image)(resources.GetObject("btnTuChuaCoLichOn.Image")));
            this.btnTuChuaCoLichOn.Location = new System.Drawing.Point(216, 35);
            this.btnTuChuaCoLichOn.Name = "btnTuChuaCoLichOn";
            this.btnTuChuaCoLichOn.Size = new System.Drawing.Size(149, 41);
            this.btnTuChuaCoLichOn.TabIndex = 20;
            this.btnTuChuaCoLichOn.Text = "Cần ôn";
            this.btnTuChuaCoLichOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTuChuaCoLichOn.UseVisualStyleBackColor = false;
            this.btnTuChuaCoLichOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAllTu
            // 
            this.btnAllTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(116)))));
            this.btnAllTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAllTu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllTu.Image = ((System.Drawing.Image)(resources.GetObject("btnAllTu.Image")));
            this.btnAllTu.Location = new System.Drawing.Point(29, 35);
            this.btnAllTu.Name = "btnAllTu";
            this.btnAllTu.Size = new System.Drawing.Size(149, 41);
            this.btnAllTu.TabIndex = 12;
            this.btnAllTu.Text = "Tất cả";
            this.btnAllTu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllTu.UseVisualStyleBackColor = false;
            this.btnAllTu.Click += new System.EventHandler(this.btnAllTu_Click_1);
            // 
            // NhomTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbHienAmThanhTuongTu);
            this.Controls.Add(this.btnTuChuaCoLichOn);
            this.Controls.Add(this.dtpkSetTgOn);
            this.Controls.Add(this.btnAllTu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "NhomTu";
            this.Text = "NhomTu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhomTu_FormClosing);
            this.Load += new System.EventHandler(this.NhomTu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NhomTu_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnBack.ResumeLayout(false);
            this.pnFront.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTagName;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label lbIPA;
        private System.Windows.Forms.Label lbPathOfSpeech;
        private System.Windows.Forms.Panel pnFront;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.Button btnAllTu;
        private System.Windows.Forms.Label lbTuTongSo;
        private System.Windows.Forms.Label lbATTT;
        private System.Windows.Forms.MonthCalendar dtpkSetTgOn;
        private System.Windows.Forms.Button btnTuChuaCoLichOn;
        private System.Windows.Forms.CheckBox cbHienAmThanhTuongTu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer trmProcessing;
    }
}