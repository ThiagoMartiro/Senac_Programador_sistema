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
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            Resultado = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Calculadora";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(38, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(66, 90);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Resultado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(200, 65);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(12, 15);
            Resultado.TabIndex = 6;
            Resultado.Text = "?";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 61);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(38, 23);
            textBox4.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(Resultado);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label Resultado;
        private TextBox textBox4;
    }
}