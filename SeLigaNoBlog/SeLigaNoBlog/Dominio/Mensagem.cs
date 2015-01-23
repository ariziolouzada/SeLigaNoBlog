using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace SeLigaNoBlog
{
    public class Mensagem
    {
        public Usuario Usuario { get; set; }
        public Artigo Artigo { get; set; }


        public Mensagem(Usuario usuario, Artigo artigo)
        {
            this.Usuario = usuario;
            this.Artigo = artigo;
        }


        public MailMessage ObterMailMessage()
        {
            var mail = new MailMessage()
            {
                Subject = "Recomendação de Artigo",
                Body = this.Artigo.Url
            };

            mail.To.Add(new MailAddress(this.Usuario.Email, this.Usuario.Nome));

            return mail;
        }

    }
}
