using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class Smtp
    {
        //public string Servidor { get; set; }
        //public int Porta { get; set; }
        //public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        public static Smtp ObterPorConfig()
        {
            return new Smtp()
            {
                //Servidor = ConfigurationManager.AppSettings["servidorSmtp"],
                //Porta = int.Parse(ConfigurationManager.AppSettings["portaSmtp"]),
                //Email = ConfigurationManager.AppSettings["emailSmtp"],
                Login = ConfigurationManager.AppSettings["loginSmtp"],
                Senha = ConfigurationManager.AppSettings["senhaSmtp"],
                Nome = ConfigurationManager.AppSettings["nomeSmtp"]
            };
        }

    }
}
