namespace One_pawn_with_sword_at_the_board
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 238);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 64);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Здоров'я : 20 ОЗ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 79);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Атака : 3 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 94);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 3;
            label3.Text = "Досвід : 0 XP із 100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 9);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Рівень : 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 94);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 5;
            label5.Text = "Броня : нічого";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 79);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 6;
            label6.Text = "Зброя : нічого";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 64);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 7;
            label7.Text = "Карти (гроші) : 0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 109);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 8;
            label8.Text = "Магія : 1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(406, 72);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 304);
            listBox1.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(297, 9);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 10;
            label9.Text = "Фішка";
            // 
            // button1
            // 
            button1.Location = new Point(116, 393);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 11;
            button1.Text = "Зробіть собі перерву";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(255, 402);
            button2.Name = "button2";
            button2.Size = new Size(112, 28);
            button2.TabIndex = 12;
            button2.Text = "Наступний хід";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(393, 402);
            button3.Name = "button3";
            button3.Size = new Size(112, 28);
            button3.TabIndex = 13;
            button3.Text = "Зберегти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(539, 402);
            button4.Name = "button4";
            button4.Size = new Size(112, 28);
            button4.TabIndex = 14;
            button4.Text = "Завершити гру";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox listBox1;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
