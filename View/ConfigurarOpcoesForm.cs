using BibliotecaWSP.Controller;
using BibliotecaWSP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaWSP.View
{
    public partial class ConfigurarOpcoesForm : Form
    {
        public bool primeiroAcesso = false;
        public bool confirmaFechamento = false;
        public InterfaceBD conexaoBD { get; set; }
        public ConfigurarOpcoesForm()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarOpcoesForm_Load(object sender, EventArgs e)
        {
            if (primeiroAcesso)
                cancelarButton.Enabled = false;
            else
            {
                Opcoes opcoes = new Opcoes();
                if(opcoes.CarregarConfig(conexaoBD))
                {
                    valorTextBox.Text = opcoes.MultaDiaria.ToString();
                    diasTextBox.Text = opcoes.DiasDevolucao.ToString();
                }
                else
                    MessageBox.Show("Algum erro inesperado! Entre em contato com o suporte.\n" + opcoes.erro,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (diasTextBox.Text.Trim().Length != 0 && valorTextBox.Text.Trim().Length != 0)
            {
                Opcoes opcoes = new Opcoes();
                opcoes.DiasDevolucao = int.Parse(diasTextBox.Text);
                opcoes.MultaDiaria = decimal.Parse(valorTextBox.Text);
                opcoes.primeiroAcesso = primeiroAcesso;
                if (opcoes.Salvar(conexaoBD))
                {
                    MessageBox.Show("Configurações salvas com sucesso!",
                                "Informação!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    confirmaFechamento = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Algum erro inesperado! Entre em contato com o suporte.\n" + opcoes.erro,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Campos obrigatórios em branco, verifique!",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
        }

        private void ConfigurarOpcoesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirmaFechamento)
                e.Cancel = true;
        }
    }
}
