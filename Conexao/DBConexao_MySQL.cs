using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Conexao
{
	/// <summary>
    /// Essa classe tem a fun��o de prover acesso, executar comandos e retornar tipos especificos do
    /// Banco de Dados
    /// </summary>
    public class DBConexao_MySQL
    {
        /// <summary>
        /// Propriedade private que obtem uma conex�o com o Banco de Dados
        /// </summary>
        private MySqlConnection obterConexao()
        {
            return DataBaseLocator_MySQL.getInstance().GetConnection();
        }



        #region M�todos SetNullValue

        /// <summary>
        /// Metodo utilit�rio para inserir valor nulo no banco de dados.
        /// </summary>
        /// <param name="isNullValue">Testa se o valor � nulo</param>
        /// <param name="value">Valor a ser testado</param>
        /// <returns>
        /// Se o valor for igual a nulo retorna DBNull.Value,
        /// Se o valor for diferente de nulo retorna o valor
        /// </returns>
        /// <example>
        ///     Exemplo teste de nulidade:
        ///     Se for string: <code>SetNullValue(string.IsNullOrEmpty(object.value), object.value)</code>
        ///     Se for Boolean: <code>SetNullValue(object.value == false, object.value)</code>
        ///     Se for Data: <code>SetNullValue(object.value == DateTime.MinValue, object.value)</code>
        ///     Se for Int: <code>SetNullValue(object.value == 0, object.value)</code>
        /// </example>
        protected object SetNullValue(bool isNullValue, object value)
        {
            if (isNullValue)
                return DBNull.Value;
            else
                return value;
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(string value)
        {
            if (String.IsNullOrEmpty(value))
                return DBNull.Value;
            else
                return value.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected object SetNullValueToUpper(string value)
        {
            if (String.IsNullOrEmpty(value))
                return DBNull.Value;
            else
                return value.Trim().ToUpper();
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(char value)
        {
            if (value == '\0')
                return DBNull.Value;
            else
                return value;
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(DateTime value)
        {
            if (value == DateTime.MinValue)
                return DBNull.Value;
            else
                return value;
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(int value)
        {
            if (value == 0)
                return DBNull.Value;
            else
                return value;
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(decimal value)
        {
            if (value == 0)
                return DBNull.Value;
            else
                return value;
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(double value)
        {
            if (value == 0)
                return DBNull.Value;
            else
                return value;
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(byte value)
        {
            if (value == 0)
                return DBNull.Value;
            else
                return value;
        }

        /// <summary>
        ///  M�todo utilit�rio que retorna um valor para inserir no banco de dados,
        ///  sendo esse valor nulo ou o valor passado por parametro, se esse �ltimo for diferente de nulo.
        /// </summary>
        /// <param name="value">
        ///     Valor a ser testado se est� nulo ou n�o.
        /// </param>
        /// <returns>
        ///     Se o valor passado por par�mentro for diferente de nulo, retorna ele mesmo
        ///     sen�o retorna DBNull.Value.
        /// </returns>
        protected object SetNullValue(bool? value)
        {
            if (value.HasValue == false)
                return DBNull.Value;
            else
                return value.Value;
        }

        #endregion

        #region M�todos GetValue

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (null) ou preenchido do tipo string.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo string que est�
        ///     recebendo o valor de acordo com o resultado. Esse segundo par�metro serve para identificar
        ///     qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna uma string nula (se objeto testado estiver nulo)
        ///     ou retorna uma string preenchida com o conte�do do objeto testado
        ///     (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo justificativa (VARCHAR) da tabela resposta do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Resposta.Justificativa = GetValue(ds["justificativa"], Resposta.Justificativa);
        ///     </code>
        ///     Considerando a Propriedade Justificativa do Objeto Resposta como sendo do tipo String.
        /// </example>
        protected string GetValue(object value, string tipo)
        {
            if (value != DBNull.Value)
            {
                return value.ToString().Trim();
            }
            else
                return String.Empty;
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (0, zero) ou preenchido do tipo int.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo int que est� recebendo o valor de acordo com o resultado.
        ///     Esse segundo par�metro serve para identificar qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna um int zerado (se objeto testado estiver nulo)
        ///     ou retorna um int preenchido com o conte�do do objeto testado (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo codigo_ace_estrut_orgn (INT) da tabela Questionario do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Questionario.Codigo_gre = GetValue(ds["codigo_ace_estrut_orgn"], Questionario.Codigo_gre);
        ///     </code>
        ///     Considerando a Propriedade Codigo_gre do Objeto Questionario como sendo do tipo Int.
        /// </example>
        protected int GetValue(object value, int tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToInt32(value.ToString());
            }
            else
                return 0;
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (DateTime.MinValue) ou preenchido do tipo DateTime.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo DateTime que est� recebendo o valor de acordo com o resultado.
        ///     Esse segundo par�metro serve para identificar qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna um DateTime com o valor padr�o (DateTime.MinValue) (se objeto testado estiver nulo)
        ///     ou retorna um DateTime preenchido com o conte�do do objeto testado (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo data_hora_altr (DATETIME) da tabela resposta do banco de dados, considerando esse campo opcional.
        ///     <code>
        ///         Resposta.Data_hora_alteracao = GetValue(ds["data_hora_altr"], Resposta.Data_hora_alteracao);
        ///     </code>
        ///     Considerando a Propriedade Data_hora_alteracao do Objeto Resposta como sendo do tipo String.
        /// </example>
        protected DateTime GetValue(object value, DateTime tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToDateTime(value.ToString());
            }
            else
                return DateTime.MinValue;
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (0, zero) ou preenchido do tipo decimal.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo decimal que est� recebendo o valor de acordo com o resultado.
        ///     Esse segundo par�metro serve para identificar qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna um decimal zerado (se objeto testado estiver nulo)
        ///     ou retorna um decimal preenchido com o conte�do do objeto testado (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo media (DECIMAL) da tabela aluno do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Aluno.Media = GetValue(ds["media"], Aluno.Media);
        ///     </code>
        ///     Considerando a Propriedade Media do Objeto Aluno como sendo do tipo decimal.
        /// </example>
        protected decimal GetValue(object value, decimal tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToDecimal(value.ToString());
            }
            else
                return 0;
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (0, zero) ou preenchido do tipo Double.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo double que est� recebendo o valor de acordo com o resultado.
        ///     Esse segundo par�metro serve para identificar qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna um double zerado (se objeto testado estiver nulo)
        ///     ou retorna um double preenchido com o conte�do do objeto testado (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo media (DOUBLE) da tabela aluno do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Aluno.Media = GetValue(ds["media"], Aluno.Media);
        ///     </code>
        ///     Considerando a Propriedade Media do Objeto Aluno como sendo do tipo double.
        /// </example>
        protected decimal GetValue(object value, double tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToDecimal(value.ToString());
            }
            else
                return 0;
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (false) ou preenchido do tipo bool.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo bool que est� recebendo o valor de acordo com o resultado.
        ///     Esse segundo par�metro serve para identificar qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna false (se objeto testado estiver nulo)
        ///     ou retorna o conte�do (true ou false) do objeto testado (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo mudar_senha (BIT) da tabela usuario do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Usuario.Mudar_senha = GetValue(ds["mudar_senha"], Usuario.Reset_senha);
        ///     </code>
        ///     Considerando a Propriedade Mudar_senha do Objeto Usuario como sendo do tipo bool.
        /// </example>
        protected bool GetValue(object value, bool tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToBoolean(value.ToString());
            }
            else
                return false;
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (0, zero) ou preenchido do tipo byte.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo byte que est� recebendo o valor de acordo com o resultado.
        ///     Esse segundo par�metro serve para identificar qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna um byte zerado (se objeto testado estiver nulo)
        ///     ou retorna um byte preenchido com o conte�do do objeto testado (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo codigo_estado (TINYINT) da tabela SAA_ALUNO do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Aluno.Codigo_estado = GetValue(ds["codigo_estado"], Aluno.Codigo_estado);
        ///     </code>
        ///     Considerando a Propriedade Codigo_estado do Objeto Aluno como sendo do tipo byte.
        /// </example>
        protected byte GetValue(object value, byte tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToByte(value.ToString());
            }
            else
                return 0;
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o ('\0') ou preenchido de um char.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo char que est� recebendo o valor de acordo com o resultado.
        ///     Esse segundo par�metro serve para identificar qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna '\0' (se objeto testado estiver nulo)
        ///     ou retorna um char preenchido com o conte�do do objeto testado (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo ativo (CHAR(1)) da tabela Produto do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Produto.Ativo = GetValue(ds["ativo"], Produto.Ativo);
        ///     </code>
        ///     Considerando a Propriedade Ativo do Objeto Produto como sendo do tipo char.
        /// </example>
        protected char GetValue(object value, char tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToChar(value.ToString());
            }
            else
                return '\0';
        }

        /// <summary>
        ///     M�todo utilit�rio para obter valor padr�o (null) ou preenchido do tipo bool?.
        ///     Esse m�todo � utilizado quando queremos obter um valor de um campo do banco de dados que aceita null,
        ///     ele verifica se existe conte�do nesse campo e retorna algo dependendo desse resultado.
        /// </summary>
        /// <param name="value">
        ///     Objeto a ser testado se est� nulo ou n�o.
        /// </param>
        /// <param name="tipo">
        ///     Passar a pr�pria vari�vel ou propriedade do tipo bool? que est�
        ///     recebendo o valor de acordo com o resultado. Esse segundo par�metro serve para identificar
        ///     qual ser� o tipo do retorno.
        /// </param>
        /// <returns>
        ///     Retorna um bool? nulo (se objeto testado estiver nulo)
        ///     ou retorna um bool? preenchido com o conte�do do objeto testado
        ///     (se objeto testado n�o estiver nulo)
        /// </returns>
        /// <example>
        ///     Obtendo o valor do campo ind_documentacao_completa (BIT) da tabela candidato do banco de dados, sendo esse campo opcional.
        ///     <code>
        ///         Candidato.IndDocumentacaoCompleta = GetValue(ds["ind_documentacao_completa"], Candidato.IndDocumentacaoCompleta);
        ///     </code>
        ///     Considerando a Propriedade IndDocumentacaoCompleta do Objeto Candidato como sendo do tipo bool?.
        /// </example>
        protected bool? GetValue(object value, bool? tipo)
        {
            if (value != DBNull.Value)
            {
                return Convert.ToBoolean(value.ToString());
            }
            else
                return null;
        }

        #endregion


        /// <summary>
        ///     M�todo utilit�rio que retorna um objeto SqlDataReader.
        /// </summary>
        /// <param name="pMySqlCommand">
        ///     Instru��o SELECT que ir� executar no Banco de Dados.
        /// </param>
        /// <returns>
        ///     Retorna um SqlDataReader preenchido de acordo com resultado que a instru��o SELECT gerou.
        /// </returns>
        /// <example>
        ///     Obtendo o nome de todos os Funcion�rios.
        ///     <code>
        ///         public SqlDataReader obterNomeFuncionarios()
        ///         {
        ///             string lSql = "SELECT nome FROM EDU_FUNCIONARIO";
        ///             SqlCommand lSqlCommand = new SqlCommand(lSql);
        ///             try
        ///             {
        ///                 return returnDataReader(lSqlCommand);
        ///             }
        ///             cath(SqlException ex)
        ///             {
        ///                 throw new AplicacaoException("Erro ao obter os nomes dos funcion�rios! " + ex.Message, ex);
        ///             }
        ///         }
        ///     </code>
        ///     Obtendo um Funcion�rio
        ///     <code>
        ///         public Funcionario obter()
        ///         {
        ///             Funcionario lFuncionario = null;
        ///             
        ///             string lSql = "SELECT * FROM EDU_FUNCIONARIO";
        ///             SqlCommand lSqlCommand = new SqlCommand(lSql);
        ///             try
        ///             {
        ///                 SqlDataReader lSqlDataReader = returnDataReader(lSqlCommand);
        ///                 
        ///                 if(lSqlDataReader.HasRows)
        ///                 {
        ///                     lFuncionario = new Funcionario();
        ///                     lFuncionario.Codigo = Convert.ToInt32(lSqlDataReader["codigo"].ToString());
        ///                     lFuncionario.Nome = lSqlDataReader["nome"].ToString();
        ///                     lFuncionario.Matricula = GetValue(lSqlDataReader["matricula"], lFuncionario.Matricula);
        ///                     ...
        ///                 }
        ///                 return lFuncionario;
        ///             }
        ///             cath(SqlException ex)
        ///             {
        ///                 throw new AplicacaoException("Erro ao obter o Funcion�rio! " + ex.Message, ex);
        ///             }
        ///         }
        ///     </code>
        /// </example>
        protected MySqlDataReader returnDataReader(MySqlCommand pMySqlCommand)
        {
            MySqlConnection lSqlConnection = null;
            MySqlDataReader lSqlDataReader = null;

            try
            {
                lSqlConnection = obterConexao();

                pMySqlCommand.Connection = lSqlConnection;

                lSqlConnection.Open();
                lSqlDataReader = pMySqlCommand.ExecuteReader();
                
                return lSqlDataReader;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     M�todo utilit�rio que retorna um objeto DataTable.
        /// </summary>
        /// <param name="pMySqlCommand">
        ///     Instru��o SELECT que ir� executar no Banco de Dados.
        /// </param>
        /// <returns>
        ///     Retorna um DataTable preenchido de acordo com resultado que a instru��o SELECT gerou.
        /// </returns>
        /// <example>
        ///     Obtendo o nome de todos os Funcion�rios
        ///     <code>
        ///         public DataTable obterNomeFuncionarios()
        ///         {
        ///             DataTable lDataTable = null;        
        /// 
        ///             string lSql = "SELECT nome FROM EDU_FUNCIONARIO";
        ///             SqlCommand lSqlCommand = new SqlCommand(lSql);
        ///             try
        ///             {
        ///                 lDataTable returnDataDatable(lSqlCommand);
        ///             }
        ///             cath(SqlException ex)
        ///             {
        ///                 throw new AplicacaoException("Erro ao obter os nomes dos funcion�rios! " + ex.Message, ex);
        ///             }
        ///             
        ///             return lDataTable;
        ///         }
        ///     </code>
        ///     Obtendo um Funcion�rio
        ///     <code>
        ///         public Funcionario obter()
        ///         {
        ///             Funcionario lFuncionario = null;
        ///             string lSql = "SELECT * FROM EDU_FUNCIONARIO";
        ///             SqlCommand lSqlCommand = new SqlCommand(lSql);
        ///             try
        ///             {
        ///                 DataTable lDataTable = returnDataDatable(lSqlCommand);
        ///                 if(lDataTable.Rows.Count > 0)
        ///                 {
        ///                     lFuncionario = new Funcionario();
        ///                     lFuncionario.Codigo = Convert.ToInt32(lDataTable.Rows[0]["codigo"].ToString());
        ///                     lFuncionario.Nome = lDataTable.Rows[0]["nome"].ToString();
        ///                     lFuncionario.Cargo = GetValue(lDataTable.Rows[0]["matricula"], lFuncionario.Cargo);
        ///                     ...
        ///                 }
        ///                 return lFuncionario;
        ///             }
        ///             cath(SqlException ex)
        ///             {
        ///                 throw new AplicacaoException("Erro ao obter o funcion�rio! " + ex.Message, ex);
        ///             }
        ///         }
        ///     </code>
        /// </example>
        protected DataTable returnDataTable(MySqlCommand pMySqlCommand)
        {
            MySqlConnection lSqlConnection = null;

            try
            {
                lSqlConnection = obterConexao();
                pMySqlCommand.Connection = lSqlConnection;
                MySqlDataAdapter lSqlDataAdapter = new MySqlDataAdapter(pMySqlCommand);

                lSqlConnection.Open();
                DataTable lDataTable = new DataTable();
                lSqlDataAdapter.Fill(lDataTable);

                return lDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (lSqlConnection != null)
                {
                    lSqlConnection.Close();
                }
            }
        }

        /// <summary>
        ///     M�todo utilit�rio que serve para executar INSERT, UPDATE e DELETE no Banco de Dados.
        /// </summary>
        /// <param name="pMySqlCommand">
        ///     Instru��o INSERT, UPDATE, DELETE ou Stored Procedure de INSERT, UPDATE ou DELETE que ir� executar no Banco de Dados.
        ///     Caso d� algum erro levantar� uma exce��o com a descri��o do mesmo.
        /// </param>
        /// <example>
        ///     Cadastrando um Funcion�rio
        ///     <code>
        ///         public void cadastrar(Funcionario pFuncionario)
        ///         {
        ///             SqlCommand lSqlCommand = new SqlCommand("SP_EDU_FUNCIONARIO_INC");
        ///             lSqlCommand.CommandType = CommandType.StoredProcedure;
        ///             
        ///             lSqlCommand.Parameters.AddWithValue("@nome", pFuncionario.Nome);
        ///             lSqlCommand.Parameters.AddWithValue("@matricula", SetNullValue(pFuncionario.Matricula == string.Empty, pFuncionario.Matricula == null, pFuncionario.Matricula);
        ///             ...
        ///             
        ///             try
        ///             {
        ///                 executeNonQuery(lSqlCommand);
        ///             }
        ///             cath(SqlException ex)
        ///             {
        ///                 throw new AplicacaoException("Erro ao cadastradar Funcion�rio! " + ex.Message, ex);
        ///             }
        ///         }
        ///     </code>
        /// </example>
        protected void executeNonQuery(MySqlCommand pMySqlCommand)
        {
            MySqlConnection lSqlConnection = null;

            try
            {
                lSqlConnection = obterConexao();

                pMySqlCommand.Connection = lSqlConnection;

                lSqlConnection.Open();
                pMySqlCommand.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (lSqlConnection != null)
                {
                    lSqlConnection.Close();
                }
            }
        }

        /// <summary>
        ///     M�todo utilit�rio que serve para executar INSERT, UPDATE e DELETE no Banco de Dados.
        /// </summary>
        /// <param name="pSqlCommand">
        ///     Instru��o INSERT, UPDATE, DELETE ou Stored Procedure de INSERT, UPDATE ou DELETE que ir� executar no Banco de Dados.
        ///     Caso d� algum erro levantar� uma exce��o com a descri��o do mesmo.
        /// </param>
        protected object executeScalar(MySqlCommand pMySqlCommand)
        {
            MySqlConnection lConnection = null;

            try
            {
                lConnection = obterConexao();

                pMySqlCommand.Connection = lConnection;

                lConnection.Open();

                return pMySqlCommand.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (lConnection != null)
                {
                    lConnection.Close();
                }
            }
        }
    }

}