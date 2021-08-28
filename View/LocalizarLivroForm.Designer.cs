
namespace BibliotecaWSP.View
{
    partial class LocalizarLivroForm
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
            this.cancelarButton = new System.Windows.Forms.Button();
            this.livroTabControl = new System.Windows.Forms.TabControl();
            this.codigoTabPage = new System.Windows.Forms.TabPage();
            this.codigoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.isbnTabPage = new System.Windows.Forms.TabPage();
            this.isbnDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.autorTabPage = new System.Windows.Forms.TabPage();
            this.autorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.tituloTabPage = new System.Windows.Forms.TabPage();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.tituloDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.livroTabControl.SuspendLayout();
            this.codigoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).BeginInit();
            this.isbnTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isbnDataGridView)).BeginInit();
            this.autorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).BeginInit();
            this.tituloTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.Location = new System.Drawing.Point(509, 175);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(107, 32);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // livroTabControl
            // 
            this.livroTabControl.Controls.Add(this.codigoTabPage);
            this.livroTabControl.Controls.Add(this.isbnTabPage);
            this.livroTabControl.Controls.Add(this.autorTabPage);
            this.livroTabControl.Controls.Add(this.tituloTabPage);
            this.livroTabControl.Location = new System.Drawing.Point(14, 14);
            this.livroTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.livroTabControl.Name = "livroTabControl";
            this.livroTabControl.SelectedIndex = 0;
            this.livroTabControl.Size = new System.Drawing.Size(488, 198);
            this.livroTabControl.TabIndex = 4;
            // 
            // codigoTabPage
            // 
            this.codigoTabPage.Controls.Add(this.codigoDataGridView);
            this.codigoTabPage.Controls.Add(this.codigoTextBox);
            this.codigoTabPage.Location = new System.Drawing.Point(4, 24);
            this.codigoTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigoTabPage.Name = "codigoTabPage";
            this.codigoTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigoTabPage.Size = new System.Drawing.Size(480, 170);
            this.codigoTabPage.TabIndex = 0;
            this.codigoTabPage.Text = "Código";
            this.codigoTabPage.UseVisualStyleBackColor = true;
            // 
            // codigoDataGridView
            // 
            this.codigoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.codigoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.codigoDataGridView.Location = new System.Drawing.Point(7, 38);
            this.codigoDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigoDataGridView.MultiSelect = false;
            this.codigoDataGridView.Name = "codigoDataGridView";
            this.codigoDataGridView.ReadOnly = true;
            this.codigoDataGridView.RowHeadersVisible = false;
            this.codigoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.codigoDataGridView.Size = new System.Drawing.Size(464, 125);
            this.codigoDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn17.HeaderText = "Código";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 71;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn18.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 57;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Autores";
            this.dataGridViewTextBoxColumn19.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 62;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn20.HeaderText = "Título";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 62;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Editora";
            this.dataGridViewTextBoxColumn21.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn22.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "QtdTotal";
            this.dataGridViewTextBoxColumn23.HeaderText = "Quantidade Total";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Disponivel";
            this.dataGridViewTextBoxColumn24.HeaderText = "Qtd. Disponível";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 113;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(7, 9);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(116, 23);
            this.codigoTextBox.TabIndex = 0;
            this.codigoTextBox.Leave += new System.EventHandler(this.codigoTextBox_Leave);
            // 
            // isbnTabPage
            // 
            this.isbnTabPage.Controls.Add(this.isbnDataGridView);
            this.isbnTabPage.Controls.Add(this.isbnTextBox);
            this.isbnTabPage.Location = new System.Drawing.Point(4, 24);
            this.isbnTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnTabPage.Name = "isbnTabPage";
            this.isbnTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnTabPage.Size = new System.Drawing.Size(480, 170);
            this.isbnTabPage.TabIndex = 1;
            this.isbnTabPage.Text = "ISBN";
            this.isbnTabPage.UseVisualStyleBackColor = true;
            // 
            // isbnDataGridView
            // 
            this.isbnDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.isbnDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.isbnDataGridView.Location = new System.Drawing.Point(8, 38);
            this.isbnDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnDataGridView.MultiSelect = false;
            this.isbnDataGridView.Name = "isbnDataGridView";
            this.isbnDataGridView.ReadOnly = true;
            this.isbnDataGridView.RowHeadersVisible = false;
            this.isbnDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.isbnDataGridView.Size = new System.Drawing.Size(464, 125);
            this.isbnDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Código";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 71;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn10.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 57;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Autores";
            this.dataGridViewTextBoxColumn11.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 62;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Título";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 62;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Editora";
            this.dataGridViewTextBoxColumn13.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn14.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "QtdTotal";
            this.dataGridViewTextBoxColumn15.HeaderText = "Quantidade Total";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Disponivel";
            this.dataGridViewTextBoxColumn16.HeaderText = "Qtd. Disponível";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 113;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(7, 9);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(157, 23);
            this.isbnTextBox.TabIndex = 3;
            this.isbnTextBox.Leave += new System.EventHandler(this.isbnTextBox_Leave);
            // 
            // autorTabPage
            // 
            this.autorTabPage.Controls.Add(this.autorDataGridView);
            this.autorTabPage.Controls.Add(this.autorTextBox);
            this.autorTabPage.Location = new System.Drawing.Point(4, 24);
            this.autorTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autorTabPage.Name = "autorTabPage";
            this.autorTabPage.Size = new System.Drawing.Size(480, 170);
            this.autorTabPage.TabIndex = 2;
            this.autorTabPage.Text = "Autor";
            this.autorTabPage.UseVisualStyleBackColor = true;
            // 
            // autorDataGridView
            // 
            this.autorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.autorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.autorDataGridView.Location = new System.Drawing.Point(7, 40);
            this.autorDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autorDataGridView.MultiSelect = false;
            this.autorDataGridView.Name = "autorDataGridView";
            this.autorDataGridView.ReadOnly = true;
            this.autorDataGridView.RowHeadersVisible = false;
            this.autorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.autorDataGridView.Size = new System.Drawing.Size(464, 125);
            this.autorDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autores";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 62;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Título";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Editora";
            this.dataGridViewTextBoxColumn5.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QtdTotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantidade Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Disponivel";
            this.dataGridViewTextBoxColumn8.HeaderText = "Qtd. Disponível";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 113;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(7, 9);
            this.autorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(464, 23);
            this.autorTextBox.TabIndex = 4;
            this.autorTextBox.Leave += new System.EventHandler(this.autorTextBox_Leave);
            // 
            // tituloTabPage
            // 
            this.tituloTabPage.Controls.Add(this.tituloTextBox);
            this.tituloTabPage.Controls.Add(this.tituloDataGridView);
            this.tituloTabPage.Location = new System.Drawing.Point(4, 24);
            this.tituloTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tituloTabPage.Name = "tituloTabPage";
            this.tituloTabPage.Size = new System.Drawing.Size(480, 170);
            this.tituloTabPage.TabIndex = 3;
            this.tituloTabPage.Text = "Título";
            this.tituloTabPage.UseVisualStyleBackColor = true;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(7, 9);
            this.tituloTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(464, 23);
            this.tituloTextBox.TabIndex = 5;
            this.tituloTextBox.Leave += new System.EventHandler(this.tituloTextBox_Leave);
            // 
            // tituloDataGridView
            // 
            this.tituloDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tituloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.ISBN,
            this.Autor,
            this.Titulo,
            this.Editora,
            this.Ano,
            this.QtdTotal,
            this.Disponivel});
            this.tituloDataGridView.Location = new System.Drawing.Point(7, 37);
            this.tituloDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tituloDataGridView.MultiSelect = false;
            this.tituloDataGridView.Name = "tituloDataGridView";
            this.tituloDataGridView.ReadOnly = true;
            this.tituloDataGridView.RowHeadersVisible = false;
            this.tituloDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tituloDataGridView.Size = new System.Drawing.Size(464, 125);
            this.tituloDataGridView.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 71;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 57;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autores";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 62;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 62;
            // 
            // Editora
            // 
            this.Editora.DataPropertyName = "Editora";
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            this.Editora.ReadOnly = true;
            this.Editora.Visible = false;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Visible = false;
            // 
            // QtdTotal
            // 
            this.QtdTotal.DataPropertyName = "QtdTotal";
            this.QtdTotal.HeaderText = "Quantidade Total";
            this.QtdTotal.Name = "QtdTotal";
            this.QtdTotal.ReadOnly = true;
            this.QtdTotal.Visible = false;
            // 
            // Disponivel
            // 
            this.Disponivel.DataPropertyName = "Disponivel";
            this.Disponivel.HeaderText = "Qtd. Disponível";
            this.Disponivel.Name = "Disponivel";
            this.Disponivel.ReadOnly = true;
            this.Disponivel.Width = 113;
            // 
            // exibirButton
            // 
            this.exibirButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_play_dentro_de_um_círculo_16;
            this.exibirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exibirButton.Location = new System.Drawing.Point(509, 78);
            this.exibirButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(107, 32);
            this.exibirButton.TabIndex = 6;
            this.exibirButton.Text = "&Exibir";
            this.exibirButton.UseVisualStyleBackColor = true;
            this.exibirButton.Click += new System.EventHandler(this.exibirButton_Click);
            // 
            // localizarButton
            // 
            this.localizarButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_localizar_e_substituir_16;
            this.localizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localizarButton.Location = new System.Drawing.Point(509, 39);
            this.localizarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(107, 32);
            this.localizarButton.TabIndex = 5;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.UseVisualStyleBackColor = true;
            this.localizarButton.Click += new System.EventHandler(this.localizarButton_Click);
            // 
            // LocalizarLivroForm
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(630, 215);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.livroTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LocalizarLivroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Livro";
            this.Load += new System.EventHandler(this.LocalizarLivroForm_Load);
            this.livroTabControl.ResumeLayout(false);
            this.codigoTabPage.ResumeLayout(false);
            this.codigoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).EndInit();
            this.isbnTabPage.ResumeLayout(false);
            this.isbnTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isbnDataGridView)).EndInit();
            this.autorTabPage.ResumeLayout(false);
            this.autorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).EndInit();
            this.tituloTabPage.ResumeLayout(false);
            this.tituloTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.TabControl livroTabControl;
        private System.Windows.Forms.TabPage codigoTabPage;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TabPage isbnTabPage;
        private System.Windows.Forms.TabPage autorTabPage;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TabPage tituloTabPage;
        private System.Windows.Forms.DataGridView tituloDataGridView;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.DataGridView codigoDataGridView;
        private System.Windows.Forms.DataGridView isbnDataGridView;
        private System.Windows.Forms.DataGridView autorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponivel;
        public System.Windows.Forms.TextBox isbnTextBox;
    }
}