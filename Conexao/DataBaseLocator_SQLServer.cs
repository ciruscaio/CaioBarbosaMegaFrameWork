using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Conexao
{
    /// <summary>
    /// Classe com o objetivo de obter uma conexão com o Banco de Dados
    /// <remarks>Acessível somente dentro do próprio namespace</remarks>
    /// </summary>
    public class DataBaseLocator_SQLServer
    {
        private static readonly DataBaseLocator_SQLServer instance = new DataBaseLocator_SQLServer();

        private DataBaseLocator_SQLServer()
        {
        }

        /// <summary>
        /// Propriedade que contém uma única instância da classe
        /// </summary>
        /// <returns>retorna uma única instância de DataBaseLocator</returns>
        public static DataBaseLocator_SQLServer getInstance()
        {
            return instance;
        }

        /// <summary>
        /// Propriedade que faz a conexão com o Banco de Dados
        /// </summary>
        /// <returns>retorna um SqlConnection</returns>
        public SqlConnection GetConnection()
        {
            string lAmbiente = ConfigurationManager.AppSettings["StringDeConexao"];

            if (String.IsNullOrEmpty(lAmbiente))
            {
                throw new Exception("A variável \"StringDeConexao\" não foi encontrada no arquivo de configuração (web.config)!");
            }
            else
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["StringDeConexao"].ConnectionString);
            }
        }
    }
}
