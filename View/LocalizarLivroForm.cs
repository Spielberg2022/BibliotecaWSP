using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class LocalizarLivroForm : Form
    {
        public Livro livro = new Livro();
        string varLoc = "";
        public DataTable selecao = new DataTable();

        public InterfaceBD conexaoBD { get; set; }
        public LocalizarLivroForm()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            livro = null;
        }

        private void LocalizarLivroForm_Load(object sender, EventArgs e)
        {

        }

        private void codigoTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "codigo";

            if (codigoTextBox.Text != null && codigoTextBox.Text.Trim() != "")
            {
                try
                {
                    livro.Codigo = int.Parse(codigoTextBox.Text);
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
                        livro.LocalizarPorCodigo(conexaoBD);
                        codigoDataGridView.DataSource = livro.tableLivro;
                        break;
                    case "isbn":
                        livro.LocalizarPorISBN(conexaoBD);
                        isbnDataGridView.DataSource = livro.tableLivro;
                        break;
                    case "autor":
                        livro.LocalizarPorAutor(conexaoBD);
                        autorDataGridView.DataSource = livro.tableLivro;
                        break;
                    case "titulo":
                        livro.LocalizarPorTitulo(conexaoBD);
                        tituloDataGridView.DataSource = livro.tableLivro;
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

        public void isbnTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "isbn";

            if (isbnTextBox.Text != null && isbnTextBox.Text.Trim() != "")
            {
                livro.ISBN = isbnTextBox.Text;
                localizarButton_Click(sender, e);
            }
        }

        private void autorTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "autor";

            if (autorTextBox.Text != null && autorTextBox.Text.Trim() != "")
            {
                livro.Autor = autorTextBox.Text;
                localizarButton_Click(sender, e);
            }
        }

        private void tituloTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "titulo";

            if (tituloTextBox.Text != null && tituloTextBox.Text.Trim() != "")
            {
                livro.Titulo = tituloTextBox.Text;
                localizarButton_Click(sender, e);
            }
        }

        private void exibirButton_Click(object sender, EventArgs e)
        {
            switch (varLoc)
            {
                case "codigo":
                    if (codigoDataGridView.CurrentRow == null)
                        livro.Codigo = 0;
                    break;
                case "isbn":
                    if (isbnDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = isbnDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        livro.ISBN = "";
                    break;
                case "autor":
                    if (autorDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = autorDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        livro.Autor = "";
                    break;
                case "titulo":
                    if (tituloDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = tituloDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        livro.Titulo = "";
                    break;
                default:
                    break;
            }
            this.Hide();
        }
    }
}
