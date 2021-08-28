
namespace BibliotecaWSP.View
{
    partial class ReceberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceberForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.livrosADevolverDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataParaDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.codAlunoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.confirmarLivroButton = new System.Windows.Forms.Button();
            this.localizarAlunoButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.receberButton = new System.Windows.Forms.Button();
            this.multaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosADevolverDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 14);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.livrosADevolverDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.codAlunoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.matriculaMaskedTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.confirmarLivroButton);
            this.splitContainer1.Panel1.Controls.Add(this.localizarAlunoButton);
            this.splitContainer1.Panel1.Controls.Add(this.nomeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.livrosDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(594, 343);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // livrosADevolverDataGridView
            // 
            this.livrosADevolverDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.livrosADevolverDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.livrosADevolverDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.livrosADevolverDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.ISBN,
            this.Titulo,
            this.DataEmprestimo,
            this.DataParaDevolucao,
            this.DataDevolucao});
            this.livrosADevolverDataGridView.Location = new System.Drawing.Point(4, 135);
            this.livrosADevolverDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.livrosADevolverDataGridView.Name = "livrosADevolverDataGridView";
            this.livrosADevolverDataGridView.RowHeadersVisible = false;
            this.livrosADevolverDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.livrosADevolverDataGridView.Size = new System.Drawing.Size(285, 114);
            this.livrosADevolverDataGridView.TabIndex = 10;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código do livro";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 114;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 57;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 62;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.DataPropertyName = "DataEmprestimo";
            this.DataEmprestimo.HeaderText = "Data de empréstimo";
            this.DataEmprestimo.Name = "DataEmprestimo";
            this.DataEmprestimo.Width = 139;
            // 
            // DataParaDevolucao
            // 
            this.DataParaDevolucao.DataPropertyName = "DataParaDevolucao";
            this.DataParaDevolucao.HeaderText = "Data para Devolução";
            this.DataParaDevolucao.Name = "DataParaDevolucao";
            this.DataParaDevolucao.Width = 141;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.DataPropertyName = "DataDevolucao";
            this.DataDevolucao.HeaderText = "Data de devolução";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.Width = 130;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nome:";
            // 
            // codAlunoTextBox
            // 
            this.codAlunoTextBox.Enabled = false;
            this.codAlunoTextBox.Location = new System.Drawing.Point(101, 13);
            this.codAlunoTextBox.Name = "codAlunoTextBox";
            this.codAlunoTextBox.Size = new System.Drawing.Size(59, 23);
            this.codAlunoTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(6, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecione os livros que você vai \r\ndevolver e clique no botão \r\nCONFIRMAR, depois" +
    " clique em \r\nRECEBER...\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Livros à devolver:";
            // 
            // matriculaMaskedTextBox
            // 
            this.matriculaMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matriculaMaskedTextBox.Location = new System.Drawing.Point(80, 60);
            this.matriculaMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.matriculaMaskedTextBox.Mask = "99-99999";
            this.matriculaMaskedTextBox.Name = "matriculaMaskedTextBox";
            this.matriculaMaskedTextBox.Size = new System.Drawing.Size(131, 23);
            this.matriculaMaskedTextBox.TabIndex = 2;
            this.matriculaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.matriculaMaskedTextBox.Leave += new System.EventHandler(this.matriculaMaskedTextBox_Leave);
            // 
            // confirmarLivroButton
            // 
            this.confirmarLivroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmarLivroButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_seta_para_a_frente_30;
            this.confirmarLivroButton.Location = new System.Drawing.Point(203, 256);
            this.confirmarLivroButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmarLivroButton.Name = "confirmarLivroButton";
            this.confirmarLivroButton.Size = new System.Drawing.Size(86, 81);
            this.confirmarLivroButton.TabIndex = 3;
            this.confirmarLivroButton.Text = "&Confirmar";
            this.confirmarLivroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.confirmarLivroButton.UseVisualStyleBackColor = true;
            this.confirmarLivroButton.Click += new System.EventHandler(this.confirmarLivroButton_Click);
            // 
            // localizarAlunoButton
            // 
            this.localizarAlunoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarAlunoButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_localizar_e_substituir_48;
            this.localizarAlunoButton.Location = new System.Drawing.Point(222, 3);
            this.localizarAlunoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localizarAlunoButton.Name = "localizarAlunoButton";
            this.localizarAlunoButton.Size = new System.Drawing.Size(68, 81);
            this.localizarAlunoButton.TabIndex = 3;
            this.localizarAlunoButton.Text = "Loc&alizar";
            this.localizarAlunoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarAlunoButton.UseVisualStyleBackColor = true;
            this.localizarAlunoButton.Click += new System.EventHandler(this.localizarAlunoButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.Location = new System.Drawing.Point(80, 90);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(209, 23);
            this.nomeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno:";
            // 
            // livrosDataGridView
            // 
            this.livrosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.livrosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.livrosDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.livrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.livrosDataGridView.Location = new System.Drawing.Point(4, 60);
            this.livrosDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.RowHeadersVisible = false;
            this.livrosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.livrosDataGridView.Size = new System.Drawing.Size(283, 189);
            this.livrosDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código do livro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 114;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Título";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 62;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataEmprestimo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de empréstimo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 139;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataParaDevolucao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data para Devolução";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 141;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data de devolução";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(14, 275);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data da devolução:";
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDevolucaoDateTimePicker.Enabled = false;
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(16, 297);
            this.dataDevolucaoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(259, 23);
            this.dataDevolucaoDateTimePicker.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Livro(s):";
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.Location = new System.Drawing.Point(612, 103);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(105, 27);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // receberButton
            // 
            this.receberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receberButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_seta_responder_30;
            this.receberButton.Location = new System.Drawing.Point(612, 20);
            this.receberButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.receberButton.Name = "receberButton";
            this.receberButton.Size = new System.Drawing.Size(105, 80);
            this.receberButton.TabIndex = 4;
            this.receberButton.Text = "&Receber";
            this.receberButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.receberButton.UseVisualStyleBackColor = true;
            this.receberButton.Click += new System.EventHandler(this.receberButton_Click);
            // 
            // multaButton
            // 
            this.multaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.multaButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_iniciar_transferência_de_dinheiro_60;
            this.multaButton.Location = new System.Drawing.Point(612, 260);
            this.multaButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.multaButton.Name = "multaButton";
            this.multaButton.Size = new System.Drawing.Size(105, 97);
            this.multaButton.TabIndex = 6;
            this.multaButton.Text = "Receber &Multa";
            this.multaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multaButton.UseVisualStyleBackColor = true;
            this.multaButton.Visible = false;
            this.multaButton.Click += new System.EventHandler(this.multaButton_Click);
            // 
            // ReceberForm
            // 
            this.AcceptButton = this.receberButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(728, 370);
            this.Controls.Add(this.multaButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.receberButton);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(744, 409);
            this.Name = "ReceberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber";
            this.Load += new System.EventHandler(this.ReceberForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livrosADevolverDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button receberButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox matriculaMaskedTextBox;
        private System.Windows.Forms.Button localizarAlunoButton;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
        private System.Windows.Forms.Button confirmarLivroButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox codAlunoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView livrosADevolverDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataParaDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button multaButton;
    }
}