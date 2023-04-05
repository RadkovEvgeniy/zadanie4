namespace zadanie4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выберитеФункциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разницаДатToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.високосныйЛиГодToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.времяСутокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выберитеФункциюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выберитеФункциюToolStripMenuItem
            // 
            this.выберитеФункциюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разницаДатToolStripMenuItem1,
            this.високосныйЛиГодToolStripMenuItem1,
            this.времяСутокToolStripMenuItem});
            this.выберитеФункциюToolStripMenuItem.Name = "выберитеФункциюToolStripMenuItem";
            this.выберитеФункциюToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.выберитеФункциюToolStripMenuItem.Text = "Выберите функцию";
            // 
            // разницаДатToolStripMenuItem1
            // 
            this.разницаДатToolStripMenuItem1.Name = "разницаДатToolStripMenuItem1";
            this.разницаДатToolStripMenuItem1.Size = new System.Drawing.Size(271, 34);
            this.разницаДатToolStripMenuItem1.Text = "Разница дат";
            this.разницаДатToolStripMenuItem1.Click += new System.EventHandler(this.разницаДатToolStripMenuItem1_Click);
            // 
            // високосныйЛиГодToolStripMenuItem1
            // 
            this.високосныйЛиГодToolStripMenuItem1.Name = "високосныйЛиГодToolStripMenuItem1";
            this.високосныйЛиГодToolStripMenuItem1.Size = new System.Drawing.Size(271, 34);
            this.високосныйЛиГодToolStripMenuItem1.Text = "Високосный ли год";
            this.високосныйЛиГодToolStripMenuItem1.Click += new System.EventHandler(this.високосныйЛиГодToolStripMenuItem1_Click);
            // 
            // времяСутокToolStripMenuItem
            // 
            this.времяСутокToolStripMenuItem.Name = "времяСутокToolStripMenuItem";
            this.времяСутокToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.времяСутокToolStripMenuItem.Text = "Время суток";
            this.времяСутокToolStripMenuItem.Click += new System.EventHandler(this.времяСутокToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Привет!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выберитеФункциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разницаДатToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem високосныйЛиГодToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem времяСутокToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

