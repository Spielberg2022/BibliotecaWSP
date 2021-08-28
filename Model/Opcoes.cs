using BibliotecaWSP.Controller;
using MySql.Data.MySqlClient;
using System;

namespace BibliotecaWSP.Model
{
    public class Opcoes
    {
        public int DiasDevolucao { get; set; }
        public decimal MultaDiaria { get; set; }

        MySqlDataReader dataReader = null;
        public bool primeiroAcesso;
        public string erro = "";

        public Opcoes() { }

        public Opcoes(int diasDevolucao,
                      decimal multaDiaria)
        {
            this.DiasDevolucao = diasDevolucao;
            this.MultaDiaria = multaDiaria;
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
                    if (primeiroAcesso)
                    {
                        sql = "INSERT INTO Opcoes(DiasDevolucao, MultaDiaria)" +
                                    "VALUES(" + this.DiasDevolucao + ", REPLACE( REPLACE( '" + this.MultaDiaria + "', '.' ,'' ), ',', '.' ))";
                        comando = new MySqlCommand(sql, conexaoBD.getConexao());
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        sql = "UPDATE Opcoes SET " +
                                    "DiasDevolucao = " + this.DiasDevolucao + ", MultaDiaria = REPLACE( REPLACE( '" + this.MultaDiaria + "', '.' ,'' ), ',', '.' )";
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

        public bool CarregarConfig(InterfaceBD conexaoBD)
        {
            bool resposta = true;
            MySqlCommand comando;
            string sql = "";
            try
            {
                if (conexaoBD.conectar())
                {
                    sql = "SELECT * FROM Opcoes";
                    comando = new MySqlCommand(sql, conexaoBD.getConexao());
                    dataReader = comando.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            this.DiasDevolucao = int.Parse(dataReader["DiasDevolucao"].ToString());
                            this.MultaDiaria = Decimal.Parse(dataReader["MultaDiaria"].ToString());
                        }
                    }
                    dataReader.Dispose();
                    dataReader.Close();
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
