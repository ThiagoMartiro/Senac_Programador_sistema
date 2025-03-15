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
            resultado = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            esferaToolStripMenuItem = new ToolStripMenuItem();
            quadradoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 116);
            button1.Name = "button1";
            button1.Size = new Size(28, 24);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl11
            // 
            lbl11.Location = new Point(29, 43);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(91, 23);
            lbl11.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.Location = new Point(29, 83);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(91, 23);
            lbl2.TabIndex = 2;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(130, 65);
            resultado.Name = "resultado";
            resultado.Size = new Size(15, 15);
            resultado.TabIndex = 4;
            resultado.Text = "=";
            // 
            // button2
            // 
            button2.Location = new Point(57, 141);
            button2.Name = "button2";
            button2.Size = new Size(27, 25);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 141);
            button3.Name = "button3";
            button3.Size = new Size(29, 25);
            button3.TabIndex = 6;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(57, 116);
            button4.Name = "button4";
            button4.Size = new Size(27, 24);
            button4.TabIndex = 7;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 184);
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
            radioButton2.Location = new Point(29, 209);
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
            radioButton3.Location = new Point(29, 234);
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
            radioButton4.Location = new Point(29, 259);
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
            label2.Location = new Point(66, 66);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 13;
            label2.Text = "   ";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { esferaToolStripMenuItem, quadradoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(194, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // esferaToolStripMenuItem
            // 
            esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            esferaToolStripMenuItem.Size = new Size(50, 20);
            esferaToolStripMenuItem.Text = "Esfera";
            esferaToolStripMenuItem.Click += esferaToolStripMenuItem_Click;
            // 
            // quadradoToolStripMenuItem
            // 
            quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            quadradoToolStripMenuItem.Size = new Size(72, 20);
            quadradoToolStripMenuItem.Text = "Quadrado";
            quadradoToolStripMenuItem.Click += quadradoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 291);
            Controls.Add(label2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(resultado);
            Controls.Add(lbl2);
            Controls.Add(lbl11);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label resultado;
        private Button button2;
        private Button button3;
        private Button button4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem esferaToolStripMenuItem;
        private ToolStripMenuItem quadradoToolStripMenuItem;
    }
}
