namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.рисунок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton1.Text = "Файл";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисунок1ToolStripMenuItem,
            this.рисунок2ToolStripMenuItem,
            this.рисунок3ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton1.Text = "Рисунок";
            // 
            // рисунок1ToolStripMenuItem
            // 
            this.рисунок1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рисунок1ToolStripMenuItem.Image")));
            this.рисунок1ToolStripMenuItem.Name = "рисунок1ToolStripMenuItem";
            this.рисунок1ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.рисунок1ToolStripMenuItem.Text = "Рисунок1";
            this.рисунок1ToolStripMenuItem.Click += new System.EventHandler(this.рисунок1ToolStripMenuItem_Click);
            // 
            // рисунок2ToolStripMenuItem
            // 
            this.рисунок2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рисунок2ToolStripMenuItem.Image")));
            this.рисунок2ToolStripMenuItem.Name = "рисунок2ToolStripMenuItem";
            this.рисунок2ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.рисунок2ToolStripMenuItem.Text = "Рисунок2";
            this.рисунок2ToolStripMenuItem.Click += new System.EventHandler(this.рисунок2ToolStripMenuItem_Click);
            // 
            // рисунок3ToolStripMenuItem
            // 
            this.рисунок3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рисунок3ToolStripMenuItem.Image")));
            this.рисунок3ToolStripMenuItem.Name = "рисунок3ToolStripMenuItem";
            this.рисунок3ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.рисунок3ToolStripMenuItem.Text = "Рисунок3";
            this.рисунок3ToolStripMenuItem.Click += new System.EventHandler(this.рисунок3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 381);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem рисунок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок3ToolStripMenuItem;
    }
}

