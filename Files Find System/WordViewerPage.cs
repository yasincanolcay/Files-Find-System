﻿using System;
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
    public partial class WordViewerPage : Form
    {
        public string path = "";
        public WordViewerPage()
        {
            InitializeComponent();
        }

        private void WordViewerPage_Load(object sender, EventArgs e)
        {
            officeViewer1.LoadFromFile(path);
        }
    }
}
