using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace SeLigaNoBlog
{
    public class Gmail
    {
        //Constatntes de configuração
        public const string HOST = "smtp.gmail.com";
        public const int PORTA = 587;

        public Smtp Smtp { get; protected set; }

        public Gmail(Smtp smtp)
        {
            this.Smtp = smtp;   
        }


        public void EnviarEmail(Usuario usuario, Artigo artigo)
        {
            var smtpCliente = ObterSmtpClient();

            var mail = new MensagemEmail(usuario, artigo).ObterMailMessage();
            mail.From = new MailAddress(this.Smtp.Login, this.Smtp.Nome);

            smtpCliente.Send(mail);
        }

        public SmtpClient ObterSmtpClient()
        {
            return new SmtpClient(HOST, PORTA)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(this.Smtp.Login, this.Smtp.Senha),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };            
        }


    }
}
