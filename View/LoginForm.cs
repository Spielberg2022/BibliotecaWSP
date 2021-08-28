using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class LoginForm : Form
    {
        DadosConexao dadosConexaoMySQL = new DadosConexao("127.0.0.1",
                                                            "root",
                                                            "wsly1987",
                                                            "bibliotecaws",
                                                            3306);
        public InterfaceBD conexaoBD { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conexaoBD = new ConexaoBDMariaBD(dadosConexaoMySQL);

            Usuario usuario = new Usuario();
            if (usuario.PrimeiroAcesso(conexaoBD))
            {
                MessageBox.Show("Cadastrar o primeiro usuário para acessar o sistema!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                CadUsuariosForm form = new CadUsuariosForm();
                form.conexaoBD = conexaoBD;
                form.primeiroAcesso = true;
                form.ShowDialog();
                MessageBox.Show("Configure as opções do sistema!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                ConfigurarOpcoesForm form1 = new ConfigurarOpcoesForm();
                form1.conexaoBD = conexaoBD;
                form1.primeiroAcesso = true;
                form1.ShowDialog();
            }
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Identificador = idTextBox.Text.Trim();
            usuario.Senha = senhaMaskedTextBox.Text.Trim();
            if(usuario.Login(conexaoBD))
            {
                PrincipalMDIParent principalForm = new PrincipalMDIParent();
                principalForm.conexaoBD = conexaoBD;
                principalForm.toolStripStatusLabel.Text = principalForm.toolStripStatusLabel.Text + usuario.Nome;
                principalForm.codUsuario = usuario.Codigo;
                principalForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha não conferem!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                idTextBox.Clear();
                senhaMaskedTextBox.Clear();
                idTextBox.Focus();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            senhaMaskedTextBox.Clear();
            idTextBox.Focus();
        }
    }
}
