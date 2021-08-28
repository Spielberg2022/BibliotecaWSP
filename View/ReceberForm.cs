using System;
using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class ReceberForm : Form
    {
        public Aluno aluno = new Aluno();
        public Livro livro = new Livro();
        public Emprestimo emprestimo = new Emprestimo();
        public int codUsuario;

        public InterfaceBD conexaoBD { get; set; }
        public ReceberForm()
        {
            InitializeComponent();
        }

        private void ReceberForm_Load(object sender, EventArgs e)
        {
            dataDevolucaoDateTimePicker.Value = DateTime.Now;
        }

        private void multaButton_Click(object sender, EventArgs e)
        {
            receberButton.Enabled = true;
        }

        private void localizarAlunoButton_Click(object sender, EventArgs e)
        {
            LocalizarAlunoForm form = new LocalizarAlunoForm();
            form.conexaoBD = conexaoBD;
            form.ShowDialog();
            aluno = form.aluno;
            nomeTextBox.Text = aluno.Nome;
            codAlunoTextBox.Text = aluno.Codigo.ToString();
            matriculaMaskedTextBox.Text = aluno.Matricula;
            livrosADevolverDataGridView.DataSource = null;
            LocalizarEmprestimos();
        }

        private void LocalizarEmprestimos()
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.CodAluno = aluno.Codigo;
            emprestimo.LocalizarADevolverPorCodigoAluno(conexaoBD);
            livrosADevolverDataGridView.DataSource = emprestimo.tableEmprestimo;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void matriculaMaskedTextBox_Leave(object sender, EventArgs e)
        {
            aluno.Matricula = matriculaMaskedTextBox.Text;
            aluno.LocalizarPorMatricula(conexaoBD);
            nomeTextBox.Text = aluno.Nome;
            codAlunoTextBox.Text = aluno.Codigo.ToString();
            livrosADevolverDataGridView.DataSource = null;
            LocalizarEmprestimos();
        }

        private void confirmarLivroButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)livrosADevolverDataGridView.CurrentRow.Clone();
            row.Cells[0].Value = livrosADevolverDataGridView.CurrentRow.Cells[0].Value;
            row.Cells[1].Value = livrosADevolverDataGridView.CurrentRow.Cells[1].Value;
            row.Cells[2].Value = livrosADevolverDataGridView.CurrentRow.Cells[2].Value;
            row.Cells[3].Value = livrosADevolverDataGridView.CurrentRow.Cells[3].Value;
            row.Cells[4].Value = livrosADevolverDataGridView.CurrentRow.Cells[4].Value;
            row.Cells[5].Value = DateTime.Now;
            livrosDataGridView.Rows.Add(row);
            livrosADevolverDataGridView.Rows.RemoveAt(livrosADevolverDataGridView.CurrentRow.Index);
        }

        private void receberButton_Click(object sender, EventArgs e)
        {
            if (livrosDataGridView.Rows.Count > 1)
            {
                foreach (DataGridViewRow dr in livrosDataGridView.Rows)
                {
                    if(dr.Cells[0].Value != null)
                    {
                        emprestimo.CodLivro = int.Parse(dr.Cells[0].Value.ToString());
                        if (!emprestimo.Devolver(conexaoBD, emprestimo.CodLivro, aluno.Codigo))
                        {
                            MessageBox.Show("Aconteceu um problema na contagem dos livros e a devolução não foi finalizada com êxito! Tente receber os livros novamente e confira a quantidade de livros disponíveis!" + emprestimo.erro,
                                            "Erro catastrófico!",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        livro.Codigo = emprestimo.CodLivro;
                        livro.DisponivelMais(conexaoBD);
                    }
                    livrosDataGridView.DataSource = new DataTable();
                }
            }
            else
                MessageBox.Show("Lista de livros para serem devolvidos vazia.\nSelecione os livros que deseja receber na tabela ao lado e vá clicando em confirmar...",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
        }
    }
}
