using System.Net;
using System.Net.Mail;

namespace SeLigaNoBlog
{
    public class Gmail
    {

        public void EnviarEmail(Usuario usuario, Artigo artigo)
        {

            var smtp = new SmtpClient("smtp.gmail.com", 25);

            smtp.Credentials = new NetworkCredential("username", "senha");

            var mail = new MailMessage();
            mail.From = new MailAddress("denisferrari@azys.com.br", "Denis Ferrari");
            mail.Subject = "Recomendação de Artigo";
            mail.To.Add(new MailAddress(usuario.Email, usuario.Nome));
            //mail.To.Add(new MailAddress("denisferrari@azys.com.br", "Denis Ferrari"));
            mail.Body = artigo.Url;

            //smtp.Send(mail);

        }

    }
}
