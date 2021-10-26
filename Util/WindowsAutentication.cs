using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

/// <summary>
/// Summary description for AdaptarBrowser
/// </summary>
public class WindowsAutentication
{
    private string dominio;
    private string usuario;

    public string Dominio
    {
        get { return dominio; }
        set { dominio = value; }
    }
    public string Usuario
    {
        get { return usuario; }
        set { usuario = value; }
    }

    public WindowsAutentication()
    {
        this.dominio = obterDominioDoWindowsAutentication();
        this.usuario = obterUsuarioDoWindowsAutentication();
    }
    
    private string obterDominioDoWindowsAutentication()
    {
        string[] login = (HttpContext.Current.User.Identity.Name).Split(new Char[] { '\\' });
        return login[0];        
    }

    private string obterUsuarioDoWindowsAutentication()
    {
        string[] login = (HttpContext.Current.User.Identity.Name).Split(new Char[] { '\\' });
        return login[1];
    }
}
