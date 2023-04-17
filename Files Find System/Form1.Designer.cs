
namespace Files_Find_System
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.flashlightPic = new System.Windows.Forms.PictureBox();
            this.foldersButton = new System.Windows.Forms.Button();
            this.docsButton = new System.Windows.Forms.Button();
            this.videosButton = new System.Windows.Forms.Button();
            this.imagesButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.Button();
            this.wordButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pageViewerPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashlightPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flashlightPic);
            this.panel1.Controls.Add(this.foldersButton);
            this.panel1.Controls.Add(this.docsButton);
            this.panel1.Controls.Add(this.videosButton);
            this.panel1.Controls.Add(this.imagesButton);
            this.panel1.Controls.Add(this.excelButton);
            this.panel1.Controls.Add(this.wordButton);
            this.panel1.Controls.Add(this.pdfButton);
            this.panel1.Controls.Add(this.HomePageButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 511);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 46);
            this.panel3.TabIndex = 12;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(181)))), ((int)(((byte)(172)))));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(48, 18);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(11, 11);
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(181)))), ((int)(((byte)(172)))));
            this.linkLabel1.Location = new System.Drawing.Point(64, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giriş sayfasına git";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // flashlightPic
            // 
            this.flashlightPic.Image = ((System.Drawing.Image)(resources.GetObject("flashlightPic.Image")));
            this.flashlightPic.Location = new System.Drawing.Point(35, 165);
            this.flashlightPic.Name = "flashlightPic";
            this.flashlightPic.Size = new System.Drawing.Size(30, 30);
            this.flashlightPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flashlightPic.TabIndex = 11;
            this.flashlightPic.TabStop = false;
            // 
            // foldersButton
            // 
            this.foldersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.foldersButton.FlatAppearance.BorderSize = 0;
            this.foldersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foldersButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.foldersButton.ForeColor = System.Drawing.Color.White;
            this.foldersButton.Location = new System.Drawing.Point(66, 402);
            this.foldersButton.Name = "foldersButton";
            this.foldersButton.Size = new System.Drawing.Size(107, 32);
            this.foldersButton.TabIndex = 10;
            this.foldersButton.Text = "Klasörler";
            this.foldersButton.UseVisualStyleBackColor = false;
            this.foldersButton.Click += new System.EventHandler(this.foldersButton_Click);
            // 
            // docsButton
            // 
            this.docsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.docsButton.FlatAppearance.BorderSize = 0;
            this.docsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docsButton.ForeColor = System.Drawing.Color.White;
            this.docsButton.Location = new System.Drawing.Point(66, 364);
            this.docsButton.Name = "docsButton";
            this.docsButton.Size = new System.Drawing.Size(107, 32);
            this.docsButton.TabIndex = 9;
            this.docsButton.Text = "Dökümanlar";
            this.docsButton.UseVisualStyleBackColor = false;
            this.docsButton.Click += new System.EventHandler(this.docsButton_Click);
            // 
            // videosButton
            // 
            this.videosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.videosButton.FlatAppearance.BorderSize = 0;
            this.videosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videosButton.ForeColor = System.Drawing.Color.White;
            this.videosButton.Location = new System.Drawing.Point(66, 326);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(107, 32);
            this.videosButton.TabIndex = 8;
            this.videosButton.Text = "Videolar";
            this.videosButton.UseVisualStyleBackColor = false;
            this.videosButton.Click += new System.EventHandler(this.videosButton_Click);
            // 
            // imagesButton
            // 
            this.imagesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.imagesButton.FlatAppearance.BorderSize = 0;
            this.imagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagesButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imagesButton.ForeColor = System.Drawing.Color.White;
            this.imagesButton.Location = new System.Drawing.Point(66, 288);
            this.imagesButton.Name = "imagesButton";
            this.imagesButton.Size = new System.Drawing.Size(107, 32);
            this.imagesButton.TabIndex = 7;
            this.imagesButton.Text = "Resimler";
            this.imagesButton.UseVisualStyleBackColor = false;
            this.imagesButton.Click += new System.EventHandler(this.imagesButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.excelButton.FlatAppearance.BorderSize = 0;
            this.excelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.excelButton.ForeColor = System.Drawing.Color.White;
            this.excelButton.Location = new System.Drawing.Point(66, 250);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(107, 32);
            this.excelButton.TabIndex = 6;
            this.excelButton.Text = "Excel";
            this.excelButton.UseVisualStyleBackColor = false;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // wordButton
            // 
            this.wordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.wordButton.FlatAppearance.BorderSize = 0;
            this.wordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordButton.ForeColor = System.Drawing.Color.White;
            this.wordButton.Location = new System.Drawing.Point(66, 211);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(107, 32);
            this.wordButton.TabIndex = 5;
            this.wordButton.Text = "Word";
            this.wordButton.UseVisualStyleBackColor = false;
            this.wordButton.Click += new System.EventHandler(this.wordButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.pdfButton.FlatAppearance.BorderSize = 0;
            this.pdfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdfButton.ForeColor = System.Drawing.Color.White;
            this.pdfButton.Location = new System.Drawing.Point(66, 172);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(107, 32);
            this.pdfButton.TabIndex = 4;
            this.pdfButton.Text = "Pdf";
            this.pdfButton.UseVisualStyleBackColor = false;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // HomePageButton
            // 
            this.HomePageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(125)))));
            this.HomePageButton.FlatAppearance.BorderSize = 0;
            this.HomePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomePageButton.ForeColor = System.Drawing.Color.White;
            this.HomePageButton.Location = new System.Drawing.Point(66, 133);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(107, 32);
            this.HomePageButton.TabIndex = 3;
            this.HomePageButton.Text = "Anasayfa";
            this.HomePageButton.UseVisualStyleBackColor = false;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 104);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(181)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "FFS";
            // 
            // pageViewerPanel
            // 
            this.pageViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewerPanel.Location = new System.Drawing.Point(239, 0);
            this.pageViewerPanel.Name = "pageViewerPanel";
            this.pageViewerPanel.Size = new System.Drawing.Size(664, 511);
            this.pageViewerPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(903, 511);
            this.Controls.Add(this.pageViewerPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFS - Files Find System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashlightPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button wordButton;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.Button videosButton;
        private System.Windows.Forms.Button imagesButton;
        private System.Windows.Forms.Button docsButton;
        private System.Windows.Forms.Button foldersButton;
        private System.Windows.Forms.PictureBox flashlightPic;
        private System.Windows.Forms.Panel pageViewerPanel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

