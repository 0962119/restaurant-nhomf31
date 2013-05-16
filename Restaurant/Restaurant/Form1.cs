﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;


namespace Restaurant
{
    public partial class Form1 : MetroAppForm
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

        }

        private void metroTileItem15_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
            expandablePanel1.TitleHeight = 1;
            metroTabItem3.Select();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        private void metroStatusBar1_MouseHover(object sender, EventArgs e)
        {
            //expandablePanel1.Expanded = true;
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }
    }
}