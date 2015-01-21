using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class ServicoRecomendacao
    {
        public void Executar()
        {
            var usuario = new Usuario();
            usuario.Nome = "Louzada";
            usuario.Email = "arizio.louzada@pm.es.gov.br";

            var Blog = new BlogKentBeck();

            var artigo = Blog.ObterArtigo();

            var servicoEmail = new Gmail();

            servicoEmail.EnviarEmail(usuario, artigo);
        }        

    }
}
