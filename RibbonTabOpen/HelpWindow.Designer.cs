namespace RibbonTabOpen
{
    partial class HelpWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Содержание");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Назначение программы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Графический интерфейс пользователя");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Инструкция по эксплуатации");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Программа расчета обогрева скважины", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Указатель");
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(248, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(548, 422);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел2";
            treeNode1.Text = "Содержание";
            treeNode1.ToolTipText = "общее содержание справки";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Назначение программы";
            treeNode3.Name = "Узел2";
            treeNode3.Text = "Графический интерфейс пользователя";
            treeNode4.Name = "Узел3";
            treeNode4.Text = "Инструкция по эксплуатации";
            treeNode5.Name = "Узел0";
            treeNode5.Text = "Программа расчета обогрева скважины";
            treeNode6.Name = "Узел4";
            treeNode6.Text = "Указатель";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(250, 422);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = "Содержание";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RibbonTabOpen.Properties.Resources.Apply_16x16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "нажмите чтобы показать справку";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpWindow";
            this.Text = " Расчет обогрева скважины Помощь";
            this.Load += new System.EventHandler(this.HelpWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}