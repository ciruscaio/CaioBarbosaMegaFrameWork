using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;

namespace Util
{
    /// <summary>
    /// Classe utilitária para montar um grid view sem fazer referências ao seu cabeçalho.
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// Carrega o grid com a fonte de dados escolhida, sem precisar preencher o Grid antecipadamente com seus devidos cabeçalhos.
        /// Este método faz o papel do DataSource e do DataBind.
        /// </summary>
        /// <param name="pFonteDeDados">Fonte de dados que preencherá o grid.</param>
        /// <param name="pGridView">Grid que receberá os dados.</param>
        public static void CarregarGrid(DataTable pFonteDeDados, GridView pGridView)
        {
            if ((pFonteDeDados != null) && (pGridView != null))
            {
                AdicionarCabecalhosAoGrid(GetListaDeCabecalhos(pFonteDeDados), pGridView).DataSource = pFonteDeDados;
                pGridView.DataBind();
            }
        }

        private static GridView AdicionarCabecalhosAoGrid(List<string> pCabecalhos, GridView pGridView)
        {
            //Limpando
            pGridView.DataSource = null;
            pGridView.DataBind();

            //Carregando
            BoundField lColuna = null;

            for (int i = 0; i < pCabecalhos.Count; i++)
            {
                if (!ExiteEstaColunaNoGridView(pCabecalhos[i].ToString(), pGridView))
                {
                    lColuna = new BoundField();

                    lColuna.DataField = pCabecalhos[i].ToString();
                    lColuna.HeaderText = pCabecalhos[i].ToString();

                    pGridView.Columns.Add(lColuna);
                }
            }

            return pGridView;
        }

        private static List<string> GetListaDeCabecalhos(DataTable pDataTable)
        {
            List<string> lCabecalhos = new List<string>(); ;

            if (pDataTable.Rows.Count > 0)
            {
                for (int i = 0; i < pDataTable.Columns.Count; i++)
                {
                    lCabecalhos.Add(pDataTable.Columns[i].ColumnName.Trim());
                }
            }

            return lCabecalhos;
        }

        private static bool ExiteEstaColunaNoGridView(string pNomeDaColuna, GridView pGridView)
        {
            for (int i = 0; i < pGridView.Columns.Count; i++)
            {
                if (pGridView.Columns[i].ToString() == pNomeDaColuna)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
