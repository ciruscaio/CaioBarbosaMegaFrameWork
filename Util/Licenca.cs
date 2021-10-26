using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APT.Util
{
    public class Licenca
    {
        private static bool VerificarLicensaTrialExpirou(int pDiaInicio, int pMesInicio, int pAnoInicio_AAAA)
        {
            try
            {
                DateTime DataInicio = new DateTime(pAnoInicio_AAAA, pMesInicio, pDiaInicio);

                if (DateTime.Now > DataInicio)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                //Se falhar não autoriza
                return true;
            }
        }

        public static void ValidarLicensaTrial(DateTime pDataInicio, DateTime pDataFim)
        {
            if (DateTime.Now < pDataInicio)
            {
                throw new Exception("Versão trial ainda não liberada!");
            }

            if (DateTime.Now > pDataFim)
            {
                throw new Exception("Versão trial expirou!");
            }
        }
    }
}
