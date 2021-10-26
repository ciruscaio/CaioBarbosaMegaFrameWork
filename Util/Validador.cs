using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    /// <summary>
    /// Classe utilitária com o objetivo validar valores específico.
    /// </summary>
    public class Validador
    {
        /// <summary>
        /// Esse metodo tem a função de verificar se o valor passado por parâmetro corresponde
        /// a um CPF válido
        /// </summary>
        /// <param name="valor">string que representa um CPF</param>
        /// <returns>True, se o CPF for valido, caso contrário, False.</returns>
        public static bool ValidarCPF(string valor)
        {
            valor = StringFormatador.RetirarMascara(valor);

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                 valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                    return false;

            return true;
        }

        /// <summary>
        /// Esse metodo tem a função de verificar se o valor passado por parâmetro corresponde
        /// a um CNPJ válido
        /// </summary>
        /// <param name="vrCNPJ">string que representa um CNPJ</param>
        /// <returns>True, se o CNPJ for valido, caso contrário, False.</returns>
        public static bool ValidaCNPJ(string vrCNPJ)
        {
            string CNPJ = StringFormatador. RetirarMascara(vrCNPJ);

            int[] digitos, soma, resultado;

            int nrDig;

            string ftmt;

            bool[] CNPJOk;

            ftmt = "6543298765432";

            digitos = new int[14];

            soma = new int[2];

            soma[0] = 0;

            soma[1] = 0;

            resultado = new int[2];

            resultado[0] = 0;

            resultado[1] = 0;

            CNPJOk = new bool[2];

            CNPJOk[0] = false;

            CNPJOk[1] = false;

            try
            {

                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(

                        CNPJ.Substring(nrDig, 1));

                    if (nrDig <= 11)

                        soma[0] += (digitos[nrDig] *

                          int.Parse(ftmt.Substring(

                          nrDig + 1, 1)));

                    if (nrDig <= 12)

                        soma[1] += (digitos[nrDig] *

                          int.Parse(ftmt.Substring(

                          nrDig, 1)));

                }


                for (nrDig = 0; nrDig < 2; nrDig++)
                {

                    resultado[nrDig] = (soma[nrDig] % 11);

                    if ((resultado[nrDig] == 0) || (

                         resultado[nrDig] == 1))

                        CNPJOk[nrDig] = (

                        digitos[12 + nrDig] == 0);

                    else

                        CNPJOk[nrDig] = (

                        digitos[12 + nrDig] == (

                        11 - resultado[nrDig]));

                }

                return (CNPJOk[0] && CNPJOk[1]);

            }

            catch
            {

                return false;

            }

        }

        /// <summary>
        /// Esse metodo tem a função de verificar se o valor passado por parâmetro corresponde
        /// a uma data válida
        /// </summary>
        /// <param name="data">string que representa uma Data</param>
        /// <returns>True, se a Data for valida, caso contrário, False.</returns>
        public static bool ValidaData(string data)
        {
            DateTime lData;

            if (DateTime.TryParse(data, out lData) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Esse método, tem a função de verificar se uma pessoa, de acordo com sua data de nascimento,
        /// terá na data de referencia, a idade de referencia.
        /// </summary>
        /// <param name="pDataNascimento">Data de nascimento do individuo.</param>
        /// <param name="pDataReferencia">Data de Referencia, ou seja, data na qual deve-se ter a idade de referencia.</param>
        /// <param name="pIdadeReferencia">Idade de Referencia, ou seja, idade que o individuo terá que ter.</param>
        /// <returns>Verdadeiro se o indivíduo tiver a idade de referencia e falso do contrário.</returns>
        public static bool ValidaIdade(DateTime pDataNascimento, DateTime pDataReferencia, byte pIdadeReferencia)
        {
            int idade = pDataReferencia.Year - pDataNascimento.Year;
            if (pDataReferencia.Month < pDataNascimento.Month || (pDataReferencia.Month == pDataNascimento.Month && pDataReferencia.Day < pDataNascimento.Day))
            {
                idade--;
            }

            if (idade >= pIdadeReferencia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Esse metodo tem a função de verificar se o ano passado por parâmetro corresponde
        /// a um ano Bissexto
        /// </summary>
        /// <param name="ano">int que representa um Ano</param>
        /// <returns>True, se o Ano for Bissexto, caso contrário, False.</returns>
        public static bool ValidaBissexto(int ano)
        {
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                return true;
            else
                return false;
        }

        public static bool ValidarEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }
    }
}
