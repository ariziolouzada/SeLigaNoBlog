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
            var smtp = Smtp.ObterPorConfig();

            var usuario = new Usuario("Cb Louzada", "arizio.louzada@pm.es.gov.br");
            //usuario.Nome = ;
            //usuario.Email = ;

            var Blog = new BolgMatinFowler();

            var artigo = Blog.ObterArtigo();

            var servicoEmail = new Gmail(smtp);

            var mensagem = new MensagemEmail(usuario, artigo);

            servicoEmail.EnviarEmail(usuario, artigo);
        }        

    }
}
