namespace Calculadora
{
    partial class Form3
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            raioTextBox = new TextBox();
            button1 = new Button();
            resultadoLabel = new Label();
            menuStrip1 = new MenuStrip();
            esferaToolStripMenuItem = new ToolStripMenuItem();
            quadradoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(5, 66);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Perimetro";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(5, 141);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Volume";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(5, 116);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Diametro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(5, 91);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(49, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Area";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // raioTextBox
            // 
            raioTextBox.Location = new Point(2, 27);
            raioTextBox.Name = "raioTextBox";
            raioTextBox.Size = new Size(114, 23);
            raioTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(29, 187);
            button1.Name = "button1";
            button1.Size = new Size(135, 26);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Location = new Point(122, 31);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(15, 15);
            resultadoLabel.TabIndex = 6;
            resultadoLabel.Text = "=";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { esferaToolStripMenuItem, quadradoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(194, 24);
            menuStrip1.TabIndex = 16;
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
            quadradoToolStripMenuItem.Size = new Size(72, 20);
            quadradoToolStripMenuItem.Text = "Quadrado";
            quadradoToolStripMenuItem.Click += quadradoToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 291);
            Controls.Add(menuStrip1);
            Controls.Add(resultadoLabel);
            Controls.Add(button1);
            Controls.Add(raioTextBox);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox raioTextBox;
        private Button button1;
        private Label resultadoLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem esferaToolStripMenuItem;
        private ToolStripMenuItem quadradoToolStripMenuItem;
    }
}