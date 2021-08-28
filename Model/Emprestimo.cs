using BibliotecaWSP.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace BibliotecaWSP.Model
{
    public class Emprestimo
    {
        public int CodAluno { get; set; }
        public int CodLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataParaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int CodUsuario { get; set; }
        public decimal Multa { get; set; }

        MySqlDataReader dataReader = null;
        public string erro = "";
        public DataTable tableEmprestimo = new DataTable();
        public Livro livro = new Livro();

        public Emprestimo() { }

        public Emprestimo(int codAluno,
                          int codLivro,
                          DateTime dataEmprestimo,
                          DateTime dataParaDevolucao,
                          DateTime dataDevolucao,
                          int codUsuario,
                          decimal multa)
        {
            this.CodAluno = codAluno;
            this.CodLivro = codLivro;
            this.CodUsuario = codUsuario;
            this.DataDevolucao = dataDevolucao;
            this.DataEmprestimo = dataEmprestimo;
            this.DataParaDevolucao = dataParaDevolucao;
            this.Multa = multa;
        }

        public bool Emprestar(InterfaceBD conexaoBD)
        {
            bool resposta = true;
            MySqlCommand comando;
            string sql = "";
            try
            {
                if (conexaoBD.conectar())
                {
                    livro.Codigo = this.CodLivro;
                    livro.LocalizarPorCodigo(conexaoBD);
                    if (livro.Disponivel > 0)
                    {
                        conexaoBD.conectar();
                        if(livro.DisponivelMenos(conexaoBD))
                        {
                            sql = "INSERT INTO Emprestimo(CodAluno, CodLivro, CodUsuario, DataParaDevolucao, DataEmprestimo)" +
                                $"VALUES({this.CodAluno}, {this.CodLivro}, {this.CodUsuario}, '{this.DataParaDevolucao.Year}-{this.DataParaDevolucao.Month}-{this.DataParaDevolucao.Day}', '{this.DataEmprestimo.Year}-{this.DataEmprestimo.Month}-{this.DataEmprestimo.Day}')";
                            conexaoBD.conectar();
                            comando = new MySqlCommand(sql, conexaoBD.getConexao());
                            comando.ExecuteNonQuery();
                            comando.Dispose();
                            conexaoBD.desconectar();
                            resposta = true;
                        }
                        else
                        {
                            erro = livro.erro;
                            resposta = false;
                        }
                    }
                    else
                    {
                        erro = "Livro indisponível!";
                        resposta = false;
                    }                       
                }
                else
                    resposta = false;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                resposta = false;
            }

            return resposta;
        }

        public void LocalizarADevolverPorCodigoAluno(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT liv.codigo, liv.ISBN, liv.Titulo, emp.DataEmprestimo, emp.DataParaDevolucao, emp.DataDevolucao FROM emprestimo AS emp INNER JOIN livro AS liv ON emp.CodLivro = liv.Codigo WHERE emp.CodAluno = { this.CodAluno} AND emp.datadevolucao is null");
        }

        public bool Devolver(InterfaceBD conexaoBD, int codLivro, int codAluno)
        {
            MySqlCommand comando;
            string sql = "";
            bool retorno = true;
            try
            {
                if (conexaoBD.conectar())
                {
                    sql = $"UPDATE Emprestimo SET DataDevolucao = '{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}' WHERE CodLivro = {codLivro} AND CodAluno = {codAluno}";
                    comando = new MySqlCommand(sql, conexaoBD.getConexao());
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexaoBD.desconectar();
                    retorno = true;
                }
                else
                {
                    erro = "Problema na conexão com o banco de dados!";
                    retorno = false;
                } 
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                retorno = false;
            }
            return retorno;
        }

        public void LocalizarPorCodigoAluno(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT liv.codigo, liv.ISBN, liv.Titulo, emp.DataEmprestimo, emp.DataParaDevolucao, emp.DataDevolucao FROM emprestimo AS emp INNER JOIN livro AS liv ON emp.CodLivro = liv.Codigo WHERE emp.CodAluno = { this.CodAluno}");
        }

        public void Localizar(InterfaceBD conexaoBD, string sqlComando)
        {
            MySqlCommand comando = null;
            dataReader = null;
            tableEmprestimo = new DataTable();
            string sql = sqlComando;
            try
            {
                if (conexaoBD.conectar())
                {
                    comando = new MySqlCommand(sql, conexaoBD.getConexao());
                    dataReader = comando.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            object[] values = new object[dataReader.FieldCount];
                            if (tableEmprestimo.Rows.Count == 0)
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                    tableEmprestimo.Columns.Add(dataReader.GetName(i));
                            for (int i = 0; i < dataReader.FieldCount; i++)
                                values[i] = dataReader.GetValue(i);
                            tableEmprestimo.Rows.Add(values);
                        }
                    }
                    dataReader.Dispose();
                    dataReader.Close();
                    comando.Dispose();
                    conexaoBD.desconectar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
        }
    }
}
