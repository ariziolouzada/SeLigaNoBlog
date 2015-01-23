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
            //Recurso do processo
            var smtp = Smtp.ObterPorConfig();

            //Dependencias
            IServicoWeb servicoEmail = new Gmail(smtp);
            var usuario = new Usuario("Cb Louzada", "arizio.louzada@pm.es.gov.br");
            var blogMatinFowler = new FonteArtigos("http://martinfowler.com/feed.atom", "articles");
            IArtigos artigos = new Feed(blogMatinFowler);

            //Processo
            var artigo = artigos.ObterArtigo();

            var mensagem = new Mensagem(usuario, artigo);

            servicoEmail.Enviar(mensagem);
        }        

    }
}
