using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace Util
{
    /// <summary>
    /// Classe utilitária com o objetivo de retonrar valores em um formato específico.
    /// </summary>
    public class StringFormatador
    {
        /// <summary>
        /// Este método tem a função de retirar o domínio do usuário logado no Sistema da INTRANET,
        /// pois, quando se faz um HttpContext.Current.User.Identity.Name.ToString() o usuário é
        /// extraído do windows no formato domínio/login.
        /// </summary>
        /// <param name="sUsuarioLogado">Usuário logado, no formato: domínio/login</param>
        /// <returns>Usuário logado, no formato: login</returns>
        /// <example>input: SEEPE\osmars</example>
        /// <example>output: osmars</example>
        public static String ObterLogin(string sUsuarioLogado)
        {
            //Fatiando o usuarioLogado em domínio e login
            string login = null;
            string dominio = null;

            if (sUsuarioLogado.IndexOf("\\") != -1)
            {
                string[] aryUser = new String[2];
                char[] splitter = { '\\' };
                aryUser = sUsuarioLogado.Split(splitter);
                login = aryUser[1];
                dominio = aryUser[0];
            }

            return login;
        }

        /// <summary>
        /// Este método tem a função de retirar o "." (Ponto), a "," (Vírgula), o "-" (Hífen) e o "_" (Underline) do CPF ou CEP.
        /// </summary>
        /// <param name="pInput">CPF no formato: 999.999.999-9_ ou 52.140-301</param>
        /// <returns>Somente os números do CPF ou CEP.</returns>
        /// <example>input: 999.999.999-9_</example>
        /// <example>output: 9999999999</example>
        /// <example>input: 52.140-301</example>
        /// <example>output: 52140301</example>
        public static string RetirarMascara(string pInput)
        {
            pInput = pInput.Replace(".", "");
            pInput = pInput.Replace(",", "");
            pInput = pInput.Replace("-", "");
            pInput = pInput.Replace("_", "");
            pInput = pInput.Replace("/", "");
            pInput = pInput.Replace(")", "");
            pInput = pInput.Replace("(", "");
            pInput = pInput.Replace("{", "");
            pInput = pInput.Replace("}", "");

            return pInput.Trim();
        }

        /// <summary>
        /// Este método tem a função de retirar todo tipo de assento, sejam: "´","`","^","~" e "¨".
        /// </summary>
        public static string RetirarSinalGrafico(string pInput)
        {
            pInput = pInput.Replace("á", "a");
            pInput = pInput.Replace("é", "e");
            pInput = pInput.Replace("í", "i");
            pInput = pInput.Replace("ó", "o");
            pInput = pInput.Replace("ú", "u");
            pInput = pInput.Replace("Á", "A");
            pInput = pInput.Replace("É", "E");
            pInput = pInput.Replace("Í", "I");
            pInput = pInput.Replace("Ó", "O");
            pInput = pInput.Replace("Ú", "U");

            pInput = pInput.Replace("à", "a");
            pInput = pInput.Replace("è", "e");
            pInput = pInput.Replace("ì", "i");
            pInput = pInput.Replace("ò", "o");
            pInput = pInput.Replace("ù", "u");
            pInput = pInput.Replace("À", "A");
            pInput = pInput.Replace("È", "E");
            pInput = pInput.Replace("Ì", "I");
            pInput = pInput.Replace("Ò", "O");
            pInput = pInput.Replace("Ù", "U");

            pInput = pInput.Replace("â", "a");
            pInput = pInput.Replace("ê", "e");
            pInput = pInput.Replace("î", "i");
            pInput = pInput.Replace("ô", "o");
            pInput = pInput.Replace("û", "u");
            pInput = pInput.Replace("Â", "A");
            pInput = pInput.Replace("Ê", "E");
            pInput = pInput.Replace("Î", "I");
            pInput = pInput.Replace("Ô", "O");
            pInput = pInput.Replace("Û", "U");

            pInput = pInput.Replace("ã", "a");
            pInput = pInput.Replace("õ", "o");
            pInput = pInput.Replace("Ã", "A");
            pInput = pInput.Replace("Õ", "O");

            pInput = pInput.Replace("ä", "a");
            pInput = pInput.Replace("ë", "e");
            pInput = pInput.Replace("ï", "i");
            pInput = pInput.Replace("ö", "o");
            pInput = pInput.Replace("ü", "u");
            pInput = pInput.Replace("Ä", "A");
            pInput = pInput.Replace("Ë", "E");
            pInput = pInput.Replace("Ï", "I");
            pInput = pInput.Replace("Ö", "O");
            pInput = pInput.Replace("Ü", "U");

            return pInput.Trim();
        }

        /// <summary>
        /// Este método tem a função de retirar todo tipo de caracteres especiais, exemplos: ">", "&" e "*".
        /// </summary>
        public static string RetirarCaracteresEspeciais(string pInput)
        {

            pInput = pInput.Replace("|", "");
            pInput = pInput.Replace("\\", "");
            pInput = pInput.Replace("<", "");
            pInput = pInput.Replace(",", "");
            pInput = pInput.Replace(">", "");
            pInput = pInput.Replace(".", "");
            pInput = pInput.Replace(":", "");
            pInput = pInput.Replace(";", "");
            pInput = pInput.Replace("?", "");
            pInput = pInput.Replace("/", "");
            pInput = pInput.Replace("°", "");
            pInput = pInput.Replace("^", "");
            pInput = pInput.Replace("~", "");
            pInput = pInput.Replace("}", "");
            pInput = pInput.Replace("]", "");
            pInput = pInput.Replace("º", "");
            pInput = pInput.Replace("`", "");
            pInput = pInput.Replace("´", "");
            pInput = pInput.Replace("{", "");
            pInput = pInput.Replace("[", "");
            pInput = pInput.Replace("ª", "");
            pInput = pInput.Replace("\"", "");
            pInput = pInput.Replace("'", "");
            pInput = pInput.Replace("!", "");
            pInput = pInput.Replace("¹", "");
            pInput = pInput.Replace("@", "");
            pInput = pInput.Replace("²", "");
            pInput = pInput.Replace("#", "");
            pInput = pInput.Replace("³", "");
            pInput = pInput.Replace("$", "");
            pInput = pInput.Replace("£", "");
            pInput = pInput.Replace("%", "");
            pInput = pInput.Replace("¢", "");
            pInput = pInput.Replace("¨", "");
            pInput = pInput.Replace("¬", "");
            pInput = pInput.Replace("&", "");
            pInput = pInput.Replace("*", "");
            pInput = pInput.Replace("(", "");
            pInput = pInput.Replace(")", "");
            pInput = pInput.Replace("_", "");
            pInput = pInput.Replace("-", "");
            pInput = pInput.Replace("+", "");
            pInput = pInput.Replace("=", "");
            pInput = pInput.Replace("§", "");

            return pInput.Trim();
        }

        /// <summary>
        /// Este método tem a função de retirar todo tipo de caracteres especiais e acentos, exemplos: "´", "`", "^", "~", "¨", ">", "?"
        /// </summary>
        public static string RetirarSinalGraficoECaracteresEspeciais(string pInput)
        {

            return RetirarSinalGrafico(RetirarCaracteresEspeciais(pInput)).Trim();
        }

        /// <summary>
        /// Este método tem a função de retornar o primeiro e o último nome da pessoa.
        /// </summary>
        /// <param name="pNome">Nome completo da pessoa</param>
        /// <returns>Primeiro e o último nome</returns>
        public static string ObterPrimeiroUltimoNome(string pNome)
        {
            int primeiro, segundo, terceiro;
            string completo;
            string nome1, nome2, nome3, nome4;

            primeiro = pNome.IndexOf(" ");

            nome1 = pNome.Substring(0, primeiro + 1);
            nome2 = pNome.Substring(primeiro + 1, (pNome.Length - (primeiro + 1)));

            completo = nome1.Trim() + " " + nome2;

            segundo = nome2.IndexOf(" ");

            if (segundo > 0)
            {
                nome3 = nome2.Substring(segundo + 1, (nome2.Length - (segundo + 1)));
                nome2 = nome2.Substring(0, segundo);

                if (nome2.Length <= 3)
                {
                    terceiro = nome3.IndexOf(" ");

                    if (terceiro > 0)
                    {
                        // achei um espaço
                        nome4 = nome3.Substring(0, terceiro + 1);
                        completo = nome1.Trim() + " " + nome2 + " " + nome4.Trim();
                    }
                    else
                    {
                        // n achei, terminou o nome

                        completo = nome1.Trim() + " " + nome2 + " " + nome3;
                    }
                }
                else
                {
                    completo = nome1.Trim() + " " + nome2.Substring(0, segundo);
                }
            }

            return completo;
        }
    }
}