using BibliotecaWSP.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace BibliotecaWSP.Model
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }

        MySqlDataReader dataReader = null;
        public string erro = "";
        public DataTable tableAluno = new DataTable();
        public Aluno() { }

        public Aluno(int codigo,
                        string matricula,
                        string nome,
                        string cpf,
                        string celular,
                        string cep,
                        string uf,
                        string bairro,
                        string cidade,
                        string logradouro)
        {
            erro = "";
            this.Codigo = codigo;
            this.Nome = nome;
            this.Matricula = matricula;
            this.CPF = cpf;
            this.Celular = celular;
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
                        sql = "INSERT INTO Aluno(Nome, Matricula, CPF, Celular, CEP, UF, Bairro, Cidade, Logradouro)" +
                                    $"VALUES('{this.Nome}', '{this.Matricula}', '{this.CPF}', '{this.Celular}', '{this.CEP}', '{this.UF}', '{this.Bairro}', '{this.Cidade}', '{this.Logradouro}')";
                        comando = new MySqlCommand(sql, conexaoBD.getConexao());
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexaoBD.desconectar();
                    }
                    else
                    {
                        sql = "UPDATE Aluno SET " +
                                    $"Nome = '{this.Nome}', Matricula = '{this.Matricula}', CPF = '{this.CPF}', Celular = '{this.Celular}', CEP = '{this.CEP}', UF = '{this.UF}', Bairro = '{this.Bairro}', Cidade = '{this.Cidade}', Logradouro = '{this.Logradouro}' " +
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

        public void LocalizarPorCodigo(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Aluno WHERE Codigo = {this.Codigo}");

        }

        public void LocalizarPorNome(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Aluno WHERE Nome like '%{this.Nome}%'");
        }

        public void LocalizarPorMatricula(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Aluno WHERE Matricula = '{this.Matricula}'");
        }

        public void LocalizarPorCPF(InterfaceBD conexaoBD)
        {
            Localizar(conexaoBD, $"SELECT * FROM Aluno WHERE CPF = '{this.CPF}'");
        }

        public void Localizar(InterfaceBD conexaoBD, string sqlComando)
        {
            MySqlCommand comando = null;
            dataReader = null;
            tableAluno = new DataTable();
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
                            if (tableAluno.Rows.Count == 0)
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                    tableAluno.Columns.Add(dataReader.GetName(i));
                            for (int i = 0; i < dataReader.FieldCount; i++)
                                values[i] = dataReader.GetValue(i);
                            tableAluno.Rows.Add(values);

                            this.Codigo = int.Parse(dataReader["Codigo"].ToString());
                            this.Nome = dataReader["Nome"].ToString();
                            this.Matricula = dataReader["Matricula"].ToString();
                            this.CPF = dataReader["CPF"].ToString();
                            this.Celular = dataReader["Celular"].ToString();
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
                    sql = $"DELETE FROM Aluno WHERE Codigo = {this.Codigo}";
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

        public bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
