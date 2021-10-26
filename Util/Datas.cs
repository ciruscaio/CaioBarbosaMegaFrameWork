using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Datas
    {
        private static double DiferencaDeDatas_QuantidadeDeSegundos(DateTime pData_Fim, DateTime pData_Inicio)
        {
            TimeSpan lDiferenca = (pData_Fim - pData_Inicio);
            return lDiferenca.TotalSeconds;
        }
    }
}
