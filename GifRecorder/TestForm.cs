﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenToGif.Pages;

namespace ScreenToGif
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            content1.Dispose();
        }
    }
}