
namespace BibliotecaWSP.View
{
    partial class LoginForm
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.entrarButton = new System.Windows.Forms.Button();
            this.senhaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.pictureBox1);
            this.loginGroupBox.Controls.Add(this.cancelarButton);
            this.loginGroupBox.Controls.Add(this.limparButton);
            this.loginGroupBox.Controls.Add(this.entrarButton);
            this.loginGroupBox.Controls.Add(this.senhaMaskedTextBox);
            this.loginGroupBox.Controls.Add(this.idTextBox);
            this.loginGroupBox.Controls.Add(this.label3);
            this.loginGroupBox.Controls.Add(this.label2);
            this.loginGroupBox.Controls.Add(this.label1);
            this.loginGroupBox.Location = new System.Drawing.Point(15, 14);
            this.loginGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginGroupBox.Size = new System.Drawing.Size(465, 261);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BibliotecaWSP.Properties.Resources.icons8_livros_100;
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(282, 208);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(88, 27);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(188, 208);
            this.limparButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(88, 27);
            this.limparButton.TabIndex = 6;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // entrarButton
            // 
            this.entrarButton.Location = new System.Drawing.Point(93, 208);
            this.entrarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(88, 27);
            this.entrarButton.TabIndex = 5;
            this.entrarButton.Text = "&Entrar";
            this.entrarButton.UseVisualStyleBackColor = true;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // senhaMaskedTextBox
            // 
            this.senhaMaskedTextBox.Location = new System.Drawing.Point(135, 167);
            this.senhaMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.senhaMaskedTextBox.Name = "senhaMaskedTextBox";
            this.senhaMaskedTextBox.Size = new System.Drawing.Size(257, 23);
            this.senhaMaskedTextBox.TabIndex = 4;
            this.senhaMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(134, 138);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(258, 23);
            this.idTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(142, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca \r\nLogin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.entrarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.limparButton;
            this.ClientSize = new System.Drawing.Size(495, 288);
            this.Controls.Add(this.loginGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.MaskedTextBox senhaMaskedTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}