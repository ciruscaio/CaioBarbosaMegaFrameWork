using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Conexao
{
    /// <summary>
    /// Classe com o objetivo de obter uma conexão com o Banco de Dados
    /// <remarks>Acessível somente dentro do próprio namespace</remarks>
    /// </summary>
    public class DataBaseLocator_MySQL
    {
        private static readonly DataBaseLocator_MySQL instance = new DataBaseLocator_MySQL();

        private DataBaseLocator_MySQL()
        {
        }

        /// <summary>
        /// Propriedade que contém uma única instância da classe
        /// </summary>
        /// <returns>retorna uma única instância de DataBaseLocator</returns>
        public static DataBaseLocator_MySQL getInstance()
        {
            return instance;
        }

        /// <summary>
        /// Propriedade que faz a conexão com o Banco de Dados
        /// </summary>
        /// <returns>retorna um SqlConnection</returns>
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ToString());
        }
    }
}
