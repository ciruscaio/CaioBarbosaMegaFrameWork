using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Net;

namespace Conexao
{
    /// <summary>
    /// Classe com o objetivo de obter uma conexão com o Banco de Dados
    /// <example>
    /// String Conexão:
    ///     "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Arquivo_Diretorio + "\\" + Arquivo
    /// </example>
    /// </summary>
    public class DataBaseLocator_Access
    {
        private static readonly DataBaseLocator_Access instance = new DataBaseLocator_Access();
        private static bool gACEInstalado = false;
      
        private DataBaseLocator_Access()
        {
            if (gACEInstalado == false)
            {
                gACEInstalado = true;
                VerificaACE_BaixaEInstala();    
            }            
        }

        /// <summary>
        /// Propriedade que contém uma única instância da classe
        /// </summary>
        /// <returns>retorna uma única instância de DataBaseLocator</returns>
        public static DataBaseLocator_Access getInstance()
        {
            return instance;
        }

        /// <summary>
        /// Propriedade que faz a conexão com o Banco de Dados
        /// </summary>
        /// <returns>retorna um SqlConnection</returns>
        public OleDbConnection GetConnection()
        {
            string lAmbiente = ConfigurationManager.AppSettings["StringDeConexao"];

            if (String.IsNullOrEmpty(lAmbiente))
            {
                throw new Exception("A variável \"StringDeConexao\" não foi encontrada no arquivo de configuração (web.config)!");
            }
            else
            {
                return new OleDbConnection(ConfigurationManager.ConnectionStrings["StringDeConexao"].ConnectionString);
            }
        }


        #region OBTER ACE
        public void VerificaACE_BaixaEInstala()
        {
            try
            {
                //Obtem a lista de programas instalados
                ListView lListaDeProgramasInstalados = new ListView();

                Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.LocalMachine;

                Microsoft.Win32.RegistryKey subKey1 = regKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
                string[] subKeyNames = subKey1.GetSubKeyNames();

                foreach (string subKeyName in subKeyNames)
                {
                    Microsoft.Win32.RegistryKey subKey2 = subKey1.OpenSubKey(subKeyName);

                    if (ValueNameExists(subKey2.GetValueNames(), "DisplayName") &&
                    ValueNameExists(subKey2.GetValueNames(), "DisplayVersion"))
                    {
                        lListaDeProgramasInstalados.Items.Add(new ListViewItem(new string[] { subKey2.GetValue("DisplayName").ToString(), subKey2.GetValue("DisplayVersion").ToString() }));
                    }

                    subKey2.Close();
                }

                //Verifica o Se o ACE está instalados
                bool lInstalado = false;
                for (int i = 0; i < lListaDeProgramasInstalados.Items.Count; i++)
                {
                    if (lListaDeProgramasInstalados.Items[i].Text == "Microsoft Office Access database engine 2007 (English)")
                    {
                        lInstalado = true;
                    }
                }

                //Toma providencia de baixar e instalar se nao estiver na máquina o ACE
                if (lInstalado == false)
                {                   
                    //Pegar a pasta temporária do windows
                    string lDiretorioPastaTemp = System.Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);

                    //Baixar sincronamente
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("http://download.microsoft.com/download/2/4/3/24375141-E08D-4803-AB0E-10F2E3A07AAA/AccessDatabaseEngine.exe", lDiretorioPastaTemp + "\\AccessDatabaseEngine.exe");

                    //Instalar
                    System.Diagnostics.Process.Start(lDiretorioPastaTemp + "\\AccessDatabaseEngine.exe");
                }
            }
            catch
            {
                throw new Exception("ATENÇÃO! \n - Sua máquina não possui o componente ACE.OLEDB 12.0, que é necessário para executar o programa. \n\n AÇÃO TOMADA: \n > Automaticamente foi tentado baixar da internet, porém foi impossível. \n\n SUGESTÕES: \n > Verifique sua conexão e tente novamente. \n > Vá ao site da microsoft, baixe e instale manualmente o programa: Microsoft Access Database Engine 2010 Redistributable.");
                //Environment.Exit(0);
            }
        }

        private bool ValueNameExists(string[] valueNames, string valueName)
        {
            foreach (string s in valueNames)
            {
                if (s.ToLower() == valueName.ToLower()) return true;
            }

            return false;
        }
        #endregion
    }
}
