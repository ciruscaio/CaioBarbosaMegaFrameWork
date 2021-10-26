using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Arquivo
    {
        public static bool VerificaSeExisteArquivo(string pArquivo)
        {
            FileInfo file = new FileInfo(pArquivo);

            if (file.Exists)
                return true;
            else
                return false;
        }

        public static void CriaArquivo(string pArquivo)
        {
            if (VerificaSeExisteArquivo(pArquivo) == false)
            {
                System.IO.File.Create(pArquivo);
            }

        }

        public static void DeletarArquivo(string pArquivo)
        {
            if (VerificaSeExisteArquivo(pArquivo) == true)
            {
                System.IO.File.Delete(pArquivo);
            }
        }

        public static void MoverArquivo(string pArquivo, string pDestino)
        {
            if (VerificaSeExisteArquivo(pArquivo) == true)
            {
                System.IO.File.Move(pArquivo, pDestino);
            }
        }

        public static void CopiarArquivo(string pArquivoOriginal, string pPastaDestino, string pNomeNovoArquivo, string pExtencao)
        {

            if (VerificaSeExisteArquivo(pArquivoOriginal))
            {
                if (string.IsNullOrEmpty(pPastaDestino))
                {
                    if (VerificaSeExisteArquivo(System.IO.Path.GetDirectoryName(pArquivoOriginal) + "\\" + pNomeNovoArquivo + pExtencao))
                    {
                        DeletarArquivo(System.IO.Path.GetDirectoryName(pArquivoOriginal) + "\\" + pNomeNovoArquivo + pExtencao);
                    }
                    System.IO.File.Copy(pArquivoOriginal, System.IO.Path.GetDirectoryName(pArquivoOriginal) + "\\" + pNomeNovoArquivo + pExtencao);
                }
                else
                {
                    if (VerificaSeExisteArquivo(pPastaDestino + "\\" + pNomeNovoArquivo + pExtencao))
                    {
                        DeletarArquivo(pPastaDestino + "\\" + pNomeNovoArquivo + pExtencao);
                    }
                    System.IO.File.Copy(pArquivoOriginal, pPastaDestino + "\\" + pNomeNovoArquivo + pExtencao);
                }
            }
        }
    }
}
