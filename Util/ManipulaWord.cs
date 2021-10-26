using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace Util

{
    public class ManipulaWord
    {
        public void PreencherPorReplace(List<Parametro> pParametros, string pDiretorioDoArquivo, string pNomeDoAqruivo)
        {
            //Objeto a ser usado nos parâmetros opcionais
            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado
            Word.Application oApp = new Word.Application();
            object template = pDiretorioDoArquivo + "\\" + pNomeDoAqruivo + ".docx";
            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags
            Word.Range oRng = null;
            object MatchWholeWord = true;
            object Forward = false;

            #region PARAMETROS

            //DECLARACAO
            object FindText;
            object ReplaceWith;

            //REPLACES
            foreach (var Parametro in pParametros)
            {
                oRng = oDoc.Range(ref missing, ref missing);
                FindText = Parametro.CodigoParaReplace;
                ReplaceWith = Parametro.TextoParaReplace;
                oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward,
                ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);                
            }

            #endregion

            oApp.Visible = true;
        }
    }

    /// <summary>
    /// Esta classe é para referência do replace.
    /// CodigoParaReplace = string dentro do carquivo que deve ser trocada pelo TextoParaReplace.
    /// </summary>
    public class Parametro
    {
        public string CodigoParaReplace { get; set; }
        public string TextoParaReplace { get; set; }
    }
}
