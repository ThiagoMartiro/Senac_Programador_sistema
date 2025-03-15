namespace Calculadora
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            Resultado = new Label();
            textBox4 = new TextBox();
            menuStrip1 = new MenuStrip();
            esferaToolStripMenuItem = new ToolStripMenuItem();
            quadradoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(38, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 152);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(103, 69);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(15, 15);
            Resultado.TabIndex = 6;
            Resultado.Text = "=";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(38, 23);
            textBox4.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { esferaToolStripMenuItem, quadradoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(194, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // esferaToolStripMenuItem
            // 
            esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            esferaToolStripMenuItem.Size = new Size(82, 20);
            esferaToolStripMenuItem.Text = "Calculadora";
            esferaToolStripMenuItem.Click += esferaToolStripMenuItem_Click;
            // 
            // quadradoToolStripMenuItem
            // 
            quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            quadradoToolStripMenuItem.Size = new Size(50, 20);
            quadradoToolStripMenuItem.Text = "Esfera";
            quadradoToolStripMenuItem.Click += quadradoToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 291);
            Controls.Add(menuStrip1);
            Controls.Add(textBox4);
            Controls.Add(Resultado);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label Resultado;
        private TextBox textBox4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem esferaToolStripMenuItem;
        private ToolStripMenuItem quadradoToolStripMenuItem;
    }
}