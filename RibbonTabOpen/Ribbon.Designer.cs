namespace RibbonTabOpen
{
    partial class Ribbon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem3 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem5 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonButton12 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton15 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton16 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton17 = new System.Windows.Forms.RibbonButton();
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton9 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton10 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton11 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton13 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton14 = new System.Windows.Forms.RibbonButton();
            this.OpenButton = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Text = "Инструменты";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonButton1);
            this.ribbonPanel2.Text = "Данные";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = global::RibbonTabOpen.Properties.Resources.data1;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Ввод данных";
            this.ribbonButton1.ToolTip = "Ввод анкетных данных";
            this.ribbonButton1.Click += new System.EventHandler(this.Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton2);
            this.ribbonPanel3.Text = "Расчет";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::RibbonTabOpen.Properties.Resources.run1;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Пуск";
            this.ribbonButton2.ToolTip = "Запуск расчета";
            this.ribbonButton2.Click += new System.EventHandler(this.Click_Start);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.ribbonButton3);
            this.ribbonPanel4.Items.Add(this.ribbonButton4);
            this.ribbonPanel4.Items.Add(this.ribbonButton5);
            this.ribbonPanel4.Items.Add(this.ribbonButton6);
            this.ribbonPanel4.Text = "Обработка результатов";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::RibbonTabOpen.Properties.Resources.report;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Создать отчет";
            this.ribbonButton3.ToolTip = "Создать отчет";
            this.ribbonButton3.Click += new System.EventHandler(this.Click_Report);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = global::RibbonTabOpen.Properties.Resources.open;
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "Просмотр отчета";
            this.ribbonButton4.ToolTip = "Просмотр отчета";
            this.ribbonButton4.Click += new System.EventHandler(this.Click_Viewer);
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = global::RibbonTabOpen.Properties.Resources.plot;
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "График";
            this.ribbonButton5.ToolTip = "Построить результирующий график";
            this.ribbonButton5.Click += new System.EventHandler(this.Click_Plot);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = global::RibbonTabOpen.Properties.Resources.print2;
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "Печать отчета";
            this.ribbonButton6.ToolTip = "Напечатать отчет";
            this.ribbonButton6.Click += new System.EventHandler(this.Click_Print);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel5);
            this.ribbonTab2.Text = "Справка";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton7);
            this.ribbonPanel5.Text = "Информация";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = global::RibbonTabOpen.Properties.Resources.help;
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "Помощь";
            this.ribbonButton7.ToolTip = "Вызов Помощи";
            this.ribbonButton7.Click += new System.EventHandler(this.Click_Help);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = null;
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem3);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem5);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItems.Add(this.ribbonOrbRecentItem1);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "Главная";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Checked = true;
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton12);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton15);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton16);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton17);
            this.ribbon1.QuickAcessToolbar.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(424, 170);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            this.ribbon1.Click += new System.EventHandler(this.Ribbon1_Click);
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = global::RibbonTabOpen.Properties.Resources.Open_32x32;
            this.ribbonOrbMenuItem1.SmallImage = global::RibbonTabOpen.Properties.Resources.Open_32x32;
            this.ribbonOrbMenuItem1.Text = "Открыть";
            this.ribbonOrbMenuItem1.ToolTip = "Открыть документ";
            this.ribbonOrbMenuItem1.Click += new System.EventHandler(this.Click_OpenRibbon);
            // 
            // ribbonOrbMenuItem3
            // 
            this.ribbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem3.Image = global::RibbonTabOpen.Properties.Resources.SaveAs_32x32;
            this.ribbonOrbMenuItem3.SmallImage = global::RibbonTabOpen.Properties.Resources.SaveAs_32x32;
            this.ribbonOrbMenuItem3.Text = "Сохранить как...";
            this.ribbonOrbMenuItem3.ToolTip = "Сохранить как";
            this.ribbonOrbMenuItem3.Click += new System.EventHandler(this.Click_SaveAs);
            // 
            // ribbonOrbMenuItem5
            // 
            this.ribbonOrbMenuItem5.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem5.Image = global::RibbonTabOpen.Properties.Resources.Close_32x32;
            this.ribbonOrbMenuItem5.SmallImage = global::RibbonTabOpen.Properties.Resources.Close_32x32;
            this.ribbonOrbMenuItem5.Text = "Выход";
            this.ribbonOrbMenuItem5.ToolTip = "Выход";
            this.ribbonOrbMenuItem5.Click += new System.EventHandler(this.Close);
            // 
            // ribbonOrbRecentItem1
            // 
            this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
            this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
            this.ribbonOrbRecentItem1.Text = "История сохранения";
            this.ribbonOrbRecentItem1.Click += new System.EventHandler(this.Click_History);
            // 
            // ribbonButton12
            // 
            this.ribbonButton12.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton12.Image")));
            this.ribbonButton12.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton12.SmallImage = global::RibbonTabOpen.Properties.Resources.Open_16x16;
            this.ribbonButton12.Text = "ribbonButton12";
            this.ribbonButton12.ToolTip = "Открыть файл";
            this.ribbonButton12.Click += new System.EventHandler(this.Click_shortcutOpen);
            // 
            // ribbonButton15
            // 
            this.ribbonButton15.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton15.Image")));
            this.ribbonButton15.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton15.SmallImage = global::RibbonTabOpen.Properties.Resources.SaveAs_16x16;
            this.ribbonButton15.Text = "ribbonButton15";
            this.ribbonButton15.ToolTip = "Сохранить файл как";
            this.ribbonButton15.Click += new System.EventHandler(this.Click_shortcutSaveAs);
            // 
            // ribbonButton16
            // 
            this.ribbonButton16.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton16.Image")));
            this.ribbonButton16.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton16.SmallImage = global::RibbonTabOpen.Properties.Resources.Undo_16x16;
            this.ribbonButton16.Text = "ribbonButton16";
            this.ribbonButton16.ToolTip = "Отменить";
            this.ribbonButton16.Click += new System.EventHandler(this.Click_Undo);
            // 
            // ribbonButton17
            // 
            this.ribbonButton17.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton17.Image")));
            this.ribbonButton17.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton17.SmallImage = global::RibbonTabOpen.Properties.Resources.Redo_16x16;
            this.ribbonButton17.Text = "ribbonButton17";
            this.ribbonButton17.ToolTip = "Вернуть";
            this.ribbonButton17.Click += new System.EventHandler(this.Click_Redo);
            // 
            // ribbonItemGroup1
            // 
            this.ribbonItemGroup1.Items.Add(this.ribbonButton8);
            this.ribbonItemGroup1.Items.Add(this.ribbonButton9);
            this.ribbonItemGroup1.Items.Add(this.ribbonButton10);
            this.ribbonItemGroup1.Items.Add(this.ribbonButton11);
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.Image")));
            this.ribbonButton9.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            // 
            // ribbonButton10
            // 
            this.ribbonButton10.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.Image")));
            this.ribbonButton10.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton10.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.SmallImage")));
            // 
            // ribbonButton11
            // 
            this.ribbonButton11.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.Image")));
            this.ribbonButton11.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton11.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.SmallImage")));
            // 
            // ribbonButton13
            // 
            this.ribbonButton13.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton13.Image")));
            this.ribbonButton13.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton13.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton13.SmallImage")));
            this.ribbonButton13.Text = "ribbonButton13";
            // 
            // ribbonButton14
            // 
            this.ribbonButton14.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton14.Image")));
            this.ribbonButton14.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton14.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton14.SmallImage")));
            this.ribbonButton14.Text = "ribbonButton14";
            // 
            // OpenButton
            // 
            this.OpenButton.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.SmallImage = global::RibbonTabOpen.Properties.Resources.Open_16x16;
            // 
            // Ribbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 180);
            this.Controls.Add(this.ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ribbon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Скважина с ЭЦН - Новый расчет";
            this.Load += new System.EventHandler(this.Ribbon_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem3;
  
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem5;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem1;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonButton ribbonButton13;
        private System.Windows.Forms.RibbonButton ribbonButton14;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.RibbonButton OpenButton;
        private System.Windows.Forms.RibbonButton ribbonButton8;
        private System.Windows.Forms.RibbonButton ribbonButton9;
        private System.Windows.Forms.RibbonButton ribbonButton10;
        private System.Windows.Forms.RibbonButton ribbonButton11;
        private System.Windows.Forms.RibbonButton ribbonButton12;
        private System.Windows.Forms.RibbonButton ribbonButton15;
        private System.Windows.Forms.RibbonButton ribbonButton16;
        private System.Windows.Forms.RibbonButton ribbonButton17;
    }
}