
namespace Files_Find_System
{
    partial class WordViewerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordViewerPage));
            this.officeViewer1 = new Spire.OfficeViewer.Forms.OfficeViewer();
            this.SuspendLayout();
            // 
            // officeViewer1
            // 
            this.officeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.officeViewer1.Location = new System.Drawing.Point(0, 0);
            this.officeViewer1.Name = "officeViewer1";
            this.officeViewer1.Size = new System.Drawing.Size(800, 450);
            this.officeViewer1.TabIndex = 0;
            this.officeViewer1.Text = "officeViewer1";
            // 
            // WordViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.officeViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordViewerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Belgesi Görüntüleniyor...";
            this.Load += new System.EventHandler(this.WordViewerPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Spire.OfficeViewer.Forms.OfficeViewer officeViewer1;
    }
}