using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    /// <summary>
    /// Classe utilitária com o objetivo de Criptografar dados.
    /// </summary>
    public class Criptografia
    {
        public Criptografia()
        { 
        }

        /// <summary>
        /// Decriptografa uma string criptografada com o algoritmo Base64
        /// </summary>
        /// <param name="valor">string criptografado</param>
        /// <returns>string decriptografada (texto plen)</returns>
        public static string decryptBase64(string valor)
        {
            byte[] b = Convert.FromBase64String(valor);
            string decryptedConnectionString = System.Text.ASCIIEncoding.ASCII.GetString(b);
            return decryptedConnectionString;
        }

        /// <summary>
        /// Criptografa uma string utilizando o algoritmo Base64
        /// </summary>
        /// <param name="valor">string decriptografada (texto plen)</param>
        /// <returns>string criptografado</returns>
        public static string encryptBase64(string valor)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(valor);
            return Convert.ToBase64String(encbuff);
        }

        /// <summary>
        /// Criptografa uma string utilizando o algoritmo MD5
        /// </summary>
        /// <param name="Valor">string decriptografada (texto plen)</param>
        /// <returns>string criptografado</returns>
        /// <remarks>MD5 não pode ser descriptografado</remarks>
        public static string criptoMD5(string Valor)
        {

            string strResultado = "";
            byte[] bytMensagem = System.Text.Encoding.Default.GetBytes(Valor);

            // Cria o Hash MD5 hash
            System.Security.Cryptography.MD5CryptoServiceProvider oMD5Provider = new System.Security.Cryptography.MD5CryptoServiceProvider();

            // Gera o Hash Code
            byte[] bytHashCode = oMD5Provider.ComputeHash(bytMensagem);

            for (int iItem = 0; iItem < bytHashCode.Length; iItem++)
            {
                strResultado += (char)(bytHashCode[iItem]);
            }

            return strResultado;
        }
    }
}
