using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class CadUsuariosForm : Form
    {
        public bool primeiroAcesso = false;
        public Usuario usuario = new Usuario();
        public InterfaceBD conexaoBD { get; set; }
        public CadUsuariosForm()
        {
            InitializeComponent();
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            salvarButton.Enabled = true;
            excluirButton.Enabled = true;

            LocalizarUsuarioForm form = new LocalizarUsuarioForm();
            form.conexaoBD = conexaoBD;
            form.ShowDialog();
            try
            {
                codigoTextBox.Text = form.usuario.Codigo.ToString();
                nomeTextBox.Text = form.usuario.Nome;
                identificadorTextBox.Text = form.usuario.Identificador;
                senhaMaskedTextBox.Text = form.usuario.Senha;
                cepMaskedTextBox.Text = form.usuario.CEP;
                ufComboBox.Text = form.usuario.UF;
                bairroTextBox.Text = form.usuario.Bairro;
                cidadeTextBox.Text = form.usuario.Cidade;
                logradouroTextBox.Text = form.usuario.Logradouro;
            }
            catch (Exception)
            {
                codigoTextBox.Clear();
            }
            if (codigoTextBox.Text == "0")
                codigoTextBox.Clear();
            if(codigoTextBox.Text.Trim() == "")
            {
                salvarButton.Enabled = false;
                excluirButton.Enabled = false;
            }
            nomeTextBox.Focus();
        }

        private void CadUsuariosForm_Load(object sender, EventArgs e)
        {
            if(primeiroAcesso)
                novoButton_Click(sender, e);
        }

        private void limparTela()
        {
            codigoTextBox.Clear();
            nomeTextBox.Clear();
            identificadorTextBox.Clear();
            senhaMaskedTextBox.Clear();
            cepMaskedTextBox.Clear();
            ufComboBox.Text = "";
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            logradouroTextBox.Clear();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            limparTela();
            if (novoButton.Text == "&Novo")
            {
                localizarButton.Enabled = false;
                excluirButton.Enabled = false;
                salvarButton.Enabled = true;
                novoButton.Text = "&Cancelar";
                codigoTextBox.Text = "0";
                nomeTextBox.Focus();
            }
            else
            {
                if(primeiroAcesso)
                    this.Close();
                else
                {
                    localizarButton.Enabled = true;
                    excluirButton.Enabled = false;
                    salvarButton.Enabled = false;
                    novoButton.Text = "&Novo";
                    codigoTextBox.Text = "";
                    nomeTextBox.Focus();
                }
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.Codigo = int.Parse(codigoTextBox.Text);
            if (nomeTextBox.Text.Trim().Length != 0 && identificadorTextBox.Text.Trim().Length != 0 &&
                senhaMaskedTextBox.Text.Trim().Length != 0)
            {
                usuario.Nome = nomeTextBox.Text.Trim();
                usuario.Identificador = identificadorTextBox.Text.Trim();
                usuario.Senha = senhaMaskedTextBox.Text.Trim();
                usuario.CEP = cepMaskedTextBox.Text.Trim();
                usuario.UF = ufComboBox.Text.Trim();
                usuario.Bairro = bairroTextBox.Text.Trim();
                usuario.Cidade = cidadeTextBox.Text.Trim();
                usuario.Logradouro = logradouroTextBox.Text.Trim();

                if(usuario.Salvar(conexaoBD))
                {
                    MessageBox.Show("Usuário salvo com sucesso!",
                                "Informação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    novoButton.Text = "&Novo";
                    limparTela();
                    if (primeiroAcesso)
                        this.Close();
                    else
                    {
                        localizarButton.Enabled = true;
                        salvarButton.Enabled = false;
                        excluirButton.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Algum erro ao inserir o usuário!\n" + usuario.erro,
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }    
            else
                MessageBox.Show("Algum campo obrigatório não foi preenchido!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            usuario.Codigo = int.Parse(codigoTextBox.Text);
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o usuário?",
                                                     "Atenção!",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            switch (resultado)
            {
                case DialogResult.Yes:
                    if (usuario.Excluir(conexaoBD))
                    {
                        MessageBox.Show("Usuário excluído com sucesso!",
                                        "Informação",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        limparTela();
                        excluirButton.Enabled = false;
                        salvarButton.Enabled = false;
                    }
                    else
                        MessageBox.Show("Algum erro ao excluir o usuário!\n" + usuario.erro,
                                        "Atenção",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    break;
                case DialogResult.No:
                    MessageBox.Show("Exclusão cancelada!",
                                        "Informação",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void cepMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if(usuario.BuscarCEP(cepMaskedTextBox.Text))
            {
                ufComboBox.Text = usuario.UF;
                bairroTextBox.Text = usuario.Bairro;
                cidadeTextBox.Text = usuario.Cidade;
                logradouroTextBox.Text = usuario.Logradouro;
                logradouroTextBox.Focus();
            }
        }
    }
}
