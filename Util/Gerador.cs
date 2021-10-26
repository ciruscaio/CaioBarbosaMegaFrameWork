using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// Classe utilitária com o objetivo de gerar e gerenciar protocolos.
    /// </summary>
    public abstract class Gerador
    {
        /// <summary>
        /// Este método tem a função de gerar o protocolo.
        /// </summary>
        /// <param name="pPKUsuario">Identificação do usuário, que pode ser a PK de SEG_USUARIO ou Matricula do servidor.</param>
        /// <returns>Retorna uma string no formato [(n0) + data(yymmdd) + PK], onde n é o número de caracteres que faltam para a string completar 14 dígitos;</returns>
        public static string GerarProtocolo(string pPKUsuario)
        {
            return (DateTime.Now.ToString("yyMMdd") + pPKUsuario).PadLeft(14, '0');
        }

        /// <summary>
        /// Este método tem a função de gerar o número de inscrição.
        /// </summary>
        /// <param name="pCodigo">Identificação do canditado. Geralmente é a PK da tabela de inscrição.</param>
        /// <param name="pAno">Ano base da Inscrição</param>
        /// <param name="pQtdDigitos">Quantidade de dígitos que a inscrição vai ter a esquerda do ano, sendo completado com 0 (Zero)</param>
        /// <returns>Retorno o número de inscrição</returns>
        public static string GerarInscricao(Int32 pCodigo, string pAno, byte pQtdDigitos)
        {
            string inscricao = Convert.ToString(pCodigo) + pAno;
            inscricao = inscricao.PadLeft(pQtdDigitos, '0'); //Acrescenta Zeros ao codigo, até pQtdDigitos Digitos

            return inscricao;
        }

        /// <summary>
        /// Este método tem a função de gerar o número de inscrição.
        /// </summary>
        /// <param name="pCodigo">Identificação do canditado. Geralmente é a PK da tabela de inscrição.</param>
        /// <param name="pAno">Ano base da Inscrição</param>
        /// <param name="pQtdDigitos">Quantidade de dígitos que a inscrição vai ter a direita do ano, sendo completado com 0 (Zero)</param>
        /// <returns>Retorno o número de inscrição</returns>
        public static string GerarNumInscricaoAnoEsquerda(string pCodigo, string pAno, byte pQtdDigitos)
        {
            string lNumInscricao = pAno;
            lNumInscricao += pCodigo.PadLeft(pQtdDigitos - lNumInscricao.Length, '0');

            return lNumInscricao;
        }

        /// <summary>
        /// Gera senha padrão.
        /// </summary>
        /// <returns></returns>
        public static string GerarSenha(int pQuantidadeNumeros)
        {
            //Declarando o randomico a ser usado, as "posições" da senha e a senha retornada
            Random rnd = new Random();
            string lSenha = "";

            //Sorteando as "posições" da senha
            for (int i = 0; i < pQuantidadeNumeros; i++)
            {
                lSenha = lSenha + rnd.Next(0, 9).ToString();
            }

            return lSenha;
        }

        public static string GerarSenha(int pQuantidadeNumeros, int pQuantidadeAlfabeticos)
        {
            //Declarando o randomico a ser usado, as "posições" da senha e a senha retornada
            Random rnd = new Random();
            string lSenha = "";

            //Declarando o objeto do tipo array alfabeto e especial
            Char[] alfabeto = "abcdefghijlmnopqrstuvxz".ToCharArray();

            //Sorteando as "posições" da senha
            for (int i = 0; i < pQuantidadeNumeros; i++)
            {
                lSenha = lSenha + rnd.Next(0, 9).ToString();
            }
            for (int i = 0; i < pQuantidadeAlfabeticos; i++)
            {
                lSenha = lSenha + alfabeto[rnd.Next(1, 23)].ToString();
            }

            return lSenha;
        }

        public static string GerarSenha(int pQuantidadeNumeros, int pQuantidadeAlfabeticos, int QuantidadeEspecial)
        {
            //Declarando o randomico a ser usado, as "posições" da senha e a senha retornada
            Random rnd = new Random();
            string lSenha = "";

            //Declarando o objeto do tipo array alfabeto e especial
            Char[] alfabeto = "abcdefghijlmnopqrstuvxz".ToCharArray();
            Char[] especial = "@#$*".ToCharArray();

            //Sorteando as "posições" da senha
            for (int i = 0; i < pQuantidadeNumeros; i++)
            {
                lSenha = lSenha + rnd.Next(0, 9).ToString();
            }
            for (int i = 0; i < pQuantidadeAlfabeticos; i++)
            {
                lSenha = lSenha + alfabeto[rnd.Next(1, 23)].ToString();
            }
            for (int i = 0; i < QuantidadeEspecial; i++)
            {
                lSenha = lSenha + especial[rnd.Next(1, 4)].ToString();
            }

            return lSenha;
        }
    }
}
