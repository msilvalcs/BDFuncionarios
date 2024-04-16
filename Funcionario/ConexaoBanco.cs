using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    static class ConexaoBanco
    {
        // criando 4 constantes passando as informações do BD
        private const string servidor = "localhost";
        private const string bancoDados = "dbfuncionarios";
        private const string usuario = "root";
        private const string senha = "32407050";

        //declarando variavel bancoServidor para fazer a conexão com o BD
        static public string bancoServidor = $"server = {servidor} ; userId = {usuario}; dataBase = {bancoDados}; password = {senha}";
    }
}
