using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class CadAlunosForm : Form
    {
        public Aluno aluno = new Aluno();
        public InterfaceBD conexaoBD { get; set; }
        public CadAlunosForm()
        {
            InitializeComponent();
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            salvarButton.Enabled = true;
            excluirButton.Enabled = true;

            LocalizarAlunoForm form = new LocalizarAlunoForm();
            form.conexaoBD = conexaoBD;
            form.ShowDialog();
            try
            {
                codigoTextBox.Text = form.aluno.Codigo.ToString();
                nomeTextBox.Text = form.aluno.Nome;
                matriculaMaskedTextBox.Text = form.aluno.Matricula;
                cpfMaskedTextBox.Text = form.aluno.CPF;
                celularMaskedTextBox.Text = form.aluno.Celular;
                cepMaskedTextBox.Text = form.aluno.CEP;
                ufComboBox.Text = form.aluno.UF;
                bairroTextBox.Text = form.aluno.Bairro;
                cidadeTextBox.Text = form.aluno.Cidade;
                logradouroTextBox.Text = form.aluno.Logradouro;
            }
            catch (Exception)
            {
                codigoTextBox.Clear();
            }
            if (codigoTextBox.Text == "0")
                codigoTextBox.Clear();
            if (codigoTextBox.Text.Trim() == "")
            {
                salvarButton.Enabled = false;
                excluirButton.Enabled = false;
            }
            matriculaMaskedTextBox.Focus();
        }

        private void CadAlunosForm_Load(object sender, EventArgs e)
        {

        }

        private void limparTela()
        {
            codigoTextBox.Clear();
            nomeTextBox.Clear();
            matriculaMaskedTextBox.Clear();
            cpfMaskedTextBox.Clear();
            celularMaskedTextBox.Clear();
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
                matriculaMaskedTextBox.Focus();
            }
            else
            {
                localizarButton.Enabled = true;
                excluirButton.Enabled = false;
                salvarButton.Enabled = false;
                novoButton.Text = "&Novo";
                codigoTextBox.Text = "";
                matriculaMaskedTextBox.Focus();
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            aluno = new Aluno();
            aluno.Codigo = int.Parse(codigoTextBox.Text);
            if (nomeTextBox.Text.Trim().Length != 0 && matriculaMaskedTextBox.Text.Trim().Length != 0 &&
                cpfMaskedTextBox.Text.Trim().Length != 0 && celularMaskedTextBox.Text.Trim().Length != 0)
            {
                aluno.Nome = nomeTextBox.Text.Trim();
                aluno.Matricula = matriculaMaskedTextBox.Text.Trim();
                aluno.CPF = cpfMaskedTextBox.Text.Trim();
                aluno.Celular = celularMaskedTextBox.Text.Trim();
                aluno.CEP = cepMaskedTextBox.Text.Trim();
                aluno.UF = ufComboBox.Text.Trim();
                aluno.Bairro = bairroTextBox.Text.Trim();
                aluno.Cidade = cidadeTextBox.Text.Trim();
                aluno.Logradouro = logradouroTextBox.Text.Trim();

                if (aluno.Salvar(conexaoBD))
                {
                    MessageBox.Show("Aluno salvo com sucesso!",
                                "Informação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    novoButton.Text = "&Novo";
                    limparTela();

                    localizarButton.Enabled = true;
                    salvarButton.Enabled = false;
                    excluirButton.Enabled = false;
                }
                else
                    MessageBox.Show("Algum erro ao inserir o aluno!\n" + aluno.erro,
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
            aluno.Codigo = int.Parse(codigoTextBox.Text);
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o aluno?",
                                                     "Atenção!",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            switch (resultado)
            {
                case DialogResult.Yes:
                    if (aluno.Excluir(conexaoBD))
                    {
                        MessageBox.Show("Aluno excluído com sucesso!",
                                        "Informação",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        limparTela();
                        excluirButton.Enabled = false;
                        salvarButton.Enabled = false;
                    }
                    else
                        MessageBox.Show("Algum erro ao excluir o aluno!\n" + aluno.erro,
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
            if (aluno.BuscarCEP(cepMaskedTextBox.Text))
            {
                ufComboBox.Text = aluno.UF;
                bairroTextBox.Text = aluno.Bairro;
                cidadeTextBox.Text = aluno.Cidade;
                logradouroTextBox.Text = aluno.Logradouro;
                logradouroTextBox.Focus();
            }
        }

        private void cpfMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if(cpfMaskedTextBox.Text.Trim().Length > 0)
            {
                if(!aluno.IsCpf(cpfMaskedTextBox.Text))
                {
                    DialogResult resultado = MessageBox.Show("CPF inválido, deseja prosseguir assim mesmo?",
                                                             "Atenção!",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question);
                    switch (resultado)
                    {
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            cpfMaskedTextBox.Clear();
                            cpfMaskedTextBox.Focus();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
