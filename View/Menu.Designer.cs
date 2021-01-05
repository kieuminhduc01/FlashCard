namespace FlashCard.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnMoThuMucData = new System.Windows.Forms.Button();
            this.btnNewGroup = new System.Windows.Forms.Button();
            this.openFileDialogFileVocabulary = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnMain);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1541, 915);
            this.panel2.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 76);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1541, 839);
            this.pnMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLearn);
            this.panel1.Controls.Add(this.btnMoThuMucData);
            this.panel1.Controls.Add(this.btnNewGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 76);
            this.panel1.TabIndex = 4;
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.White;
            this.btnLearn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLearn.FlatAppearance.BorderSize = 0;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLearn.Image = ((System.Drawing.Image)(resources.GetObject("btnLearn.Image")));
            this.btnLearn.Location = new System.Drawing.Point(386, 0);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(193, 76);
            this.btnLearn.TabIndex = 2;
            this.btnLearn.Text = "Learn";
            this.btnLearn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnMoThuMucData
            // 
            this.btnMoThuMucData.BackColor = System.Drawing.Color.White;
            this.btnMoThuMucData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMoThuMucData.FlatAppearance.BorderSize = 0;
            this.btnMoThuMucData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoThuMucData.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoThuMucData.Image = ((System.Drawing.Image)(resources.GetObject("btnMoThuMucData.Image")));
            this.btnMoThuMucData.Location = new System.Drawing.Point(193, 0);
            this.btnMoThuMucData.Name = "btnMoThuMucData";
            this.btnMoThuMucData.Size = new System.Drawing.Size(193, 76);
            this.btnMoThuMucData.TabIndex = 1;
            this.btnMoThuMucData.Text = "Data";
            this.btnMoThuMucData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoThuMucData.UseVisualStyleBackColor = false;
            this.btnMoThuMucData.Click += new System.EventHandler(this.btnMoThuMucData_Click);
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.BackColor = System.Drawing.Color.White;
            this.btnNewGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewGroup.FlatAppearance.BorderSize = 0;
            this.btnNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGroup.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGroup.Image")));
            this.btnNewGroup.Location = new System.Drawing.Point(0, 0);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(193, 76);
            this.btnNewGroup.TabIndex = 0;
            this.btnNewGroup.Text = "New a list";
            this.btnNewGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewGroup.UseVisualStyleBackColor = false;
            this.btnNewGroup.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogFileVocabulary
            // 
            this.openFileDialogFileVocabulary.FileName = "openFileDialog1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 920);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Green;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewGroup;
        private System.Windows.Forms.Button btnMoThuMucData;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.OpenFileDialog openFileDialogFileVocabulary;
    }
}