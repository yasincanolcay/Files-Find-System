using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_Find_System
{
    public partial class HomePage : Form
    {
        string[] webExtensions = { ".pdf", ".html", ".docx", ".xlsx", ".pptx", ".xml" };
        List<string> extensions = new List<string>();
        //---------------------//
        public string path = "";
        public bool autoSelection = false;
        //---------------------//
        int totalFiles = 0;
        int totalFolders = 0;
        int pdf = 0;
        int exts = 0;
        int webs = 0;
        int applications = 0;
        int models = 0;
        int database = 0;
        int codes = 0;
        int documents = 0;
        int videos = 0;
        int audioes = 0;
        int images = 0;
        public HomePage()
        {
            InitializeComponent();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        private string GetCategory(string extension)
        {
            string category = "Diğer Dosyalar"; // Varsayılan kategori
            switch (extension.ToLower())
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                case ".bmp":
                    category = "Görseller";
                    images++;

                    break;

                case ".mp3":
                case ".m4a":
                case ".wav":
                case ".wma":
                case ".aac":
                    category = "Ses Dosyaları";
                    audioes++;

                    break;

                case ".avi":
                case ".mp4":
                case ".wmv":
                case ".mkv":
                    category = "Video Dosyaları";
                    videos++;

                    break;

                case ".doc":
                case ".docx":
                case ".pdf":
                case ".txt":
                    category = "Dökümanlar";
                    documents++;

                    break;

                case ".html":
                case ".css":
                case ".js":
                case ".java":
                case ".py":
                case ".pyw":
                case ".dll":
                case ".cs":
                case ".php":
                case ".dart":
                case ".bat":
                case ".c":
                case ".cpp":
                case ".rb":
                case ".swift":
                case ".go":
                case ".kt":
                case ".scala":
                case ".pl":
                case ".lua":
                    category = "Kod Dosyaları";
                    codes++;

                    break;
                case ".mdf":
                case ".json":
                case ".sql":
                case ".md":
                    category = "Veri Tabanı";
                    database++;


                    break;
                case ".obj":
                case ".fbx":
                case ".stl":
                case ".blend":
                    category = "3D Model";
                    models++;
                    break;
                case ".exe":
                case ".dmg":
                case ".apk":
                case ".app":
                case ".msi":
                case ".deb":
                case ".rpm":
                case ".jar":
                case ".tar":
                case ".zip":
                    applications++;
                    break;
            }
            if (extension == ".pdf")
                pdf++;
            if (webExtensions.Contains(extension))
                webs++;
            if (!extensions.Contains(extension))
            {
                extensions.Append(extension);
                exts++;
            }
            return category;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach(DriveInfo drive in drives)
                {
                    if (autoSelection)
                    {
                        path = drive.RootDirectory.FullName;
                    }
                    try
                    {
                        pdf = 0;
                        exts = 0;
                        webs = 0;
                        applications = 0;
                        models = 0;
                        database = 0;
                        codes = 0;
                        documents = 0;
                        videos = 0;
                        audioes = 0;
                        images = 0;
                        totalFiles = 0;
                        totalFolders = 0;
                        // Klasöre erişim izni alınması
                        DirectorySecurity security = Directory.GetAccessControl(path);
                        AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(NTAccount));
                        string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                        string[] subDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                        foreach (string file in files)
                        {
                            try
                            {
                                totalFiles++;
                                // Klasöre erişim izni alınması
                                DirectorySecurity security2 = Directory.GetAccessControl(Path.GetFullPath(file));
                                AuthorizationRuleCollection rules2 = security.GetAccessRules(true, true, typeof(NTAccount));
                                // Dosyaya erişim izni alınması
                                FileSecurity fileSecurity = File.GetAccessControl(file);
                                AuthorizationRuleCollection fileRules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
                                // Dosya bilgilerini al
                                FileInfo fileInfo = new FileInfo(file);
                                //
                                // Dosya izinlerini kontrol et
                                if ((fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden || (fileInfo.Attributes & FileAttributes.System) == FileAttributes.System)
                                {
                                    continue; // Gizli veya sistem dosyalarını atla
                                }
                                // Dosya kategorisini belirle
                                string category = GetCategory(fileInfo.Extension);
                                // Dosya bilgilerini yazdır
                                backgroundWorker1.ReportProgress(0, string.Format("{0}\t\t{1}\t\t{2}", file, category, fileInfo.Length));
                            }
                            catch (UnauthorizedAccessException)
                            {
                                // Erişim izni hatası, dosya atlanır
                                continue;
                            }
                        }
                        foreach (string sub in subDirectories)
                        {
                            totalFolders++;
                            backgroundWorker1.ReportProgress(0);
                        }
                    }
                    catch
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            imagesLabel.Text = images.ToString();
            audiosLabel.Text = audioes.ToString();
            videosLabel.Text = videos.ToString();
            documentsLabel.Text = documents.ToString();
            codesLabel.Text = codes.ToString();
            databaseLabel.Text = database.ToString();
            modelsLabel.Text = models.ToString();
            pdfLabel.Text = pdf.ToString();
            webLabel.Text = webs.ToString();
            totalFilesLabel.Text = totalFiles.ToString();
            foldersLabel.Text = totalFolders.ToString();
            extensionsLabel.Text = exts.ToString();
            appLabel.Text = applications.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            imagesLabel.Text = images.ToString();
            audiosLabel.Text = audioes.ToString();
            videosLabel.Text = videos.ToString();
            documentsLabel.Text = documents.ToString();
            codesLabel.Text = codes.ToString();
            databaseLabel.Text = database.ToString();
            modelsLabel.Text = models.ToString();
            pdfLabel.Text = pdf.ToString();
            webLabel.Text = webs.ToString();
            totalFilesLabel.Text = totalFiles.ToString();
            foldersLabel.Text = totalFolders.ToString();
            extensionsLabel.Text = exts.ToString();
            appLabel.Text = applications.ToString();
        }
    }
}
