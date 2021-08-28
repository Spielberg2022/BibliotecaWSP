
namespace BibliotecaWSP.View
{
    partial class ConfigurarOpcoesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarOpcoesForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sistemaTabPage = new System.Windows.Forms.TabPage();
            this.observacaoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.diasTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.sistemaTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.sistemaTabPage);
            this.tabControl.Location = new System.Drawing.Point(27, 14);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(453, 149);
            this.tabControl.TabIndex = 0;
            // 
            // sistemaTabPage
            // 
            this.sistemaTabPage.Controls.Add(this.observacaoLabel);
            this.sistemaTabPage.Controls.Add(this.label7);
            this.sistemaTabPage.Controls.Add(this.label6);
            this.sistemaTabPage.Controls.Add(this.valorTextBox);
            this.sistemaTabPage.Controls.Add(this.label5);
            this.sistemaTabPage.Controls.Add(this.diasTextBox);
            this.sistemaTabPage.Controls.Add(this.label4);
            this.sistemaTabPage.Location = new System.Drawing.Point(4, 24);
            this.sistemaTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sistemaTabPage.Name = "sistemaTabPage";
            this.sistemaTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sistemaTabPage.Size = new System.Drawing.Size(445, 121);
            this.sistemaTabPage.TabIndex = 1;
            this.sistemaTabPage.Text = "Configurações do Sistema";
            this.sistemaTabPage.UseVisualStyleBackColor = true;
            // 
            // observacaoLabel
            // 
            this.observacaoLabel.AutoSize = true;
            this.observacaoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.observacaoLabel.Location = new System.Drawing.Point(250, 98);
            this.observacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observacaoLabel.Name = "observacaoLabel";
            this.observacaoLabel.Size = new System.Drawing.Size(187, 15);
            this.observacaoLabel.TabIndex = 6;
            this.observacaoLabel.Text = "*Dados Obrigatórios em vermelho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(83, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor diário da multa:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(237, 67);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(95, 23);
            this.valorTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "dias.";
            // 
            // diasTextBox
            // 
            this.diasTextBox.Location = new System.Drawing.Point(288, 38);
            this.diasTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diasTextBox.Name = "diasTextBox";
            this.diasTextBox.Size = new System.Drawing.Size(44, 23);
            this.diasTextBox.TabIndex = 1;
            this.diasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(39, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade de dias máximo para devolução:";
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.Location = new System.Drawing.Point(488, 136);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(105, 27);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.Image = global::BibliotecaWSP.Properties.Resources.icons8_salvar_60;
            this.salvarButton.Location = new System.Drawing.Point(488, 38);
            this.salvarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(105, 92);
            this.salvarButton.TabIndex = 6;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // ConfigurarOpcoesForm
            // 
            this.AcceptButton = this.salvarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(609, 175);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ConfigurarOpcoesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigurarOpcoesForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigurarOpcoesForm_Load);
            this.tabControl.ResumeLayout(false);
            this.sistemaTabPage.ResumeLayout(false);
            this.sistemaTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage sistemaTabPage;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diasTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label observacaoLabel;
    }
}