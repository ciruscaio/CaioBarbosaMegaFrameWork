using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace Util.Web
{
    /// <summary>
    /// Classe utilitária com o objetivo de fazer tranferência de uma página para outra, feito o Server.Transfer,
    /// a diferença é que funciona também em páginas com UpdatePanel, sem a necessidade de declarar o Objeto como um PostBackControl.
    /// </summary>
    public static class Pagina
    {
        /// <summary>
        /// Este método tem a função de tranferir de uma página para outra.
        /// </summary>
        /// <param name="url">Página de destino.</param>
        /// <param name="page">Página que está invocando este método (this ou this.Page).</param>
        /// /// <example>Pagina.Transfer("webCadAluno.aspx", this.Page);
        /// Transfere para uma página do mesmo nível da página de origem.</example>
        /// <example>Pagina.Transfer("./webCadAluno.aspx", this.Page);
        /// Transfere para uma página do mesmo nível da página de origem.</example>
        /// <example>Pagina.Transfer("./admin/webCadAluno.aspx", this.Page);
        /// Transfere para uma página de um nível acima da página de origem.</example>
        /// <example>Pagina.Transfer("../admin/webCadAluno.aspx", this.Page);
        /// Transfere para uma página de um nível abaixo da página de origem.</example>
        public static void Transfer(string url, Page page)
        {
            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                string.Format("window.location=\"{0}\";", url), true);
        }

        /// <summary>
        /// Este método tem a função de abrir uma dada PÁGINA num determinado ALVO.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="target">Objeto PÁGINA.</param>
        /// <param name="page">Página que está invocando este método (this ou this.Page).</param>
        /// /// <example>Pagina.Transfer("webCadAluno.aspx", "iframeMain", this.Page);
        /// Abre a PÁGINA webCadAluno.aspx no IFRAME de nome iframeMain.</example>     
        public static void Transfer(string url, string target, Page page)
        {
            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                string.Format("{0}.location=\"{1}\";", target, url), true);
        }

        /// <summary>
        /// Este método tem a função de abrir uma nova página.
        /// </summary>
        /// <param name="url">Página a ser aberta.</param>
        /// <param name="page">Página que está invocando este método (this ou this.Page).</param>
        /// <example>Pagina.Open("webCadAluno.aspx", this.Page);
        /// Abre a página webCadAluno.aspx, que está no mesmo nível da página de origem, em uma nova janela do browser.</example>
        /// <example>Pagina.Open("./webCadAluno.aspx", this.Page);
        /// Transfere para uma página do mesmo nível da página de origem.</example>
        /// <example>Pagina.Transfer("./admin/webCadAluno.aspx", this.Page);
        /// Transfere para uma página de um nível acima da página de origem.</example>
        /// <example>Pagina.Transfer("../admin/webCadAluno.aspx", this.Page);
        /// Transfere para uma página de um nível abaixo da página de origem.</example>
        public static void Open(string url, Page page)
        {
            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                string.Format("window.open(\"{0}\");", url), true);
        }
    }
}
