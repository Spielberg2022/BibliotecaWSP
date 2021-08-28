
namespace BibliotecaWSP.View
{
    partial class EmprestarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestarForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.codAlunoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emprestimosDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.matriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.localizarAlunoButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codLivroTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dataEmprestimoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.localizarLivroButton = new System.Windows.Forms.Button();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.emprestarButton = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataParaDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(14, 14);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.codAlunoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.emprestimosDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.matriculaMaskedTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.localizarAlunoButton);
            this.splitContainer1.Panel1.Controls.Add(this.nomeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.codLivroTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.dataEmprestimoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.localizarLivroButton);
            this.splitContainer1.Panel2.Controls.Add(this.isbnTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(594, 343);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nome:";
            // 
            // codAlunoTextBox
            // 
            this.codAlunoTextBox.Enabled = false;
            this.codAlunoTextBox.Location = new System.Drawing.Point(101, 13);
            this.codAlunoTextBox.Name = "codAlunoTextBox";
            this.codAlunoTextBox.Size = new System.Drawing.Size(59, 23);
            this.codAlunoTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matrícula:";
            // 
            // emprestimosDataGridView
            // 
            this.emprestimosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emprestimosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.emprestimosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.emprestimosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.ISBN,
            this.Titulo,
            this.DataEmprestimo,
            this.DataParaDevolucao,
            this.DataDevolucao});
            this.emprestimosDataGridView.Location = new System.Drawing.Point(7, 135);
            this.emprestimosDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emprestimosDataGridView.Name = "emprestimosDataGridView";
            this.emprestimosDataGridView.RowHeadersVisible = false;
            this.emprestimosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emprestimosDataGridView.Size = new System.Drawing.Size(271, 203);
            this.emprestimosDataGridView.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Histórico:";
            // 
            // matriculaMaskedTextBox
            // 
            this.matriculaMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matriculaMaskedTextBox.Location = new System.Drawing.Point(69, 60);
            this.matriculaMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.matriculaMaskedTextBox.Mask = "99-99999";
            this.matriculaMaskedTextBox.Name = "matriculaMaskedTextBox";
            this.matriculaMaskedTextBox.Size = new System.Drawing.Size(131, 23);
            this.matriculaMaskedTextBox.TabIndex = 2;
            this.matriculaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.matriculaMaskedTextBox.Leave += new System.EventHandler(this.matriculaMaskedTextBox_Leave);
            // 
            // localizarAlunoButton
            // 
            this.localizarAlunoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarAlunoButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_localizar_e_substituir_48;
            this.localizarAlunoButton.Location = new System.Drawing.Point(211, 3);
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
            this.nomeTextBox.Location = new System.Drawing.Point(69, 90);
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
            // codLivroTextBox
            // 
            this.codLivroTextBox.Enabled = false;
            this.codLivroTextBox.Location = new System.Drawing.Point(87, 13);
            this.codLivroTextBox.Name = "codLivroTextBox";
            this.codLivroTextBox.Size = new System.Drawing.Size(59, 23);
            this.codLivroTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(28, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data para devolução:";
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(28, 297);
            this.dataDevolucaoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(259, 23);
            this.dataDevolucaoDateTimePicker.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(28, 230);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Data do empréstimo:";
            // 
            // dataEmprestimoDateTimePicker
            // 
            this.dataEmprestimoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEmprestimoDateTimePicker.Enabled = false;
            this.dataEmprestimoDateTimePicker.Location = new System.Drawing.Point(28, 246);
            this.dataEmprestimoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataEmprestimoDateTimePicker.Name = "dataEmprestimoDateTimePicker";
            this.dataEmprestimoDateTimePicker.Size = new System.Drawing.Size(259, 23);
            this.dataEmprestimoDateTimePicker.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tituloTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.autorTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(266, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmar livro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(7, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Autor(es):";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.tituloTextBox.Location = new System.Drawing.Point(10, 82);
            this.tituloTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(247, 20);
            this.tituloTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Título:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autorTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.autorTextBox.Location = new System.Drawing.Point(10, 37);
            this.autorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(247, 20);
            this.autorTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "ISBN:";
            // 
            // localizarLivroButton
            // 
            this.localizarLivroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarLivroButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_localizar_e_substituir_48;
            this.localizarLivroButton.Location = new System.Drawing.Point(224, 3);
            this.localizarLivroButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localizarLivroButton.Name = "localizarLivroButton";
            this.localizarLivroButton.Size = new System.Drawing.Size(68, 81);
            this.localizarLivroButton.TabIndex = 3;
            this.localizarLivroButton.Text = "&Localizar";
            this.localizarLivroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarLivroButton.UseVisualStyleBackColor = true;
            this.localizarLivroButton.Click += new System.EventHandler(this.localizarLivroButton_Click);
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isbnTextBox.Location = new System.Drawing.Point(68, 60);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(145, 23);
            this.isbnTextBox.TabIndex = 2;
            this.isbnTextBox.Leave += new System.EventHandler(this.isbnTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Livro:";
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.Location = new System.Drawing.Point(615, 102);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(105, 27);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emprestarButton
            // 
            this.emprestarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emprestarButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_seta_para_a_frente_30;
            this.emprestarButton.Location = new System.Drawing.Point(615, 20);
            this.emprestarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emprestarButton.Name = "emprestarButton";
            this.emprestarButton.Size = new System.Drawing.Size(105, 80);
            this.emprestarButton.TabIndex = 1;
            this.emprestarButton.Text = "&Emprestar";
            this.emprestarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emprestarButton.UseVisualStyleBackColor = true;
            this.emprestarButton.Click += new System.EventHandler(this.emprestarButton_Click);
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
            // EmprestarForm
            // 
            this.AcceptButton = this.emprestarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(728, 370);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.emprestarButton);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(744, 409);
            this.Name = "EmprestarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestar";
            this.Load += new System.EventHandler(this.EmprestarForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button localizarAlunoButton;
        private System.Windows.Forms.DataGridView emprestimosDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox matriculaMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button localizarLivroButton;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.DateTimePicker dataEmprestimoDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button emprestarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox codAlunoTextBox;
        private System.Windows.Forms.TextBox codLivroTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataParaDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
    }
}