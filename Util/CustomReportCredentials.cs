using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
﻿using System.Net;

namespace Util
{
    /// <summary>
    /// Classe responsável por autenticar o usuário do Reporing Server pela aplicação
    /// </summary>
    public class CustomReportCredentials : Microsoft.Reporting.WebForms.IReportServerCredentials
    {
        private string mUserName;
        private string mPassWord;
        private string mDomainName;

        /// <summary>
        /// Construtor da calsse que recebe os parâmetros de autenticação.
        /// </summary>
        /// <param name="UserName">Usuário de Autenticação do Windows cadastrado no Reporting Server</param>
        /// <param name="PassWord">Senha de Autenticação do Windows cadastrado no Reporting Server</param>
        /// <param name="DomainName">Domínio do Usuário no Windows</param>
        public CustomReportCredentials(string UserName, string PassWord, string DomainName)
        {
            mUserName = UserName;
            mPassWord = PassWord;
            mDomainName = DomainName;
        }

        #region IReportServerCredentials Members

        bool Microsoft.Reporting.WebForms.IReportServerCredentials.GetFormsCredentials(out Cookie authCookie, out string userName, out string password, out string authority)
        {
            // not use FormsCredentials unless you have implements a custom autentication.
            authCookie = null;
            userName = password = authority = null;
            return false;
        }

        System.Security.Principal.WindowsIdentity Microsoft.Reporting.WebForms.IReportServerCredentials.ImpersonationUser
        {
            get
            {
                return null;  // not use ImpersonationUser
            }
        }

        ICredentials Microsoft.Reporting.WebForms.IReportServerCredentials.NetworkCredentials
        {
            get
            {
                // use NetworkCredentials
                return new NetworkCredential(mUserName, mPassWord, mDomainName);
            }
        }

        #endregion

    }
}
