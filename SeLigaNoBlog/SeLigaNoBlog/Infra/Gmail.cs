using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace SeLigaNoBlog
{
    
    public class Gmail : IServicoWeb
    {
        //Constatntes de configuração
        public const string HOST = "smtp.gmail.com";
        public const int PORTA = 587;

        public Smtp Smtp { get; protected set; }

        public Gmail(Smtp smtp)
        {
            this.Smtp = smtp;   
        }


        public void Enviar(Mensagem email)
        {
            var smtpCliente = ObterSmtpClient();

            var mail = email.ObterMailMessage();

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
