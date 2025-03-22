namespace CadastroCliente
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
            textNome = new TextBox();
            textBoxEmail = new TextBox();
            maskedTextData = new MaskedTextBox();
            maskedTextTele = new MaskedTextBox();
            comboBoxGenero = new ComboBox();
            textBoxNomeSocial = new TextBox();
            comboBoxEtnia = new ComboBox();
            checkBoxEST = new CheckBox();
            radioButtonPF = new RadioButton();
            Nome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButtonPJ = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            textBoxLogradouro = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBoxNumero = new TextBox();
            label12 = new Label();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBoxMunicipio = new TextBox();
            label15 = new Label();
            comboBoxEstado = new ComboBox();
            label16 = new Label();
            maskedTextBoxCEP = new MaskedTextBox();
            buttonCadastro = new Button();
            mensagem = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(107, 24);
            textNome.Name = "textNome";
            textNome.Size = new Size(190, 23);
            textNome.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(107, 81);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(190, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // maskedTextData
            // 
            maskedTextData.Location = new Point(537, 24);
            maskedTextData.Mask = "00/00/0000";
            maskedTextData.Name = "maskedTextData";
            maskedTextData.Size = new Size(78, 23);
            maskedTextData.TabIndex = 2;
            maskedTextData.ValidatingType = typeof(DateTime);
            // 
            // maskedTextTele
            // 
            maskedTextTele.Location = new Point(107, 53);
            maskedTextTele.Mask = "(99) 00000-0000";
            maskedTextTele.Name = "maskedTextTele";
            maskedTextTele.Size = new Size(190, 23);
            maskedTextTele.TabIndex = 3;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Feminio", "Masculino", "Outros" });
            comboBoxGenero.Location = new Point(537, 144);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(135, 23);
            comboBoxGenero.TabIndex = 4;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(107, 110);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(190, 23);
            textBoxNomeSocial.TabIndex = 5;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Preto", "Branco", "Outros" });
            comboBoxEtnia.Location = new Point(107, 139);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(135, 23);
            comboBoxEtnia.TabIndex = 6;
            // 
            // checkBoxEST
            // 
            checkBoxEST.AutoSize = true;
            checkBoxEST.Location = new Point(537, 86);
            checkBoxEST.Name = "checkBoxEST";
            checkBoxEST.Size = new Size(15, 14);
            checkBoxEST.TabIndex = 7;
            checkBoxEST.UseVisualStyleBackColor = true;
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.Checked = true;
            radioButtonPF.Location = new Point(104, 52);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(38, 19);
            radioButtonPF.TabIndex = 8;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "PF";
            radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(29, 26);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 9;
            Nome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 28);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 10;
            label1.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 85);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 12;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 144);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 13;
            label4.Text = "Gênero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 115);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 14;
            label5.Text = "Nome Social";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 147);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 15;
            label6.Text = "Etnia";
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.Location = new Point(104, 20);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(35, 19);
            radioButtonPJ.TabIndex = 16;
            radioButtonPJ.Text = "PJ";
            radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 37);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 17;
            label7.Text = "Tipo de Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 85);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 19;
            label8.Text = "Estrangeiro";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(107, 210);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(190, 23);
            textBoxLogradouro.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 213);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 22;
            label10.Text = "Logradouro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 242);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 24;
            label11.Text = "Numero";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(107, 239);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(70, 23);
            textBoxNumero.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 271);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 26;
            label12.Text = "Complemento";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(107, 268);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(190, 23);
            textBoxComplemento.TabIndex = 25;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(107, 297);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(190, 23);
            textBoxBairro.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 300);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 28;
            label13.Text = "Bairro";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 329);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 30;
            label14.Text = "Municipio";
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(107, 326);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(190, 23);
            textBoxMunicipio.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(22, 363);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 32;
            label15.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC ", "AL ", "AP ", "AM ", "BA ", "CE ", "DF ", "ES ", "GO ", "MA ", "MT ", "MS ", "MG ", "PA ", "PB ", "PR ", "PE ", "PI ", "RJ ", "RN ", "RS ", "RO ", "RR ", "SC ", "SP ", "SE ", "TO" });
            comboBoxEstado.Location = new Point(107, 355);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(99, 23);
            comboBoxEstado.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(480, 218);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 34;
            label16.Text = "CEP";
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(534, 210);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(190, 23);
            maskedTextBoxCEP.TabIndex = 33;
            // 
            // buttonCadastro
            // 
            buttonCadastro.Location = new Point(367, 401);
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.Size = new Size(75, 23);
            buttonCadastro.TabIndex = 35;
            buttonCadastro.Text = "Cadastrar";
            buttonCadastro.UseVisualStyleBackColor = true;
            buttonCadastro.Click += buttonCadastro_Click;
            // 
            // mensagem
            // 
            mensagem.AutoSize = true;
            mensagem.Location = new Point(442, 125);
            mensagem.Name = "mensagem";
            mensagem.Size = new Size(0, 15);
            mensagem.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonPJ);
            groupBox1.Controls.Add(radioButtonPF);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(596, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 77);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(537, 271);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(mensagem);
            Controls.Add(buttonCadastro);
            Controls.Add(label16);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(label15);
            Controls.Add(comboBoxEstado);
            Controls.Add(label14);
            Controls.Add(textBoxMunicipio);
            Controls.Add(label13);
            Controls.Add(textBoxBairro);
            Controls.Add(label12);
            Controls.Add(textBoxComplemento);
            Controls.Add(label11);
            Controls.Add(textBoxNumero);
            Controls.Add(label10);
            Controls.Add(textBoxLogradouro);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nome);
            Controls.Add(checkBoxEST);
            Controls.Add(comboBoxEtnia);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(comboBoxGenero);
            Controls.Add(maskedTextTele);
            Controls.Add(maskedTextData);
            Controls.Add(textBoxEmail);
            Controls.Add(textNome);
            Name = "Form1";
            Text = "Ficha Cadastral";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textBoxEmail;
        private MaskedTextBox maskedTextData;
        private MaskedTextBox maskedTextTele;
        private ComboBox comboBoxGenero;
        private TextBox textBoxNomeSocial;
        private ComboBox comboBoxEtnia;
        private CheckBox checkBoxEST;
        private RadioButton radioButtonPF;
        private Label Nome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radioButtonPJ;
        private Label label7;
        private Label label8;
        private TextBox textBoxLogradouro;
        private Label label10;
        private Label label11;
        private TextBox textBoxNumero;
        private Label label12;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private Label label13;
        private Label label14;
        private TextBox textBoxMunicipio;
        private Label label15;
        private ComboBox comboBoxEstado;
        private Label label16;
        private MaskedTextBox maskedTextBoxCEP;
        private Button buttonCadastro;
        private Label mensagem;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}
