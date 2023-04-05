namespace zadanie4
{
    partial class Year4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выберитеФункциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разницаДатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяСутокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяФормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(216, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите год:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(405, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(181, 450);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 39);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Високосный ли год";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выберитеФункциюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выберитеФункциюToolStripMenuItem
            // 
            this.выберитеФункциюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разницаДатToolStripMenuItem,
            this.времяСутокToolStripMenuItem,
            this.главнаяФормаToolStripMenuItem});
            this.выберитеФункциюToolStripMenuItem.Name = "выберитеФункциюToolStripMenuItem";
            this.выберитеФункциюToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.выберитеФункциюToolStripMenuItem.Text = "Выберите функцию";
            // 
            // разницаДатToolStripMenuItem
            // 
            this.разницаДатToolStripMenuItem.Name = "разницаДатToolStripMenuItem";
            this.разницаДатToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.разницаДатToolStripMenuItem.Text = "Разница дат";
            this.разницаДатToolStripMenuItem.Click += new System.EventHandler(this.разницаДатToolStripMenuItem_Click);
            // 
            // времяСутокToolStripMenuItem
            // 
            this.времяСутокToolStripMenuItem.Name = "времяСутокToolStripMenuItem";
            this.времяСутокToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.времяСутокToolStripMenuItem.Text = "Время суток";
            this.времяСутокToolStripMenuItem.Click += new System.EventHandler(this.времяСутокToolStripMenuItem_Click);
            // 
            // главнаяФормаToolStripMenuItem
            // 
            this.главнаяФормаToolStripMenuItem.Name = "главнаяФормаToolStripMenuItem";
            this.главнаяФормаToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.главнаяФормаToolStripMenuItem.Text = "Главная форма";
            this.главнаяФормаToolStripMenuItem.Click += new System.EventHandler(this.главнаяФормаToolStripMenuItem_Click_1);
            // 
            // Year4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Year4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выберитеФункциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разницаДатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяСутокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяФормаToolStripMenuItem;
    }
}