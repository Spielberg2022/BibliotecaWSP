using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class CadLivrosForm : Form
    {
        public Livro livro = new Livro();
        public InterfaceBD conexaoBD { get; set; }
        public CadLivrosForm()
        {
            InitializeComponent();
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            salvarButton.Enabled = true;
            excluirButton.Enabled = true;

            LocalizarLivroForm form = new LocalizarLivroForm();
            form.conexaoBD = conexaoBD;
            form.ShowDialog();
            try
            {
                codigoTextBox.Text = form.livro.Codigo.ToString();
                isbnTextBox.Text = form.livro.ISBN;
                autorTextBox.Text = form.livro.Autor;
                tituloTextBox.Text = form.livro.Titulo;
                editoraTextBox.Text = form.livro.Editora;
                anoMaskedTextBox.Text = form.livro.Ano.ToString();
                qtdTotalTextBox.Text = form.livro.QtdTotal.ToString();
                disponíveisTextBox.Text = form.livro.Disponivel.ToString();
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
            isbnTextBox.Focus();
        }

        private void CadLivrosForm_Load(object sender, EventArgs e)
        {

        }

        private void limparTela()
        {
            codigoTextBox.Clear();
            isbnTextBox.Clear();
            autorTextBox.Clear();
            tituloTextBox.Clear();
            editoraTextBox.Clear();
            anoMaskedTextBox.Clear();
            qtdTotalTextBox.Clear();
            disponíveisTextBox.Clear();
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
                isbnTextBox.Focus();
            }
            else
            {
                localizarButton.Enabled = true;
                excluirButton.Enabled = false;
                salvarButton.Enabled = false;
                novoButton.Text = "&Novo";
                codigoTextBox.Text = "";
                isbnTextBox.Focus();
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            livro = new Livro();
            livro.Codigo = int.Parse(codigoTextBox.Text);
            if (isbnTextBox.Text.Trim().Length != 0 && autorTextBox.Text.Trim().Length != 0 &&
                tituloTextBox.Text.Trim().Length != 0)
            {
                livro.ISBN = isbnTextBox.Text.Trim();
                livro.Autor = autorTextBox.Text.Trim();
                livro.Titulo = tituloTextBox.Text.Trim();
                livro.Editora = editoraTextBox.Text.Trim();
                livro.Ano = int.Parse(anoMaskedTextBox.Text.Trim());
                livro.QtdTotal = int.Parse(qtdTotalTextBox.Text.Trim());
                livro.Disponivel = int.Parse(disponíveisTextBox.Text.Trim());

                if (livro.Salvar(conexaoBD))
                {
                    MessageBox.Show("Livro salvo com sucesso!",
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
                    MessageBox.Show("Algum erro ao inserir o livro!\n" + livro.erro,
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
            livro.Codigo = int.Parse(codigoTextBox.Text);
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Livro?",
                                                     "Atenção!",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            switch (resultado)
            {
                case DialogResult.Yes:
                    if (livro.Excluir(conexaoBD))
                    {
                        MessageBox.Show("Livro excluído com sucesso!",
                                        "Informação",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        limparTela();
                        excluirButton.Enabled = false;
                        salvarButton.Enabled = false;
                    }
                    else
                        MessageBox.Show("Algum erro ao excluir o aluno!\n" + livro.erro,
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
    }
}
