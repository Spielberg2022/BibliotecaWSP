
namespace BibliotecaWSP.View
{
    partial class CadLivrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLivrosForm));
            this.livroGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.anoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.disponíveisTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.qtdTotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.livroLabel = new System.Windows.Forms.Label();
            this.observacaoLabel = new System.Windows.Forms.Label();
            this.novoButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.livroPictureBox = new System.Windows.Forms.PictureBox();
            this.livroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // livroGroupBox
            // 
            this.livroGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.livroGroupBox.Controls.Add(this.label10);
            this.livroGroupBox.Controls.Add(this.label9);
            this.livroGroupBox.Controls.Add(this.anoMaskedTextBox);
            this.livroGroupBox.Controls.Add(this.disponíveisTextBox);
            this.livroGroupBox.Controls.Add(this.editoraTextBox);
            this.livroGroupBox.Controls.Add(this.tituloTextBox);
            this.livroGroupBox.Controls.Add(this.autorTextBox);
            this.livroGroupBox.Controls.Add(this.isbnTextBox);
            this.livroGroupBox.Controls.Add(this.codigoTextBox);
            this.livroGroupBox.Controls.Add(this.qtdTotalTextBox);
            this.livroGroupBox.Controls.Add(this.label8);
            this.livroGroupBox.Controls.Add(this.label7);
            this.livroGroupBox.Controls.Add(this.label6);
            this.livroGroupBox.Controls.Add(this.label5);
            this.livroGroupBox.Controls.Add(this.label4);
            this.livroGroupBox.Controls.Add(this.label3);
            this.livroGroupBox.Controls.Add(this.label2);
            this.livroGroupBox.Controls.Add(this.label1);
            this.livroGroupBox.Location = new System.Drawing.Point(149, 57);
            this.livroGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.livroGroupBox.Name = "livroGroupBox";
            this.livroGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.livroGroupBox.Size = new System.Drawing.Size(458, 288);
            this.livroGroupBox.TabIndex = 1;
            this.livroGroupBox.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(40, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "--->   SOBRENOME, Nome; SOBRENOME, Nome ...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(33, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cadastrar Autores no seguinte padrão:";
            // 
            // anoMaskedTextBox
            // 
            this.anoMaskedTextBox.Location = new System.Drawing.Point(80, 210);
            this.anoMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.anoMaskedTextBox.Mask = "9000";
            this.anoMaskedTextBox.Name = "anoMaskedTextBox";
            this.anoMaskedTextBox.Size = new System.Drawing.Size(69, 23);
            this.anoMaskedTextBox.TabIndex = 11;
            // 
            // disponíveisTextBox
            // 
            this.disponíveisTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.disponíveisTextBox.Location = new System.Drawing.Point(382, 247);
            this.disponíveisTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.disponíveisTextBox.Name = "disponíveisTextBox";
            this.disponíveisTextBox.Size = new System.Drawing.Size(69, 23);
            this.disponíveisTextBox.TabIndex = 16;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.Location = new System.Drawing.Point(80, 180);
            this.editoraTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(370, 23);
            this.editoraTextBox.TabIndex = 9;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(80, 150);
            this.tituloTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(370, 23);
            this.tituloTextBox.TabIndex = 7;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(80, 89);
            this.autorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(370, 23);
            this.autorTextBox.TabIndex = 5;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(80, 59);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(156, 23);
            this.isbnTextBox.TabIndex = 3;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(80, 29);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(69, 23);
            this.codigoTextBox.TabIndex = 1;
            // 
            // qtdTotalTextBox
            // 
            this.qtdTotalTextBox.Location = new System.Drawing.Point(206, 247);
            this.qtdTotalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qtdTotalTextBox.Name = "qtdTotalTextBox";
            this.qtdTotalTextBox.Size = new System.Drawing.Size(69, 23);
            this.qtdTotalTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(296, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Disponíveis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantidade Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Editora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor(es):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // livroLabel
            // 
            this.livroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.livroLabel.AutoSize = true;
            this.livroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.livroLabel.Location = new System.Drawing.Point(374, 10);
            this.livroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.livroLabel.Name = "livroLabel";
            this.livroLabel.Size = new System.Drawing.Size(84, 33);
            this.livroLabel.TabIndex = 0;
            this.livroLabel.Text = "Livro";
            // 
            // observacaoLabel
            // 
            this.observacaoLabel.AutoSize = true;
            this.observacaoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.observacaoLabel.Location = new System.Drawing.Point(416, 348);
            this.observacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observacaoLabel.Name = "observacaoLabel";
            this.observacaoLabel.Size = new System.Drawing.Size(187, 15);
            this.observacaoLabel.TabIndex = 2;
            this.observacaoLabel.Text = "*Dados Obrigatórios em vermelho";
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_arquivo_16;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(616, 162);
            this.novoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(105, 27);
            this.novoButton.TabIndex = 4;
            this.novoButton.Text = "&Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // localizarButton
            // 
            this.localizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_localizar_e_substituir_48;
            this.localizarButton.Location = new System.Drawing.Point(616, 76);
            this.localizarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(105, 78);
            this.localizarButton.TabIndex = 3;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarButton.UseVisualStyleBackColor = true;
            this.localizarButton.Click += new System.EventHandler(this.localizarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirButton.Enabled = false;
            this.excluirButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_lixeira_vazia_16;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(616, 228);
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
            this.salvarButton.Location = new System.Drawing.Point(616, 195);
            this.salvarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(105, 27);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // livroPictureBox
            // 
            this.livroPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.livroPictureBox.Image = global::BibliotecaWSP.Properties.Resources.biblioteca_sobre1;
            this.livroPictureBox.Location = new System.Drawing.Point(0, 0);
            this.livroPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.livroPictureBox.Name = "livroPictureBox";
            this.livroPictureBox.Size = new System.Drawing.Size(136, 370);
            this.livroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livroPictureBox.TabIndex = 9;
            this.livroPictureBox.TabStop = false;
            // 
            // CadLivrosForm
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
            this.Controls.Add(this.livroGroupBox);
            this.Controls.Add(this.livroLabel);
            this.Controls.Add(this.livroPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 409);
            this.MinimumSize = new System.Drawing.Size(744, 409);
            this.Name = "CadLivrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.CadLivrosForm_Load);
            this.livroGroupBox.ResumeLayout(false);
            this.livroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.GroupBox livroGroupBox;
        private System.Windows.Forms.Label livroLabel;
        private System.Windows.Forms.PictureBox livroPictureBox;
        private System.Windows.Forms.Label observacaoLabel;
        private System.Windows.Forms.TextBox disponíveisTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox qtdTotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox anoMaskedTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}