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
    public partial class DataViewerPage : Form
    {
        public string path = "";
        public string extension = "";
        private DataTable dataTable = new DataTable();
        bool searchMode = false;
        Image image = Image.FromFile("assets/filesicons/folder_30px.png");
        public bool autoSelection = false;
        private string[] audioExts = {
            ".mp3",
            ".m4a",
            ".midi",
            ".wav",
            ".mid",
        };
        private string[] imageExts = { ".bmp", ".gif", ".ico", ".jpeg", ".svg", ".tif", ".tiff", ".ai" };
        private string[] unityextensions = { ".unity", ".prefab", ".asset", ".anim", ".controller", ".mat", ".meta", ".physicMaterial", ".physicMaterial2D", ".mixer", ".overrideController", ".playable", ".renderTexture", ".spriteAtlas" };

        public DataViewerPage()
        {
            InitializeComponent();
            dataTable.Columns.Add(".", typeof(Image));
            dataTable.Columns.Add("Ad");
            dataTable.Columns.Add("Yol");
            dataTable.Columns.Add("Uzantı");
            dataGridView1.DataSource = dataTable;
        }

        private void DataViewerPage_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            loadAll();
        }
        private void loadAll()
        {
            try
            {

                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    try
                    {
                        if (extension != "folders")
                        {
                            if (autoSelection)
                            {
                                path = drive.RootDirectory.FullName;
                            }
                            // Klasöre erişim izni alınması
                            DirectorySecurity security = Directory.GetAccessControl(path);
                            AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(NTAccount));
                            // Uzun süren işlemi gerçekleştirin, örneğin dosya okuma
                            var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
                            if (extension == "pdf")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".pdf"));
                            }
                            else if (extension == "word")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".doc") || file.EndsWith(".docx") || file.EndsWith(".xls") || file.EndsWith(".xlsx") || file.EndsWith(".ppt") || file.EndsWith(".pptx"));
                            }
                            else if (extension == "excel")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".xlsm") || file.EndsWith(".xlsb") || file.EndsWith(".xls") || file.EndsWith(".xlsx") || file.EndsWith(".xltm") || file.EndsWith(".xltx"));
                            }
                            else if (extension == "model")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".obj") || file.EndsWith(".fbx") || file.EndsWith(".stl") || file.EndsWith(".blend") || file.EndsWith(".ma") || file.EndsWith(".mb") || file.EndsWith(".3ds") || file.EndsWith(".max") || file.EndsWith(".dae") || file.EndsWith(".x3d"));
                            }
                            else if (extension == "code")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".cs") || file.EndsWith(".py") || file.EndsWith(".cpp") || file.EndsWith(".dart") || file.EndsWith(".pyw") || file.EndsWith(".html") || file.EndsWith(".css") || file.EndsWith(".js") || file.EndsWith(".c") || file.EndsWith(".java") || file.EndsWith(".h") || file.EndsWith(".php") || file.EndsWith(".rb") || file.EndsWith(".swift") || file.EndsWith(".go"));
                            }
                            else if (extension == "app")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".exe") || file.EndsWith(".apk") || file.EndsWith(".dmg") || file.EndsWith(".app") || file.EndsWith(".ipa") || file.EndsWith(".deb") || file.EndsWith(".rpm") || file.EndsWith(".jar") || file.EndsWith(".msi") || file.EndsWith(".bat") || file.EndsWith(".sh"));
                            }
                            else if (extension == "zip")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".zip"));
                            }
                            else if (extension == "rar")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".rar"));
                            }
                            else if (extension == "images")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".jpg") || file.EndsWith(".jpeg") || file.EndsWith(".png") || file.EndsWith(".gif") || file.EndsWith(".svg") || file.EndsWith(".webp") || file.EndsWith(".apng") || file.EndsWith(".tiff") || file.EndsWith(".raw") || file.EndsWith(".psd"));
                            }
                            else if (extension == "videos")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".mp4") || file.EndsWith(".avi") || file.EndsWith(".mkv") || file.EndsWith(".wmv") || file.EndsWith(".flv") || file.EndsWith(".3gp") || file.EndsWith(".dat") || file.EndsWith(".mov"));
                            }
                            else if (extension == "documents")
                            {
                                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.EndsWith(".pdf") || file.EndsWith(".doc") || file.EndsWith(".docs") || file.EndsWith(".xls") || file.EndsWith(".txt") || file.EndsWith(".html") || file.EndsWith(".xlsx") || file.EndsWith(".ppt") || file.EndsWith(".pptx") || file.EndsWith(".xltm") || file.EndsWith(".xltx")|| file.EndsWith(".cs") || file.EndsWith(".py") || file.EndsWith(".cpp") || file.EndsWith(".dart") || file.EndsWith(".pyw") || file.EndsWith(".html") || file.EndsWith(".css") || file.EndsWith(".js") || file.EndsWith(".c") || file.EndsWith(".java") || file.EndsWith(".h") || file.EndsWith(".php") || file.EndsWith(".rb") || file.EndsWith(".swift") || file.EndsWith(".go"));
                            }
                            foreach (var file in files)
                            {
                                try
                                {
                                    // Dosyaya erişim izni alınması
                                    FileSecurity fileSecurity = File.GetAccessControl(file);
                                    AuthorizationRuleCollection fileRules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
                                    FileInfo fileInfo = new FileInfo(file);
                                    image = Image.FromFile(SetImagesPath(fileInfo.Extension));
                                    Image thumbnail = image.GetThumbnailImage(20, 20, null, IntPtr.Zero);
                                    if (!searchMode)
                                    {
                                        // Verileri DataTable'e ekleyin
                                        //dataTable.Rows.Add(fileInfo.Name, fileInfo.FullName, fileInfo.Extension);
                                        dataGridView1.RowTemplate.Height = 50;
                                        dataTable.Rows.Add(thumbnail, fileInfo.Name, fileInfo.FullName, fileInfo.Extension);
                                    }
                                    else
                                    {
                                        if (searchBox.Text.ToLower() == fileInfo.Name.ToLower() || searchBox.Text.ToLower() == fileInfo.FullName.ToLower()|| searchBox.Text.ToLower() == fileInfo.Name.Remove(fileInfo.Name.Length-4).ToLower())
                                        {
                                            dataGridView1.RowTemplate.Height = 50;
                                            dataTable.Rows.Add(thumbnail, fileInfo.Name, fileInfo.FullName, fileInfo.Extension);
                                        }
                                    }
                                }
                                catch
                                {
                                }
                            }
                        }
                        else
                        {
                            Image thumbnail = image.GetThumbnailImage(20, 20, null, IntPtr.Zero);
                            try
                            {
                                string[] subDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                                foreach (string sub in subDirectories)
                                {
                                    try
                                    {
                                        if (!searchMode)
                                        {
                                            // Verileri DataTable'e ekleyin
                                            //dataTable.Rows.Add(fileInfo.Name, fileInfo.FullName, fileInfo.Extension);
                                            dataGridView1.RowTemplate.Height = 50;
                                            dataTable.Rows.Add(thumbnail, Path.GetDirectoryName(sub), Path.GetFullPath(sub), "Klasör");
                                        }
                                        else
                                        {
                                            if (searchBox.Text.ToLower() == Path.GetDirectoryName(sub).ToLower() || searchBox.Text.ToLower() == Path.GetFullPath(sub).ToLower())
                                            {
                                                dataGridView1.RowTemplate.Height = 50;
                                                dataTable.Rows.Add(thumbnail, Path.GetDirectoryName(sub), Path.GetFullPath(sub), "Klasör");
                                            }
                                        }
                                    }
                                    catch
                                    {
                                    }
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
        }
        private string SetImagesPath(string ext)
        {
            string imagePath = "";

            if (ext == ".apk")
            {
                imagePath = "assets/filesicons/apk_30px.png";
            }
            else if (audioExts.Contains(ext))
            {
                imagePath = "assets/filesicons/audio_file_30px.png";
            }
            else if (ext == ".wma")
            {
                imagePath = "assets/filesicons/wma_30px.png";
            }
            else if (ext == ".css")
            {
                imagePath = "assets//css_filetype_30px.png";
            }
            else if (ext == ".dll")
            {
                imagePath = "assets/filesicons/dll_30px.png";
            }
            else if (ext == ".exe")
            {
                imagePath = "assets/filesicons/exe_30px.png";
            }
            else if (ext == ".html")
            {
                imagePath = "assets/filesicons/html_filetype_30px.png";
            }
            else if (ext == ".java")
            {
                imagePath = "assets/filesicons/java_file_30px.png";
            }
            else if (ext == ".jpg")
            {
                imagePath = "assets/filesicons/jpg_30px.png";
            }
            else if (ext == ".json")
            {
                imagePath = "assets/filesicons/json_30px.png";
            }
            else if (ext == ".mpg")
            {
                imagePath = "assets/filesicons/mpg_30px.png";
            }
            else if (ext == ".pdf")
            {
                imagePath = "assets/filesicons/pdf_30px.png";
            }
            else if (ext == ".png")
            {
                imagePath = "assets/filesicons/png_30px.png";
            }
            else if (ext == ".ps")
            {
                imagePath = "assets/filesicons/ps_30px.png";
            }
            else if (ext == ".rar")
            {
                imagePath = "assets/filesicons/rar_30px.png";
            }
            else if (ext == ".txt")
            {
                imagePath = "assets/filesicons/txt_30px.png";
            }
            else if (ext == ".docx" || extension == ".docm" || extension == ".doc")
            {
                imagePath = "assets/filesicons/word_30px.png";
            }
            else if (ext == ".xls")
            {
                imagePath = "assets/filesicons/xls_30px.png";
            }
            else if (ext == ".xml")
            {
                imagePath = "assets/filesicons/xml_file_30px.png";
            }
            else if (ext == ".zip")
            {
                imagePath = "assets/filesicons/zip_30px.png";
            }
            else if (imageExts.Contains(ext))
            {
                imagePath = "assets/filesicons/image_file_30px.png";
            }
            else if (unityextensions.Contains(ext))
            {
                imagePath = "assets/filesicons/unity_30px.png";
            }
            else if (ext == ".py" || ext == ".pyw")
            {
                imagePath = "assets/filesicons/python_30px.png";
            }

            return imagePath;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                dataGridView1.Refresh();
                dataGridView1.Columns[0].Width = 20;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.RowTemplate.Height = 80;
            }
            catch
            {
            }
        }

        private void DataViewerPage_Resize(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[3].Width = 100;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // satırı al
                    string value = row.Cells[e.ColumnIndex].Value.ToString(); // ilk hücrenin değerini al
                    if (e.ColumnIndex == 1)
                    {
                        if (extension == "word" || extension == "excel"||extension=="pdf"||extension== "documents")
                        {
                            if (row.Cells[3].Value.ToString()!=".txt"&& row.Cells[3].Value.ToString() != ".html")
                            {
                                //burada word önizleme sayfası açılacak
                                value = row.Cells[2].Value.ToString();
                                WordViewerPage page = new WordViewerPage();
                                page.path = value;
                                page.Show();
                            }
                            else
                            {
                                value = row.Cells[2].Value.ToString();
                                System.Diagnostics.Process.Start(value);
                            }
                        }
                        else
                        {
                            value = row.Cells[2].Value.ToString();
                            System.Diagnostics.Process.Start(value);
                        }
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        //klasöre git
                        value = row.Cells[2].Value.ToString().Trim(row.Cells[1].Value.ToString().ToCharArray());
                        System.Diagnostics.Process.Start(value);
                    }
                }
            }
            catch
            {
            }
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                dataTable.Rows.Clear();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void searchPicture_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                searchMode = true;
                dataTable.Rows.Clear();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "" || string.IsNullOrEmpty(searchBox.Text)||string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchMode = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            guna2MessageDialog1.Text = "Sadece erişim izni verilen dosya ve klasörleri görüntülüyorsunuz,\ngizli dosya ve klasörler işleme konulmaz,\nbunun için izinlerinizi gözden geçirebilirsiniz.";
            guna2MessageDialog1.Show();
        }
    }
}
