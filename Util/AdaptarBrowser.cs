using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Util.Web
{
    public class AdaptarBrowser : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        //Faz com que o .NET renderize correto no browser Chrome
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Page.Request.ServerVariables["http_user_agent"].ToLower().Contains("safari"))
            {
                Page.ClientTarget = "uplevel";
            }
        }

        public AdaptarBrowser()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}