using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class cadastroFuncionarios
    {
        // Declarando variaveis
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        //Metodos get e set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }        
        public string Nome 
        {  
            get { return nome; } 
            set { nome = value; }
        }
        public string Email
        {
            get { return email; } 
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
   
        // Metodo para cadastrar funcionario no BD
        public bool cadastrarFuncionarios()
        {
            // Tratamento de exceção
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection (ConexaoBanco.bancoServidor);
                MySqlConexaoBanco.Open ();

                string insert = $"insert into funcionarios (nome,email,cpf,endereco) values('{Nome}','{Email}','{Cpf}','{Endereco}')";

                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert ;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // Mensagem de erro quando não for possivel cadastrar funcionarios no campo
                // Erro ligado ao BD
                MessageBox.Show("Erro no banco de dados - método cadastrarFuncionario" + ex.Message);
                return false;
            }
        }

        // Metodo para localizar funcionario no BD
        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection mySqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                mySqlConexaoBanco.Open();

                string select = $"select id, nome, email, cpf, endereco from funcionarios where cpf = '{Cpf}';";
                MySqlCommand comandoSql = mySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select ;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método localizarFuncionario(): " + ex.Message);
                return null;
            }
        }
    }
}
