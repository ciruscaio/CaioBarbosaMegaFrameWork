using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Collections;

namespace Util.Web
{
    public class EmailEnviar
    {
        public static EmailEnviar ObterEnviarEmail()
        {
            return new EmailEnviar();
        }

        public void Enviar(Email pEmail)
        {
            //Cria objeto com dados do e-mail.
            MailMessage objEmail = new MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            objEmail.From = new System.Net.Mail.MailAddress(pEmail.NomeRemetente + "<" + pEmail.EmailRemetente + ">");

            //Define os destinatários do e-mail.
            objEmail.To.Add(pEmail.EmailDestinatario);

            //Enviar cópia para.
            if (pEmail.EmailComCopia != null)
            {
                objEmail.CC.Add(pEmail.EmailComCopia);
            }            

            //Enviar cópia oculta para.
            if (pEmail.EmailComCopiaOculta != null)
            {
                objEmail.Bcc.Add(pEmail.EmailComCopiaOculta);
            }
            
            //Define a prioridade do e-mail.
            objEmail.Priority = System.Net.Mail.MailPriority.Normal;

            //Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
            objEmail.IsBodyHtml = true;

            //Define título do e-mail.
            objEmail.Subject = pEmail.AssuntoMensagem;

            //Define o corpo do e-mail.
            objEmail.Body = pEmail.ConteudoMensagem;

            //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1"
            objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");

            // Caso queira enviar um arquivo anexo
            //Caminho do arquivo a ser enviado como anexo
            //if (pEmail.CaminhoArquivoAnexo != null)
            //{
            //    string arquivo = Server.MapPath("arquivo.jpg");
            //}
            

            // Ou especifique o caminho manualmente
            //string arquivo = @"e:\home\LoginFTP\Web\arquivo.jpg";

            // Cria o anexo para o e-mail
            //Attachment anexo = new Attachment(arquivo, System.Net.Mime.MediaTypeNames.Application.Octet);

            // Anexa o arquivo a mensagem
            //objEmail.Attachments.Add(anexo);

            //Cria objeto com os dados do SMTP
            System.Net.Mail.SmtpClient objSmtp = new System.Net.Mail.SmtpClient();

            //Alocamos o endereço do host para enviar os e-mails  
            objSmtp.Credentials = new System.Net.NetworkCredential(pEmail.EmailRemetente, pEmail.Senha);
            objSmtp.Host = pEmail.SMTP;
            objSmtp.Port = 587;

            //Enviamos o e-mail através do método .send()
            objSmtp.Send(objEmail);
        }
    }

    public class Email
    {
        //Define os dados do e-mail
        public string NomeRemetente {get;set;}
        public string EmailRemetente { get; set; }
        public string Senha { get; set; }

        //Host da porta SMTP
        public string SMTP { get; set; }

        public string EmailDestinatario { get; set; }
        public string EmailComCopia { get; set; }
        public string EmailComCopiaOculta { get; set; }

        public string AssuntoMensagem { get; set; }
        public string ConteudoMensagem { get; set; }

        //Anexo
        //public string CaminhoArquivoAnexo { get; set; }

        public static Email ObterEmail()
        {
            return new Email();
        }
    }
}
