using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;
using iTextSharp.text.html.simpleparser;
using System.Web.UI;

namespace SEEHtmlToPDF
{
    public class Exportar_HTMLParaPDF
    {        
        public static void GerarEGravarPdfApartirDePaginaHtml(string pNomeDaPagina, string pFileName, string pAutor, string pAssunto, Page pPagina)
        {
            if (!string.IsNullOrEmpty(pNomeDaPagina) && !string.IsNullOrEmpty(pFileName) && !string.IsNullOrEmpty(pAutor) && !string.IsNullOrEmpty(pAssunto) && pPagina != null)
            {
                try
                {
                    string Html = ObterHtmlDaPagina(pNomeDaPagina, pPagina);

                    HttpContext.Current.Response.Clear();
                    HttpContext.Current.Response.AddHeader("content-disposition", string.Format("attachment;filename={0}.pdf", pFileName));
                    HttpContext.Current.Response.Charset = string.Empty;
                    HttpContext.Current.Response.ContentType = "application/pdf";
                    HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
                    pPagina.EnableViewState = false;

                    Document document = new Document();
                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);
                    document.AddAuthor(pAutor);
                    document.AddSubject(pAssunto);
                    document.Open();

                    string tempFile = Path.GetTempFileName();

                    using (StreamWriter tempwriter = new StreamWriter(tempFile, false))
                    {
                        tempwriter.Write(Html);
                    }

                    using (StreamReader tempReader = new StreamReader(tempFile))
                    {
                        ArrayList array = HTMLWorker.ParseToList(tempReader, new StyleSheet());

                        for (int i = 0; i < array.Count - 1; i++)
                        {
                            document.Add((IElement)array[i]);
                        }
                    }

                    document.Close();
                    pdfWriter.Close();

                    File.Delete(tempFile);
                    HttpContext.Current.Response.Flush();
                }
                catch
                {
                    throw new Exception("Erro ao gerar arquivo PDF.");
                }
            }


        }

        public static void GerarEGravarPdfApartirDeHtml(string pHtml, string pFileName, string pAutor, string pAssunto, Page pPagina)
        {
            if (!string.IsNullOrEmpty(pHtml) && !string.IsNullOrEmpty(pFileName) && !string.IsNullOrEmpty(pAutor) && !string.IsNullOrEmpty(pAssunto) && pPagina!= null)
            {
                try
                {
                    HttpContext.Current.Response.Clear();
                    HttpContext.Current.Response.AddHeader("content-disposition", string.Format("attachment;filename={0}.pdf", pFileName));
                    HttpContext.Current.Response.Charset = string.Empty;
                    HttpContext.Current.Response.ContentType = "application/pdf";
                    HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
                    pPagina.EnableViewState = false;

                    Document document = new Document();
                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);
                    document.AddAuthor(pAutor);
                    document.AddSubject(pAssunto);
                    document.Open();

                    string tempFile = Path.GetTempFileName();

                    using (StreamWriter tempwriter = new StreamWriter(tempFile, false))
                    {
                        tempwriter.Write(pHtml);
                    }

                    using (StreamReader tempReader = new StreamReader(tempFile))
                    {
                        ArrayList array = HTMLWorker.ParseToList(tempReader, new StyleSheet());

                        for (int i = 0; i < array.Count - 1; i++)
                        {
                            document.Add((IElement)array[i]);
                        }
                    }

                    document.Close();
                    pdfWriter.Close();

                    File.Delete(tempFile);
                    HttpContext.Current.Response.Flush();
                }
                catch
                {
                    throw new Exception("Erro ao gerar arquivo PDF.");
                }
            }


        }

        //MÉTODOS INTERNOS
        private static string ObterPastaVirtualDaAplicacao(Page pPagina)
        {
            string Url = pPagina.Request.Url.AbsoluteUri;
            string Arquivo = pPagina.Request.Url.AbsolutePath;
            return Url.Remove(Url.IndexOf(Arquivo)) + "/";
        }

        private static string ObterHtmlDaPagina(string NomeDaPagina, Page pPagina)
        {
            System.Net.WebClient wc = new System.Net.WebClient();

            if (NomeDaPagina.Contains(".aspx"))
            {
                return wc.DownloadString(ObterPastaVirtualDaAplicacao(pPagina) + NomeDaPagina).ToString();
            }
            else
            {
                return wc.DownloadString(ObterPastaVirtualDaAplicacao(pPagina) + NomeDaPagina + ".aspx").ToString();
            }
        }
    }
}
