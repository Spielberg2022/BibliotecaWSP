
namespace BibliotecaWSP.View
{
    partial class CadAlunosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAlunosForm));
            this.alunoLabel = new System.Windows.Forms.Label();
            this.alunoGroupBox = new System.Windows.Forms.GroupBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.matriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.observacaoLabel = new System.Windows.Forms.Label();
            this.localizarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.alunoPictureBox = new System.Windows.Forms.PictureBox();
            this.alunoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // alunoLabel
            // 
            this.alunoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.alunoLabel.AutoSize = true;
            this.alunoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alunoLabel.Location = new System.Drawing.Point(369, 10);
            this.alunoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alunoLabel.Name = "alunoLabel";
            this.alunoLabel.Size = new System.Drawing.Size(94, 33);
            this.alunoLabel.TabIndex = 0;
            this.alunoLabel.Text = "Aluno";
            // 
            // alunoGroupBox
            // 
            this.alunoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alunoGroupBox.Controls.Add(this.celularMaskedTextBox);
            this.alunoGroupBox.Controls.Add(this.label10);
            this.alunoGroupBox.Controls.Add(this.label11);
            this.alunoGroupBox.Controls.Add(this.matriculaMaskedTextBox);
            this.alunoGroupBox.Controls.Add(this.cpfMaskedTextBox);
            this.alunoGroupBox.Controls.Add(this.nomeTextBox);
            this.alunoGroupBox.Controls.Add(this.codigoTextBox);
            this.alunoGroupBox.Controls.Add(this.groupBox1);
            this.alunoGroupBox.Controls.Add(this.label4);
            this.alunoGroupBox.Controls.Add(this.label3);
            this.alunoGroupBox.Controls.Add(this.label2);
            this.alunoGroupBox.Controls.Add(this.label1);
            this.alunoGroupBox.Location = new System.Drawing.Point(144, 57);
            this.alunoGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alunoGroupBox.Name = "alunoGroupBox";
            this.alunoGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alunoGroupBox.Size = new System.Drawing.Size(458, 288);
            this.alunoGroupBox.TabIndex = 1;
            this.alunoGroupBox.TabStop = false;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.Location = new System.Drawing.Point(241, 115);
            this.celularMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.celularMaskedTextBox.Mask = "(99)9-9999,9999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.celularMaskedTextBox.TabIndex = 9;
            this.celularMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(205, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 10;
            // 
            // matriculaMaskedTextBox
            // 
            this.matriculaMaskedTextBox.Location = new System.Drawing.Point(96, 57);
            this.matriculaMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.matriculaMaskedTextBox.Mask = "99-99999";
            this.matriculaMaskedTextBox.Name = "matriculaMaskedTextBox";
            this.matriculaMaskedTextBox.Size = new System.Drawing.Size(116, 23);
            this.matriculaMaskedTextBox.TabIndex = 3;
            this.matriculaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(96, 117);
            this.cpfMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cpfMaskedTextBox.Mask = "999,999,999-99";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.cpfMaskedTextBox.TabIndex = 7;
            this.cpfMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cpfMaskedTextBox.Leave += new System.EventHandler(this.cpfMaskedTextBox_Leave);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(96, 87);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(347, 23);
            this.nomeTextBox.TabIndex = 5;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(96, 27);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(60, 23);
            this.codigoTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(this.logradouroTextBox);
            this.groupBox1.Controls.Add(this.ufComboBox);
            this.groupBox1.Controls.Add(this.cepMaskedTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(444, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(290, 61);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(146, 23);
            this.cidadeTextBox.TabIndex = 7;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(89, 61);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(144, 23);
            this.bairroTextBox.TabIndex = 5;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.Location = new System.Drawing.Point(89, 91);
            this.logradouroTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(348, 23);
            this.logradouroTextBox.TabIndex = 9;
            // 
            // ufComboBox
            // 
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC"});
            this.ufComboBox.Location = new System.Drawing.Point(290, 30);
            this.ufComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(65, 23);
            this.ufComboBox.TabIndex = 3;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.Location = new System.Drawing.Point(89, 31);
            this.cepMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cepMaskedTextBox.Mask = "99,999-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(144, 23);
            this.cepMaskedTextBox.TabIndex = 1;
            this.cepMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cepMaskedTextBox.Leave += new System.EventHandler(this.cepMaskedTextBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(54, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // observacaoLabel
            // 
            this.observacaoLabel.AutoSize = true;
            this.observacaoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.observacaoLabel.Location = new System.Drawing.Point(411, 348);
            this.observacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observacaoLabel.Name = "observacaoLabel";
            this.observacaoLabel.Size = new System.Drawing.Size(187, 15);
            this.observacaoLabel.TabIndex = 2;
            this.observacaoLabel.Text = "*Dados Obrigatórios em vermelho";
            // 
            // localizarButton
            // 
            this.localizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_localizar_e_substituir_48;
            this.localizarButton.Location = new System.Drawing.Point(612, 76);
            this.localizarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(105, 78);
            this.localizarButton.TabIndex = 3;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarButton.UseVisualStyleBackColor = true;
            this.localizarButton.Click += new System.EventHandler(this.localizarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_arquivo_16;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(612, 162);
            this.novoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(105, 27);
            this.novoButton.TabIndex = 4;
            this.novoButton.Text = "&Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirButton.Enabled = false;
            this.excluirButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_lixeira_vazia_16;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(612, 228);
            this.excluirButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(105, 27);
            this.excluirButton.TabIndex = 6;
            this.excluirButton.Text = "&Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.Enabled = false;
            this.salvarButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_salvar_16;
            this.salvarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvarButton.Location = new System.Drawing.Point(612, 195);
            this.salvarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(105, 27);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // alunoPictureBox
            // 
            this.alunoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.alunoPictureBox.Image = global::BibliotecaWSP.Properties.Resources.AlunosCadastro;
            this.alunoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.alunoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alunoPictureBox.Name = "alunoPictureBox";
            this.alunoPictureBox.Size = new System.Drawing.Size(136, 370);
            this.alunoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alunoPictureBox.TabIndex = 0;
            this.alunoPictureBox.TabStop = false;
            // 
            // CadAlunosForm
            // 
            this.AcceptButton = this.localizarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 370);
            this.Controls.Add(this.observacaoLabel);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.alunoGroupBox);
            this.Controls.Add(this.alunoLabel);
            this.Controls.Add(this.alunoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 409);
            this.MinimumSize = new System.Drawing.Size(744, 409);
            this.Name = "CadAlunosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.CadAlunosForm_Load);
            this.alunoGroupBox.ResumeLayout(false);
            this.alunoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox alunoPictureBox;
        private System.Windows.Forms.Label alunoLabel;
        private System.Windows.Forms.GroupBox alunoGroupBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox matriculaMaskedTextBox;
        private System.Windows.Forms.Label observacaoLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.Label label10;
    }
}