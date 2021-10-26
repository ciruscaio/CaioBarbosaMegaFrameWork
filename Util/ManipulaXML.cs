using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Web;
using System.Reflection;
using System.Linq;

namespace CameraOnline
{
    public class ManipulaXML
    {
        //#region OLD
        ////private string diretorioAtual = Directory.GetCurrentDirectory().ToString() + "\\Tabelas\\";      
        ////private string diretorioAtual = "C:\\Inetpub\\wwwroot\\Tabelas\\";        
        ////private string diretorioAtual = (Session["PastaRaiz"]) + "\\Tabelas\\";
        //#endregion

        ////private string diretorioAtual = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";
        //private string diretorioAtual = Path.GetDirectoryName(Assembly.GetAssembly(typeof(CameraOnline.Default)).CodeBase).Replace("file:\\", "").Replace("\\bin", "") + "\\Tabelas\\"; 

        //public static ManipulaXML getManipulaXML()
        //{
        //    return new ManipulaXML();
        //}

        //#region USUÁRIO 
        
        //#region INTERNO

        //private void wUsuarios(List<Usuario> pUsuarios)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
        //    StreamWriter writer = new StreamWriter(diretorioAtual + "usuario.xml");
        //    serializer.Serialize((TextWriter)writer, pUsuarios);
        //    writer.Close();
        //}

        //private void CreateAdministrador()
        //{
        //    if (!File.Exists(diretorioAtual + "usuario.xml"))
        //    {
        //        List<Usuario> lUsuarios = new List<Usuario>();
        //        Usuario lUsuario = new Usuario();
        //        lUsuario.Nome = "Administrador";
        //        lUsuario.Email = "ciruscaio@gmail.com";
        //        lUsuario.CPF = "04954701473";
        //        lUsuario.Login = "administrar";
        //        lUsuario.Senha = "a1b2c3d4e5";
        //        lUsuario.Grupo = "CPM-B3-04A";
        //        lUsuario.Ativo = true;
        //        lUsuario.Administrador = true;
        //        lUsuarios.Add(lUsuario);

        //        wUsuarios(lUsuarios);
        //    }
        //}

        //private List<Usuario> ReordenarUsuarios(List<Usuario> pUsuarios)
        //{
        //    return pUsuarios.OrderBy(p => p.Nome).ToList();
        //}

        //#endregion

        //public List<Usuario> Usuarios_Listar()
        //{
        //    CreateAdministrador();

        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
        //    StreamReader textReader = new StreamReader(diretorioAtual + "usuario.xml");
        //    List<Usuario> Usuarios = serializer.Deserialize(textReader) as List<Usuario>;
        //    textReader.Close();
        //    return ReordenarUsuarios(Usuarios);
        //}

        //public void Usuarios_Incluir(List<Usuario> pUsuarios)
        //{
        //    //Lê e Atualiza
        //    pUsuarios.AddRange(Usuarios_Listar());

        //    //Reordena
        //    pUsuarios = ReordenarUsuarios(pUsuarios);

        //    //Grava
        //    wUsuarios(pUsuarios);
        //}

        //public void Usuarios_Incluir(Usuario pUsuarios)
        //{
        //    //Cria coleção
        //    List<Usuario> lUsuarios = Usuarios_Listar();

        //    //Lê e Atualiza
        //    lUsuarios.Add(pUsuarios);

        //    //Reordena
        //    lUsuarios = ReordenarUsuarios(lUsuarios);

        //    //Grava
        //    wUsuarios(lUsuarios);
        //}

        //public void Usuarios_Atualizar(Usuario pUsuario)
        //{
        //    //Lê e Atualiza
        //    List<Usuario> lUsuarios  = Usuarios_Listar();

        //    //Encontra usuário e atualiza os daados
        //    foreach (var fUsuario in lUsuarios)
        //    {
        //        if (fUsuario.Login == pUsuario.Login)
        //        {
        //            fUsuario.Nome = pUsuario.Nome;
        //            fUsuario.Email = pUsuario.Email;
        //            fUsuario.CPF = pUsuario.CPF;
        //        }
        //    }

        //    //Grava
        //    wUsuarios(lUsuarios);
        //}

        //#endregion
    }
}
