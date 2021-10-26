using System;
using System.Web.UI;

namespace Util.Web
{
    //referencia: http://www.linhadecodigo.com.br/Artigo.aspx?id=2726

    //Substituição do uso do ClientScript para o ScriptManager feita por Wivison

    /// <summary>
    /// Classe utilitária com o objetivo de exibir mensagens em popup numa página com ou sem UpdatePanel.
    /// </summary>
    public abstract class Mensagem
    {
        /// <summary>
        /// Este método tem a função de exibir uma mensagem Alert.
        /// </summary>
        /// <param name="msg">Mensagem a ser exibida.</param>
        /// <param name="page">Página que está invocando o método (this ou this.Page).</param>
        /// <example>Mensagem.ExibirMensagem("O CPF informado é inválido!", this.Page);</example>
        public static void ExibirMensagem(string msg, Page page)
        {
            // Caso haja aspas na mensagem, mudo para aspas simples
            msg = msg.Replace("\"", "'");

            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                string.Format("window.alert(\"{0}\");", msg), true);
        }

        /// <summary>
        /// Este método tem a função de exibir uma mensagem Alert e transfere para uma página.
        /// </summary>
        /// <param name="msg">Mensagem a ser exibida.</param>
        /// <param name="url">Nome da página de destino.</param>
        /// <param name="page">Página que está invocando o método (this ou this.Page).</param>
        /// <example>Mensagem.ExibirMensagem("O CPF informado é inválido!", "webCnsCPF.aspx", this.Page);</example>
        public static void ExibirMensagem(string msg, string url, Page page)
        {
            // Caso haja aspas na mensagem, mudo para aspas simples
            msg = msg.Replace("\"", "'");

            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                string.Format("window.alert(\"{0}\");window.location=\"{1}\";", msg, url), true);
        }

        /// <summary>
        /// Este método tem a função de exibir uma mensagem Alert e voltar n páginas,
        /// como se o usuário clicasse n vezes no botão voltar do browser.
        /// </summary>
        /// <param name="msg">Mensagem a ser exibida.</param>
        /// <param name="qtd">Quantidade de páginas do history back.</param>
        /// <param name="page">Página que está invocando o método (this ou this.Page).</param>
        public static void ExibirMensagem(string msg, int qtd, Page page)
        {
            // Caso haja aspas na mensagem, mudo para aspas simples
            msg = msg.Replace("\"", "'");

            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                string.Format("window.alert(\"{0}\");history.go(-{1});", msg, qtd), true);
        }

        /// <summary>
        /// Este método tem a função de exibir uma mensagem Alert e fechar a janela atual.
        /// </summary>
        /// <param name="msg">Mensagem a ser exibida.</param>
        /// <param name="fechar">true ou false: Se true exibe a mensagem e fecha a janela;
        /// Se false não faz nada.</param>
        /// <param name="page">Página que está invocando o método (this ou this.Page).</param>
        public static void ExibirMensagem(string msg, bool fechar, Page page)
        {
            // Se for definido para fechar a janela
            if (fechar)
            {
                // Caso haja aspas na mensagem, mudo para aspas simples
                msg = msg.Replace("\"", "'");

                ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                    string.Format("window.alert(\"{0}\");window.close();", msg), true);
            }
        }

        /// <summary>
        /// Este método tem a função de exibir uma mensagem Alert e transfere para uma página.
        /// </summary>
        /// <param name="msg">Mensagem a ser exibida.</param>
        /// <param name="url">Nome da página de destino.</param>
        /// <param name="page">Página que está invocando o método (this ou this.Page).</param>
        /// <example>Mensagem.ExibirMensagem("O CPF informado é inválido!", "webCnsCPF.aspx", this.Page);</example>
        public static void ExibirMensagem(string msg, string url, string target, Page page)
        {
            // Caso haja aspas na mensagem, mudo para aspas simples
            msg = msg.Replace("\"", "'");

            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(),
                string.Format("window.alert(\"{0}\");{1}.location=\"{2}\";", msg, target, url), true);
        }
    }
}
