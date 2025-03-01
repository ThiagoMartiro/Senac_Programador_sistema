namespace Login
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
            Entrar = new Button();
            TxtSenha = new TextBox();
            TxtUsuario = new TextBox();
            Usuário = new Label();
            Senha = new Label();
            LbResultado = new Label();
            New = new Button();
            Newus = new TextBox();
            Novasenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            resultado = new Label();
            SuspendLayout();
            // 
            // Entrar
            // 
            Entrar.Location = new Point(383, 241);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 23);
            Entrar.TabIndex = 0;
            Entrar.Text = "Cadastro";
            Entrar.UseVisualStyleBackColor = true;
            Entrar.Click += Entrar_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(337, 214);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(159, 23);
            TxtSenha.TabIndex = 1;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(337, 180);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(159, 23);
            TxtUsuario.TabIndex = 2;
            // 
            // Usuário
            // 
            Usuário.AutoSize = true;
            Usuário.Location = new Point(274, 188);
            Usuário.Name = "Usuário";
            Usuário.Size = new Size(47, 15);
            Usuário.TabIndex = 3;
            Usuário.Text = "Usuário";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(274, 229);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 4;
            Senha.Text = "Senha";
            // 
            // LbResultado
            // 
            LbResultado.AutoSize = true;
            LbResultado.Location = new Point(34, 48);
            LbResultado.Name = "LbResultado";
            LbResultado.Size = new Size(0, 15);
            LbResultado.TabIndex = 5;
            // 
            // New
            // 
            New.Location = new Point(817, 238);
            New.Name = "New";
            New.Size = new Size(75, 26);
            New.TabIndex = 6;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Newus
            // 
            Newus.Location = new Point(768, 180);
            Newus.Name = "Newus";
            Newus.Size = new Size(162, 23);
            Newus.TabIndex = 7;
            // 
            // Novasenha
            // 
            Novasenha.Location = new Point(768, 209);
            Novasenha.Name = "Novasenha";
            Novasenha.Size = new Size(162, 23);
            Novasenha.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 217);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(703, 183);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 10;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(813, 150);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 11;
            label3.Text = "Novo Usuário";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(828, 315);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 450);
            Controls.Add(resultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Novasenha);
            Controls.Add(Newus);
            Controls.Add(New);
            Controls.Add(LbResultado);
            Controls.Add(Senha);
            Controls.Add(Usuário);
            Controls.Add(TxtUsuario);
            Controls.Add(TxtSenha);
            Controls.Add(Entrar);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Entrar;
        private TextBox TxtSenha;
        private TextBox TxtUsuario;
        private Label Usuário;
        private Label Senha;
        private Label LbResultado;
        private Button New;
        private TextBox Newus;
        private TextBox Novasenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label resultado;
    }
}
