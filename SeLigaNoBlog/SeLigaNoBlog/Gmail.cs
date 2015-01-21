using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace SeLigaNoBlog
{
    public class Gmail
    {

        public void EnviarEmail(Usuario usuario, Artigo artigo)
        {
            var smtp = Smtp.ObterPorConfig();
            
            var cliente = new SmtpClient(smtp.Servidor, smtp.Porta);
            cliente.Credentials = new NetworkCredential(smtp.Login, smtp.Senha);
            
            var mail = new MailMessage()
            {
                From = new MailAddress(smtp.Email, smtp.Nome),
                Subject = "Recomendação de Artigo",
                Body = artigo.Url
            };


            mail.To.Add(new MailAddress(usuario.Email, usuario.Nome));
            //smtp.Send(mail);

        }

    }
}
