using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonTabOpen
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void HelpWindow_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\i.geraskin\Documents\GitHub\RibbonTabOpen\RibbonTabOpen\html\help.html");
            webBrowser1.DocumentStream = sr.BaseStream;
        }
    }
}
