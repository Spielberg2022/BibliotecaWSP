using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class LocalizarAlunoForm : Form
    {
        public Aluno aluno = new Aluno();
        string varLoc = "";
        public DataTable selecao = new DataTable();

        public InterfaceBD conexaoBD { get; set; }

        public LocalizarAlunoForm()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            aluno = null;
        }

        private void LocalizarAlunoForm_Load(object sender, EventArgs e)
        {

        }

        private void codigoTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "codigo";

            if (codigoTextBox.Text != null && codigoTextBox.Text.Trim() != "")
            {
                try
                {
                    aluno.Codigo = int.Parse(codigoTextBox.Text);
                    localizarButton_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite apenas números!",
                                    "Atenção!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (varLoc)
                {
                    case "codigo":
                        aluno.LocalizarPorCodigo(conexaoBD);
                        codigoDataGridView.DataSource = aluno.tableAluno;
                        break;
                    case "nome":
                        aluno.LocalizarPorNome(conexaoBD);
                        nomeDataGridView.DataSource = aluno.tableAluno;
                        break;
                    case "matricula":
                        aluno.LocalizarPorMatricula(conexaoBD);
                        matriculaDataGridView.DataSource = aluno.tableAluno;
                        break;
                    case "cpf":
                        aluno.LocalizarPorCPF(conexaoBD);
                        cpfDataGridView.DataSource = aluno.tableAluno;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void nomeTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "nome";

            if (nomeTextBox.Text != null && nomeTextBox.Text.Trim() != "")
            {
                aluno.Nome = nomeTextBox.Text;
                localizarButton_Click(sender, e);
            }
        }

        public void matriculaMaskedTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "matricula";

            if (matriculaMaskedTextBox.Text != null && matriculaMaskedTextBox.Text.Trim() != "")
            {
                aluno.Matricula = matriculaMaskedTextBox.Text;
                localizarButton_Click(sender, e);
            }
        }

        private void cpfMaskedTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "cpf";

            if (cpfMaskedTextBox.Text != null && cpfMaskedTextBox.Text.Trim() != "")
            {
                aluno.CPF = cpfMaskedTextBox.Text;
                localizarButton_Click(sender, e);
            }
        }

        public void exibirButton_Click(object sender, EventArgs e)
        {
            switch (varLoc)
            {
                case "codigo":
                    if (codigoDataGridView.CurrentRow == null)
                        aluno.Codigo = 0;
                    break;
                case "nome":
                    if (nomeDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = nomeDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        aluno.Nome = "";
                    break;
                case "matricula":
                    if (matriculaDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = matriculaDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        aluno.Matricula = "";
                    break;
                case "cpf":
                    if (cpfDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = cpfDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        aluno.CPF = "";
                    break;
                default:
                    break;
            }
            this.Hide();
        }
    }
}
