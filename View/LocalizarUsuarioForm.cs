using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class LocalizarUsuarioForm : Form
    {
        public Usuario usuario = new Usuario();
        string varLoc = "";
        public DataTable selecao = new DataTable();

        public InterfaceBD conexaoBD { get; set; }

        public LocalizarUsuarioForm()
        {
            InitializeComponent();
        }

        private void codigoTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "codigo";
            
            if (codigoTextBox.Text != null && codigoTextBox.Text.Trim() != "")
            {
                try
                {
                    usuario.Codigo = int.Parse(codigoTextBox.Text);
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
                        usuario.LocalizarPorCodigo(conexaoBD);
                        codigoDataGridView.DataSource = usuario.tableUsuario;
                        break;
                    case "nome":
                        usuario.LocalizarPorNome(conexaoBD);
                        nomeDataGridView.DataSource = usuario.tableUsuario;
                        break;
                    case "identificador":
                        usuario.LocalizarPorId(conexaoBD);
                        identificadorDataGridView.DataSource = usuario.tableUsuario;
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
                usuario.Nome = nomeTextBox.Text;
                localizarButton_Click(sender, e);
            }     
        }

        private void identificadorTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "identificador";

            if (identificadorTextBox.Text != null && identificadorTextBox.Text.Trim() != "")
            {
                usuario.Identificador = identificadorTextBox.Text;
                localizarButton_Click(sender, e);
            }
        }

        private void exibirButton_Click(object sender, EventArgs e)
        {
            switch (varLoc)
            {
                case "codigo":
                    if (codigoDataGridView.CurrentRow == null)
                        usuario.Codigo = 0;
                    break;
                case "nome":
                    if (nomeDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = nomeDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        usuario.Nome = "";
                    break;
                case "identificador":
                    if (identificadorDataGridView.CurrentRow != null)
                    {
                        varLoc = "codigo";
                        codigoTextBox.Text = identificadorDataGridView.CurrentRow.Cells[0].Value.ToString();
                        localizarButton_Click(sender, e);
                    }
                    else
                        usuario.Identificador = "";
                    break;
                default:
                    break;
            }
            this.Hide();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            usuario = null;
        }

        private void LocalizarUsuarioForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void LocalizarUsuarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
