namespace listaatividades
{
    partial class CriarAtividade
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
            buttonDescartar = new Button();
            buttonCriar = new Button();
            labelTitulo = new Label();
            textBoxTitulo = new TextBox();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(166, 188);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(75, 23);
            buttonDescartar.TabIndex = 0;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            buttonDescartar.Click += buttonDescartar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(247, 188);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 1;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(225, 141);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(37, 15);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(198, 159);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 3;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(32, 402);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(19, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = "    ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(buttonCriar);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Controls.Add(buttonDescartar);
            groupBox1.Location = new Point(4, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 433);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "  ";
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDescartar;
        private Button buttonCriar;
        private Label labelTitulo;
        private TextBox textBoxTitulo;
        private Label labelErro;
        private GroupBox groupBox1;
    }
}