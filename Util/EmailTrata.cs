using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObterEmails.Util
{
    public class TrataEmail
    {
        public static TrataEmail ObterTrataEmail()
        {
            return new TrataEmail();
        }

        public ArrayList ObterDominios()
        {
            ArrayList Dominios = new ArrayList()
                {
                     ".com"
                    ,".br"
                    ,".org"
                    ,".gov"
                    ,".net"
                    ,".tv"
                    ,".biz"
                    ,".cc"
                    ,".info"

                };

            return Dominios;
        }

        public bool ValidarEmail(string pEmail)
        {
            //VALIDA, VIA EXPRESSÃO REGULAR
            Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (regex.IsMatch(pEmail))
            {
                return true;
            }

            return false;
        }

        public string ObtemEmailValidoDeUmaString(string pString)
        {
            int Aux = 0;
            string Email = string.Empty;

            foreach (var Dominio in ObterDominios())
            {
                Aux = pString.IndexOf(Dominio.ToString());

                if (Aux > -1)
                {
                    Email = pString.Substring(0, Aux + Dominio.ToString().Length);
                    break;
                }
            }

            if (ValidarEmail(Email))
            {
                return Email;
            }
            else
            {
                return string.Empty;
            }
        }

        public bool VerificarSeExisteEmailRepetidoNaLista(List<string> pEmailsEncontrados, string pEmail)
        {
            foreach (var Email in pEmailsEncontrados)
            {
                if (Email == pEmail)
                {
                    return true;
                }
            }

            return false;
        }

        public string RemoveCaracteresIndesejaveis(string pString)
        {
            pString = pString.Replace(@"+", " ");
            pString = pString.Replace(@"-", " ");
            pString = pString.Replace(@"_", " ");
            pString = pString.Replace(@"&", " ");
            pString = pString.Replace(@"%", " ");
            pString = pString.Replace(@"$", " ");
            pString = pString.Replace(@"#", " ");
            pString = pString.Replace(@"!", " ");
            pString = pString.Replace(@"=", " ");
            pString = pString.Replace(@",", " ");
            pString = pString.Replace(@";", " ");
            pString = pString.Replace(@":", " ");
            pString = pString.Replace(@"<", " ");
            pString = pString.Replace(@">", " ");
            pString = pString.Replace(@"[", " ");
            pString = pString.Replace(@"]", " ");
            pString = pString.Replace(@"(", " ");
            pString = pString.Replace(@")", " ");
            pString = pString.Replace(@"{", " ");
            pString = pString.Replace(@"}", " ");
            pString = pString.Replace(@"/", " ");
            pString = pString.Replace(@"|", " ");
            pString = pString.Replace(@"\", " ");
            pString = pString.Replace(@"?", " ");
            pString = pString.Replace(@"'", " ");
            pString = pString.Replace(@"*", " ");
            pString = pString.Replace(@"~", " ");
            pString = pString.Replace(@"´", " ");
            pString = pString.Replace(@"`", " ");
            pString = pString.Replace(@"^", " ");

            //Por último
            pString = pString.Replace(@"  ", " ");

            return pString;
        }
    }
}
