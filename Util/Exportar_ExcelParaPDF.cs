using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

namespace Util
{
    /// <summary>
    /// Classe utiitária com o objetivo de gerar arquivos para download.
    /// </summary>
    public class Exportar_ExcelParaPDF
    {
        /// <summary>
        /// Este método tem a função de gerar um arquivo excel com base no DataTable passado por parâmetro.
        /// </summary>
        /// <param name="pDataTable">DataTable que contém as informações que irão pro arquivo excel gerado.</param>
        public static void Exportar(DataTable pDataTable)
        {
            if (pDataTable.Rows.Count > 65535)
            {
                throw new Exception("O excel não suporte a quantidade de registro encontrados!");
            }

            HttpResponse lResponse = HttpContext.Current.Response;
            lResponse.ClearContent();
            lResponse.AddHeader("Content-Disposition", "attachment; filename=Excel-" + DateTime.Now.ToString("dd-MM-yyyy hh-mm") + ".xls");
            lResponse.ContentType = "application/vnd.ms-excel";

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);

            DataGrid lDataGrid = new DataGrid();
            lDataGrid.DataSource = pDataTable;
            lDataGrid.DataBind();

            lDataGrid.HeaderStyle.BackColor = Color.FromArgb(31, 73, 125);
            lDataGrid.HeaderStyle.ForeColor = Color.FromArgb(238, 236, 225);
            lDataGrid.HeaderStyle.Font.Name = "Calibri";
            lDataGrid.HeaderStyle.Font.Size = 11;

            lDataGrid.ItemStyle.Font.Name = "Calibri";
            lDataGrid.ItemStyle.Font.Size = 11;

            lDataGrid.RenderControl(htmlWrite);
            lResponse.Write(stringWrite.ToString());
            lResponse.End();
        }
    }
}
