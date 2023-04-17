using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_Find_System
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        //public static bool IsUserAdministrator()
        //{
        //    // Yönetici kimliğine sahip olup olmadığınızı kontrol edin
        //    WindowsIdentity user = WindowsIdentity.GetCurrent();
        //    WindowsPrincipal principal = new WindowsPrincipal(user);
        //    return principal.IsInRole(WindowsBuiltInRole.Administrator);
        //}
        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "FFS - Klasör Seçimi Yapınız";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Form1 page = new Form1();
                page.path = folderBrowserDialog1.SelectedPath;
                page.autoSelection = false;
                page.lgnPage = this;
                page.Show();
                this.Hide();
            }
        }

        private void autoSelectButton_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.autoSelection = true;
            page.lgnPage = this;
            page.Show();
            this.Hide();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //if (!IsUserAdministrator())
            //{
            //    // Eğer kullanıcı yönetici değilse, yönetici olarak çalıştırılması için başlatma kodu yazın
            //    ProcessStartInfo startInfo = new ProcessStartInfo();
            //    startInfo.UseShellExecute = true;
            //    startInfo.WorkingDirectory = Environment.CurrentDirectory;
            //    startInfo.FileName = Application.ExecutablePath;
            //    startInfo.Verb = "runas";
            //    try
            //    {
            //        Process.Start(startInfo);
            //    }
            //    catch
            //    {
            //        // Hata oluştuğunda burada işlem yapabilirsiniz
            //    }
            //    // Uygulamayı sonlandırın
            //    Application.Exit();
            //}
        }
    }
}
