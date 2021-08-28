using BibliotecaWSP.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace BibliotecaWSP.Model
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Identificador { get; set; }
        public string Senha { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }

        MySqlDataReader dataReader = null;
        public string erro = "";
        public DataTable tableUsuario = new DataTable();
        public Usuario() { }

        public Usuario(int codigo,
                        string nome,
                        string identificador,
                        string senha,
                        string cep,
                        string uf,
                        string bairro,
                        string cidade,
                        string logradouro)
        {
            erro = "";
            this.Codigo = codigo;
            this.Nome = nome;
            this.Identificador = identificador;
            this.Senha = senha;
            this.CEP = cep;
            this.UF = uf;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Logradouro = logradouro;
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
                        sql = "INSERT INTO Usuario(Nome, Identificador, Senha, CEP, UF, Bairro, Cidade, Logradouro)" +
                                    $"VALUES('{this.Nome}', '{this.Identificador}', '{this.Senha}', '{this.CEP}', '{this.UF}', '{this.Bairro}', '{this.Cidade}', '{this.Logradouro}')";
                        comando = new MySqlCommand(sql, conexaoBD.getConexao());
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        sql = "UPDATE Usuario SET " +
                                    $"Nome = '{this.Nome}', Identificador = '{this.Identificador}', Senha = '{this.Senha}', CEP = '{this.CEP}', UF = '{this.UF}', Bairro = '{this.Bairro}', Cidade = '{this.Cidade}', Logradouro = '{this.Logradouro}' " +
                                    $"WHERE Codigo = {this.Codigo}";
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

        public bool PrimeiroAcesso(InterfaceBD conexaoBD)
        {
            bool resposta = true;
            MySqlCommand comando;
            string sql = "";
            try
            {
                if (conexaoBD.conectar())
                {
                    sql = "SELECT COUNT(Codigo) FROM Usuario";
                    comando = new MySqlCommand(sql, conexaoBD.getConexao());
                    int qtd = int.Parse(comando.ExecuteScalar().ToString());
                    comando.Dispose();
                    conexaoBD.desconectar();

                    if (qtd > 0)
                        resposta = false;
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

        public bool Login(InterfaceBD conexaoBD)
        {
            bool resposta = true;
            MySqlCommand comando = null;
            dataReader = null;
            string sql = "";
            try
            {
                if (conexaoBD.conectar())
                {
                    sql = $"SELECT * FROM Usuario WHERE Identificador = '{this.Identificador}' and senha = '{this.Senha}'";
                    comando = new MySqlCommand(sql, conexaoBD.getConexao());
                    dataReader = comando.ExecuteReader();

                    if (!dataReader.HasRows)
                        resposta = false;
                    else
                    {
                        while (dataReader.Read())
                        {
                            this.Codigo = int.Parse(dataReader["Codigo"].ToString());
                            this.Nome = dataReader["Nome"].ToString();
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

        public void LocalizarPorCodigo(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Usuario WHERE Codigo = {this.Codigo}");

        }

        public void LocalizarPorNome(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Usuario WHERE Nome like '%{this.Nome}%'");
        }

        public void LocalizarPorId(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Usuario WHERE Identificador like '%{this.Identificador}%'");
        }

        public void Localizar(InterfaceBD conexaoBD, string sqlComando)
        {
            MySqlCommand comando = null;
            dataReader = null;
            tableUsuario = new DataTable();
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
                            if (tableUsuario.Rows.Count == 0)
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                    tableUsuario.Columns.Add(dataReader.GetName(i));
                            for (int i = 0; i < dataReader.FieldCount; i++)
                                values[i] = dataReader.GetValue(i);
                            tableUsuario.Rows.Add(values);

                            this.Codigo = int.Parse(dataReader["Codigo"].ToString());
                            this.Nome = dataReader["Nome"].ToString();
                            this.Identificador = dataReader["Identificador"].ToString();
                            this.Senha = dataReader["Senha"].ToString();
                            this.CEP = dataReader["CEP"].ToString();
                            this.UF = dataReader["UF"].ToString();
                            this.Bairro = dataReader["Bairro"].ToString();
                            this.Cidade = dataReader["Cidade"].ToString();
                            this.Logradouro = dataReader["Logradouro"].ToString();
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
                    sql = $"DELETE FROM Usuario WHERE Codigo = {this.Codigo}";
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

        public bool BuscarCEP(string text)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    erro = ChecaServidor.StatusCode.ToString();
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            String response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                // CEP
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(':');
                                    this.CEP = valor[1].ToString();
                                }

                                // Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(':');
                                    this.Logradouro = valor[1].ToString().Trim();
                                }


                                // Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(':');
                                    this.Bairro = valor[1].ToString().Trim();
                                }

                                // Cidade
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(':');
                                    this.Cidade = valor[1].ToString().Trim();
                                }

                                // UF
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(':');
                                    this.UF = valor[1].ToString().Trim();
                                }
                                cont++;
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception error)
            {
                erro = erro + "\n" + error.Message;
                return false;
            }
        }
    }
}
