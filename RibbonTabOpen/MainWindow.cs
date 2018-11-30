﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonTabOpen
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ribbon newForm = new Ribbon();
                newForm.Show();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Ribbon newForm = new Ribbon();
            newForm.Show();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox newFrame1 = new AboutBox();
            newFrame1.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
           
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MouseHover_Exit(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "нажмите для выхода из программы";
        }

        private void MouseLeave_Exit(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать";
        }

        private void MouseHover_About(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "сведения о программе";
        }

        private void MouseLeave_About(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Добро пожаловать";
        }
    }
}
