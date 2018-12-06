namespace RibbonTabOpen
{
    partial class AddWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оператор:";
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(93, 27);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(100, 20);
            this.textBox01.TabIndex = 1;
            this.textBox01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название месторождения:";
            // 
            // textBox02
            // 
            this.textBox02.Location = new System.Drawing.Point(179, 75);
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(100, 20);
            this.textBox02.TabIndex = 3;
            this.textBox02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер скважины:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Марка ЭЦН:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox03
            // 
            this.textBox03.Location = new System.Drawing.Point(134, 123);
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(100, 20);
            this.textBox03.TabIndex = 8;
            this.textBox03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox04
            // 
            this.textBox04.Location = new System.Drawing.Point(105, 175);
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(100, 20);
            this.textBox04.TabIndex = 9;
            this.textBox04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 270);
            this.Controls.Add(this.textBox04);
            this.Controls.Add(this.textBox03);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWindow";
            this.Text = "Данные по месторождению";
            this.Load += new System.EventHandler(this.AddWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox03;
        private System.Windows.Forms.TextBox textBox04;
        private System.Windows.Forms.Button button1;
    }
}