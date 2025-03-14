namespace Calculadora
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
            button1 = new Button();
            lbl11 = new TextBox();
            lbl2 = new TextBox();
            label1 = new Label();
            resultado = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            quadradoRetanguloToolStripMenuItem = new ToolStripMenuItem();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            circunferenciasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(112, 74);
            button1.Name = "button1";
            button1.Size = new Size(28, 24);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl11
            // 
            lbl11.Location = new Point(112, 47);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(57, 23);
            lbl11.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.Location = new Point(194, 48);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(57, 23);
            lbl2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 24);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "CALCULADORA";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(258, 52);
            resultado.Name = "resultado";
            resultado.Size = new Size(15, 15);
            resultado.TabIndex = 4;
            resultado.Text = "=";
            // 
            // button2
            // 
            button2.Location = new Point(142, 100);
            button2.Name = "button2";
            button2.Size = new Size(27, 25);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(112, 100);
            button3.Name = "button3";
            button3.Size = new Size(29, 25);
            button3.TabIndex = 6;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(142, 74);
            button4.Name = "button4";
            button4.Size = new Size(27, 24);
            button4.TabIndex = 7;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(392, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, quadradoRetanguloToolStripMenuItem, circunferenciasToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "new";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // quadradoRetanguloToolStripMenuItem
            // 
            quadradoRetanguloToolStripMenuItem.Name = "quadradoRetanguloToolStripMenuItem";
            quadradoRetanguloToolStripMenuItem.Size = new Size(180, 22);
            quadradoRetanguloToolStripMenuItem.Text = "Perimetros";
            quadradoRetanguloToolStripMenuItem.Click += quadradoRetanguloToolStripMenuItem_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(194, 81);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Soma";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(194, 106);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Subtração";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(194, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Divisão";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(194, 156);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(97, 19);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "Multiplicação";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 51);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 13;
            label2.Text = "   ";
            // 
            // circunferenciasToolStripMenuItem
            // 
            circunferenciasToolStripMenuItem.Name = "circunferenciasToolStripMenuItem";
            circunferenciasToolStripMenuItem.Size = new Size(180, 22);
            circunferenciasToolStripMenuItem.Text = "Circunferencias";
            circunferenciasToolStripMenuItem.Click += circunferenciasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 450);
            Controls.Add(label2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(resultado);
            Controls.Add(label1);
            Controls.Add(lbl2);
            Controls.Add(lbl11);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox lbl11;
        private TextBox lbl2;
        private Label label1;
        private Label resultado;
        private Button button2;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private ToolStripMenuItem quadradoRetanguloToolStripMenuItem;
        private ToolStripMenuItem circunferenciasToolStripMenuItem;
    }
}
