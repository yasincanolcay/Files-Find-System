using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_Find_System
{
    public partial class Form1 : Form
    {
        public string path = "";
        public bool autoSelection = false;
        List<HomePage> homePageList = new List<HomePage>();
        List<DataViewerPage> dataViewerPageList = new List<DataViewerPage>();
        public LoginPage lgnPage = new LoginPage();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadHomePage();
        }
        private void disposeAllPage()
        {
            //Tüm sayfaları bellekten temizle
            if (homePageList.Count != 0)
            {
                homePageList[0].Dispose();
                GC.SuppressFinalize(homePageList[0]);
            }
            if (dataViewerPageList.Count != 0)
            {
                dataViewerPageList[0].Dispose();
                GC.SuppressFinalize(dataViewerPageList[0]);
            }
        }
        private void loadHomePage()
        {
            disposeAllPage();
            HomePage page = new HomePage();
            page.TopLevel = false;
            page.Dock = DockStyle.Fill;
            page.path = path;
            page.autoSelection = autoSelection;
            pageViewerPanel.Controls.Clear();
            pageViewerPanel.Controls.Add(page);
            page.Show();
            homePageList.Add(page);
        }
        private void loadDataViewPage(string extension)
        {
            disposeAllPage();
            DataViewerPage page = new DataViewerPage();
            page.TopLevel = false;
            page.Dock = DockStyle.Fill;
            page.path = path;
            page.autoSelection = autoSelection;
            page.extension = extension;
            pageViewerPanel.Controls.Clear();
            pageViewerPanel.Controls.Add(page);
            page.Show();
            dataViewerPageList.Add(page);
        }
        private void HomePageButton_Click(object sender, EventArgs e)
        {
            HomePageButton.BackColor = Color.FromArgb(52, 81, 125);
            pdfButton.BackColor = Color.FromArgb(30, 54, 92);
            wordButton.BackColor = Color.FromArgb(30, 54, 92);
            excelButton.BackColor = Color.FromArgb(30, 54, 92);
            imagesButton.BackColor = Color.FromArgb(30, 54, 92);
            videosButton.BackColor = Color.FromArgb(30, 54, 92);
            docsButton.BackColor = Color.FromArgb(30, 54, 92);
            foldersButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = HomePageButton.Bottom;
            loadHomePage();
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            pdfButton.BackColor = Color.FromArgb(52, 81, 125);
            HomePageButton.BackColor = Color.FromArgb(30, 54, 92);
            wordButton.BackColor = Color.FromArgb(30, 54, 92);
            excelButton.BackColor = Color.FromArgb(30, 54, 92);
            imagesButton.BackColor = Color.FromArgb(30, 54, 92);
            videosButton.BackColor = Color.FromArgb(30, 54, 92);
            docsButton.BackColor = Color.FromArgb(30, 54, 92);
            foldersButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = pdfButton.Bottom;
            loadDataViewPage("pdf");
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            wordButton.BackColor = Color.FromArgb(52, 81, 125);
            HomePageButton.BackColor = Color.FromArgb(30, 54, 92);
            pdfButton.BackColor = Color.FromArgb(30, 54, 92);
            excelButton.BackColor = Color.FromArgb(30, 54, 92);
            imagesButton.BackColor = Color.FromArgb(30, 54, 92);
            videosButton.BackColor = Color.FromArgb(30, 54, 92);
            docsButton.BackColor = Color.FromArgb(30, 54, 92);
            foldersButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = wordButton.Bottom;
            loadDataViewPage("word");
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            excelButton.BackColor = Color.FromArgb(52, 81, 125);
            HomePageButton.BackColor = Color.FromArgb(30, 54, 92);
            pdfButton.BackColor = Color.FromArgb(30, 54, 92);
            wordButton.BackColor = Color.FromArgb(30, 54, 92);
            imagesButton.BackColor = Color.FromArgb(30, 54, 92);
            videosButton.BackColor = Color.FromArgb(30, 54, 92);
            docsButton.BackColor = Color.FromArgb(30, 54, 92);
            foldersButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = excelButton.Bottom;
            loadDataViewPage("excel");
        }

        private void imagesButton_Click(object sender, EventArgs e)
        {
            imagesButton.BackColor = Color.FromArgb(52, 81, 125);
            HomePageButton.BackColor = Color.FromArgb(30, 54, 92);
            pdfButton.BackColor = Color.FromArgb(30, 54, 92);
            wordButton.BackColor = Color.FromArgb(30, 54, 92);
            excelButton.BackColor = Color.FromArgb(30, 54, 92);
            videosButton.BackColor = Color.FromArgb(30, 54, 92);
            docsButton.BackColor = Color.FromArgb(30, 54, 92);
            foldersButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = imagesButton.Bottom;
            loadDataViewPage("images");
        }

        private void videosButton_Click(object sender, EventArgs e)
        {
            videosButton.BackColor = Color.FromArgb(52, 81, 125);
            HomePageButton.BackColor = Color.FromArgb(30, 54, 92);
            pdfButton.BackColor = Color.FromArgb(30, 54, 92);
            wordButton.BackColor = Color.FromArgb(30, 54, 92);
            excelButton.BackColor = Color.FromArgb(30, 54, 92);
            imagesButton.BackColor = Color.FromArgb(30, 54, 92);
            docsButton.BackColor = Color.FromArgb(30, 54, 92);
            foldersButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = videosButton.Bottom;
            loadDataViewPage("videos");
        }

        private void docsButton_Click(object sender, EventArgs e)
        {
            docsButton.BackColor = Color.FromArgb(52, 81, 125);
            HomePageButton.BackColor = Color.FromArgb(30, 54, 92);
            pdfButton.BackColor = Color.FromArgb(30, 54, 92);
            wordButton.BackColor = Color.FromArgb(30, 54, 92);
            excelButton.BackColor = Color.FromArgb(30, 54, 92);
            imagesButton.BackColor = Color.FromArgb(30, 54, 92);
            videosButton.BackColor = Color.FromArgb(30, 54, 92);
            foldersButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = docsButton.Bottom;
            loadDataViewPage("documents");
        }

        private void foldersButton_Click(object sender, EventArgs e)
        {
            foldersButton.BackColor = Color.FromArgb(52, 81, 125);
            HomePageButton.BackColor = Color.FromArgb(30, 54, 92);
            pdfButton.BackColor = Color.FromArgb(30, 54, 92);
            wordButton.BackColor = Color.FromArgb(30, 54, 92);
            excelButton.BackColor = Color.FromArgb(30, 54, 92);
            imagesButton.BackColor = Color.FromArgb(30, 54, 92);
            videosButton.BackColor = Color.FromArgb(30, 54, 92);
            docsButton.BackColor = Color.FromArgb(30, 54, 92);
            flashlightPic.Top = foldersButton.Bottom;
            loadDataViewPage("folders");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lgnPage.Show();
            disposeAllPage();
            this.Close();
            this.Dispose();
            GC.SuppressFinalize(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            disposeAllPage();
            this.Dispose();
            GC.SuppressFinalize(this);
            this.Close();
        }
    }
}
