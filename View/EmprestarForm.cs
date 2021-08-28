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
    public partial class EmprestarForm : Form
    {
        public Aluno aluno = new Aluno();
        public Livro livro = new Livro();
        public Emprestimo emprestimo = new Emprestimo();
        public int codUsuario;

        public InterfaceBD conexaoBD { get; set; }

        public EmprestarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmprestarForm_Load(object sender, EventArgs e)
        {
            dataEmprestimoDateTimePicker.Value = DateTime.Now;

            Opcoes opcoes = new Opcoes();
            opcoes.CarregarConfig(conexaoBD);

            dataDevolucaoDateTimePicker.Value = DateTime.Now.AddDays(double.Parse(opcoes.DiasDevolucao.ToString()));
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
            emprestimosDataGridView.DataSource = null;
            LocalizarEmprestimos();
        }

        private void LocalizarEmprestimos()
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.CodAluno = aluno.Codigo;
            emprestimo.LocalizarPorCodigoAluno(conexaoBD);
            emprestimosDataGridView.DataSource = emprestimo.tableEmprestimo;
        }

        private void localizarLivroButton_Click(object sender, EventArgs e)
        {
            LocalizarLivroForm form = new LocalizarLivroForm();
            form.conexaoBD = conexaoBD;
            form.ShowDialog();
            livro = form.livro;
            tituloTextBox.Text = livro.Titulo;
            autorTextBox.Text = livro.Autor;
            codLivroTextBox.Text = livro.Codigo.ToString();
            isbnTextBox.Text = livro.ISBN;
        }

        private void matriculaMaskedTextBox_Leave(object sender, EventArgs e)
        {
            aluno.Matricula = matriculaMaskedTextBox.Text;
            aluno.LocalizarPorMatricula(conexaoBD);
            nomeTextBox.Text = aluno.Nome;
            codAlunoTextBox.Text = aluno.Codigo.ToString();
            emprestimosDataGridView.DataSource = null;
            LocalizarEmprestimos();
        }

        private void isbnTextBox_Leave(object sender, EventArgs e)
        {
            livro.ISBN = isbnTextBox.Text;
            livro.LocalizarPorISBN(conexaoBD);
            tituloTextBox.Text = livro.Titulo;
            autorTextBox.Text = livro.Autor;
            codLivroTextBox.Text = livro.Codigo.ToString();
        }

        private void emprestarButton_Click(object sender, EventArgs e)
        {
            if(codLivroTextBox.Text.Trim().Length != 0 && codLivroTextBox.Text != "0" &&
                codAlunoTextBox.Text.Trim().Length != 0 && codAlunoTextBox.Text != "0")
            {
                emprestimo.CodAluno = aluno.Codigo;
                emprestimo.CodLivro = livro.Codigo;
                emprestimo.DataEmprestimo = dataEmprestimoDateTimePicker.Value;
                emprestimo.DataParaDevolucao = dataDevolucaoDateTimePicker.Value;
                emprestimo.CodUsuario = codUsuario;
                if (emprestimo.Emprestar(conexaoBD))
                {
                    MessageBox.Show("Empréstimo realizado com sucesso!",
                                    "Infomação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    LimparForm();
                    emprestimosDataGridView.DataSource = null;
                    LocalizarEmprestimos();
                }
                else
                    MessageBox.Show("Empréstimo não foi realizado!\n" + emprestimo.erro,
                                    "Atenção!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Selecione um livro e um aluno antes de clicar em emprestar!\n",
                                    "Atenção!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
        }

        private void LimparForm()
        {
            tituloTextBox.Clear();
            autorTextBox.Clear();
            codLivroTextBox.Clear();
        }
    }
}
