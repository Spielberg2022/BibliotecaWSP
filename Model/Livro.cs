using BibliotecaWSP.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace BibliotecaWSP.Model
{
    public class Livro
    {
        public int Codigo { get; set; }
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Ano { get; set; }
        public int QtdTotal { get; set; }
        public int Disponivel { get; set; }

        MySqlDataReader dataReader = null;
        public string erro = "";
        public DataTable tableLivro = new DataTable();

        public Livro() {}

        public Livro(int codigo,
                     string isbn,
                     string autor,
                     string titulo,
                     string editora,
                     int ano,
                     int qtdTotal,
                     int disponivel)
        {
            erro = "";
            this.Codigo = codigo;
            this.ISBN = isbn;
            this.Autor = autor;
            this.Titulo = titulo;
            this.Editora = editora;
            this.Ano = ano;
            this.QtdTotal = qtdTotal;
            this.Disponivel = disponivel;
        }

        public bool Salvar(InterfaceBD conexaoBD)
        {
            bool resposta = true;
            MySqlCommand comando;
            string sql = "";
            try
            {
                if (conexaoBD.conectar())
                {
                    if (this.Codigo == 0)
                    {
                        sql = "INSERT INTO Livro(ISBN, Autores, Titulo, Editora, Ano, QtdTotal, Disponivel)" +
                                    $" VALUES('{this.ISBN}', '{this.Autor}', '{this.Titulo}', '{this.Editora}', {this.Ano}, {this.QtdTotal}, {this.Disponivel})";
                        comando = new MySqlCommand(sql, conexaoBD.getConexao());
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        sql = "UPDATE Livro SET " +
                                    $"ISBN = '{this.ISBN}', Autores = '{this.Autor}', Titulo = '{this.Titulo}', Editora = '{this.Editora}', Ano = {this.Ano}, QtdTotal = {this.QtdTotal}, Disponivel = {this.Disponivel}" +
                                    $" WHERE Codigo = {this.Codigo}";
                        comando = new MySqlCommand(sql, conexaoBD.getConexao());
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexaoBD.desconectar();
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

        public void LocalizarPorCodigo(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Livro WHERE Codigo = {this.Codigo}");

        }

        public void LocalizarPorISBN(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Livro WHERE ISBN = {this.ISBN}");

        }

        public void LocalizarPorAutor(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Livro WHERE Autores like '%{this.Autor}%'");

        }

        public void LocalizarPorTitulo(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Livro WHERE Titulo like '%{this.Titulo}%'");

        }

        public void Localizar(InterfaceBD conexaoBD, string sqlComando)
        {
            MySqlCommand comando = null;
            dataReader = null;
            tableLivro = new DataTable();
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
                            if (tableLivro.Rows.Count == 0)
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                    tableLivro.Columns.Add(dataReader.GetName(i));
                            for (int i = 0; i < dataReader.FieldCount; i++)
                                values[i] = dataReader.GetValue(i);
                            tableLivro.Rows.Add(values);

                            this.Codigo = int.Parse(dataReader["Codigo"].ToString());
                            this.ISBN = dataReader["ISBN"].ToString();
                            this.Autor = dataReader["Autores"].ToString();
                            this.Titulo = dataReader["Titulo"].ToString();
                            this.Editora = dataReader["Editora"].ToString();
                            this.Ano = int.Parse(dataReader["Ano"].ToString());
                            this.QtdTotal = int.Parse(dataReader["QtdTotal"].ToString());
                            this.Disponivel = int.Parse(dataReader["Disponivel"].ToString());
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

        public bool Excluir(InterfaceBD conexaoBD)
        {
            bool resposta = true;
            MySqlCommand comando = null;
            string sql = "";
            try
            {
                if (conexaoBD.conectar())
                {
                    sql = $"DELETE FROM Livro WHERE Codigo = {this.Codigo}";
                    comando = new MySqlCommand(sql, conexaoBD.getConexao());
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexaoBD.desconectar();
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

        public bool DisponivelMais(InterfaceBD conexaoBD)
        {

            return Atualizar(conexaoBD, $"UPDATE Livro SET Disponivel = {this.Disponivel + 1} WHERE Codigo = {this.Codigo}");

        }

        public bool DisponivelMenos(InterfaceBD conexaoBD)
        {
            if(this.Disponivel != 0)
                return Atualizar(conexaoBD, $"UPDATE Livro SET Disponivel = {this.Disponivel - 1} WHERE Codigo = {this.Codigo}");
            else
            {
                erro = $"Livro Código: {this.Codigo} indisponível, estão todos emprestados!";
                return false;
            }
        }

        public bool Atualizar(InterfaceBD conexaoBD, string sql)
        {
            bool resposta = true;
            MySqlCommand comando;
            try
            {
                if (conexaoBD.conectar())
                {
                    comando = new MySqlCommand(sql, conexaoBD.getConexao());
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexaoBD.desconectar();
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
    }
}
