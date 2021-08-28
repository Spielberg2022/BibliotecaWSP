
namespace BibliotecaWSP.View
{
    partial class LocalizarUsuarioForm
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
            this.usuarioTabControl = new System.Windows.Forms.TabControl();
            this.codigoTabPage = new System.Windows.Forms.TabPage();
            this.codigoDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTabPage = new System.Windows.Forms.TabPage();
            this.nomeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.IdentificadorTabPage = new System.Windows.Forms.TabPage();
            this.identificadorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.usuarioTabControl.SuspendLayout();
            this.codigoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).BeginInit();
            this.nomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).BeginInit();
            this.IdentificadorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.identificadorDataGridView)).BeginInit();
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
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // usuarioTabControl
            // 
            this.usuarioTabControl.Controls.Add(this.codigoTabPage);
            this.usuarioTabControl.Controls.Add(this.nomeTabPage);
            this.usuarioTabControl.Controls.Add(this.IdentificadorTabPage);
            this.usuarioTabControl.Location = new System.Drawing.Point(14, 14);
            this.usuarioTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usuarioTabControl.Name = "usuarioTabControl";
            this.usuarioTabControl.SelectedIndex = 0;
            this.usuarioTabControl.Size = new System.Drawing.Size(488, 198);
            this.usuarioTabControl.TabIndex = 8;
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
            this.codigoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codigoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cidade,
            this.Logradouro,
            this.Nome,
            this.Identificador,
            this.Senha,
            this.CEP,
            this.UF,
            this.Bairro});
            this.codigoDataGridView.Location = new System.Drawing.Point(7, 37);
            this.codigoDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigoDataGridView.MultiSelect = false;
            this.codigoDataGridView.Name = "codigoDataGridView";
            this.codigoDataGridView.ReadOnly = true;
            this.codigoDataGridView.RowHeadersVisible = false;
            this.codigoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.codigoDataGridView.Size = new System.Drawing.Size(464, 125);
            this.codigoDataGridView.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 71;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            // 
            // Logradouro
            // 
            this.Logradouro.DataPropertyName = "Logradouro";
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            this.Logradouro.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 65;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Width = 99;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "CEP";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Visible = false;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Visible = false;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Visible = false;
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
            // nomeTabPage
            // 
            this.nomeTabPage.Controls.Add(this.nomeDataGridView);
            this.nomeTabPage.Controls.Add(this.nomeTextBox);
            this.nomeTabPage.Location = new System.Drawing.Point(4, 24);
            this.nomeTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeTabPage.Name = "nomeTabPage";
            this.nomeTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeTabPage.Size = new System.Drawing.Size(480, 170);
            this.nomeTabPage.TabIndex = 1;
            this.nomeTabPage.Text = "Nome";
            this.nomeTabPage.UseVisualStyleBackColor = true;
            // 
            // nomeDataGridView
            // 
            this.nomeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.nomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.nomeDataGridView.Location = new System.Drawing.Point(8, 40);
            this.nomeDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeDataGridView.MultiSelect = false;
            this.nomeDataGridView.Name = "nomeDataGridView";
            this.nomeDataGridView.ReadOnly = true;
            this.nomeDataGridView.RowHeadersVisible = false;
            this.nomeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nomeDataGridView.Size = new System.Drawing.Size(464, 125);
            this.nomeDataGridView.TabIndex = 4;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Logradouro";
            this.dataGridViewTextBoxColumn3.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 65;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Identificador";
            this.dataGridViewTextBoxColumn5.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 99;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Senha";
            this.dataGridViewTextBoxColumn6.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn7.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UF";
            this.dataGridViewTextBoxColumn8.HeaderText = "UF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn9.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(7, 9);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(464, 23);
            this.nomeTextBox.TabIndex = 3;
            this.nomeTextBox.Leave += new System.EventHandler(this.nomeTextBox_Leave);
            // 
            // IdentificadorTabPage
            // 
            this.IdentificadorTabPage.Controls.Add(this.identificadorDataGridView);
            this.IdentificadorTabPage.Controls.Add(this.identificadorTextBox);
            this.IdentificadorTabPage.Location = new System.Drawing.Point(4, 24);
            this.IdentificadorTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IdentificadorTabPage.Name = "IdentificadorTabPage";
            this.IdentificadorTabPage.Size = new System.Drawing.Size(480, 170);
            this.IdentificadorTabPage.TabIndex = 2;
            this.IdentificadorTabPage.Text = "Identificador";
            this.IdentificadorTabPage.UseVisualStyleBackColor = true;
            // 
            // identificadorDataGridView
            // 
            this.identificadorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.identificadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.identificadorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.identificadorDataGridView.Location = new System.Drawing.Point(7, 40);
            this.identificadorDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.identificadorDataGridView.MultiSelect = false;
            this.identificadorDataGridView.Name = "identificadorDataGridView";
            this.identificadorDataGridView.ReadOnly = true;
            this.identificadorDataGridView.RowHeadersVisible = false;
            this.identificadorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.identificadorDataGridView.Size = new System.Drawing.Size(464, 125);
            this.identificadorDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Código";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 71;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Logradouro";
            this.dataGridViewTextBoxColumn12.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 65;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Identificador";
            this.dataGridViewTextBoxColumn14.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 99;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Senha";
            this.dataGridViewTextBoxColumn15.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn16.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "UF";
            this.dataGridViewTextBoxColumn17.HeaderText = "UF";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn18.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.Location = new System.Drawing.Point(7, 9);
            this.identificadorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(251, 23);
            this.identificadorTextBox.TabIndex = 4;
            this.identificadorTextBox.Leave += new System.EventHandler(this.identificadorTextBox_Leave);
            // 
            // exibirButton
            // 
            this.exibirButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_play_dentro_de_um_círculo_16;
            this.exibirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exibirButton.Location = new System.Drawing.Point(509, 78);
            this.exibirButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(107, 32);
            this.exibirButton.TabIndex = 10;
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
            this.localizarButton.TabIndex = 9;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.UseVisualStyleBackColor = true;
            this.localizarButton.Click += new System.EventHandler(this.localizarButton_Click);
            // 
            // LocalizarUsuarioForm
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(630, 215);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.usuarioTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LocalizarUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LocalizarUsuarioForm_FormClosed);
            this.Load += new System.EventHandler(this.LocalizarUsuarioForm_Load);
            this.usuarioTabControl.ResumeLayout(false);
            this.codigoTabPage.ResumeLayout(false);
            this.codigoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).EndInit();
            this.nomeTabPage.ResumeLayout(false);
            this.nomeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).EndInit();
            this.IdentificadorTabPage.ResumeLayout(false);
            this.IdentificadorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.identificadorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.TabControl usuarioTabControl;
        private System.Windows.Forms.TabPage codigoTabPage;
        private System.Windows.Forms.DataGridView codigoDataGridView;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TabPage nomeTabPage;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TabPage IdentificadorTabPage;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridView nomeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView identificadorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}