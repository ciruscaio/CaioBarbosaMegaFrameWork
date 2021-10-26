using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Diretorio
    {
        public static bool VerificaSeExisteDiretorio(string pDiretorio)
        {
            DirectoryInfo dir = new DirectoryInfo(pDiretorio);
            if (dir.Exists)
                return true;
            else
                return false;
        }

        public static void CriaDiretorio(string pDiretorio)
        {
            if (VerificaSeExisteDiretorio(pDiretorio) == false)
            {
                System.IO.Directory.CreateDirectory(pDiretorio);
            }
        }
    }
}
