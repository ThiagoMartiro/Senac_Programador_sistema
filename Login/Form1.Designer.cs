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
            SuspendLayout();
            // 
            // Entrar
            // 
            Entrar.Location = new Point(380, 250);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 23);
            Entrar.TabIndex = 0;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = true;
            Entrar.Click += Entrar_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(337, 221);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
