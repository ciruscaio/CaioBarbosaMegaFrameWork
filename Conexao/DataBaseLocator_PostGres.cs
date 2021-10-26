using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Npgsql;

namespace Conexao
{
    /// <summary>
    /// 
    /// <example>
    /// USUÁRIO E SENHA:
    ///     private const string StringConexao = "Server=tbdprojetos.no-ip.org;Port=5432;Database=APT;User Id=postgres;Password=apltrack2012;";
    ///
    /// INTEGRADO:
    ///     private const string StringConexao = "Server=tbdprojetos.no-ip.org;Port=5432;Database=APT;Integrated Security=true;";
    /// </example>
    /// </summary>
    public class DataBaseLocator_PostGres
    {
        private static readonly DataBaseLocator_PostGres instance = new DataBaseLocator_PostGres();

        private DataBaseLocator_PostGres()
        {
        }

        /// <summary>
        /// Propriedade que contém uma única instância da classe
        /// </summary>
        /// <returns>retorna uma única instância de DataBaseLocator</returns>
        public static DataBaseLocator_PostGres getInstance()
        {
            return instance;
        }

        /// <summary>
        /// Propriedade que faz a conexão com o Banco de Dados
        /// </summary>
        /// <returns>retorna um SqlConnection</returns>
        public NpgsqlConnection GetConnection()
        {
            string lAmbiente = ConfigurationManager.AppSettings["StringDeConexao"];

            if (String.IsNullOrEmpty(lAmbiente))
            {
                throw new Exception("A variável \"StringDeConexao\" não foi encontrada no arquivo de configuração (web.config)!");
            }
            else
            {
                return new NpgsqlConnection(ConfigurationManager.ConnectionStrings["StringDeConexao"].ConnectionString);
            }
        }
    }
}
