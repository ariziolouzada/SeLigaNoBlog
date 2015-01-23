using System;
using System.Linq;
using TNX.RssReader;

namespace SeLigaNoBlog
{
    public  class Feed : IArtigos //LeitorFeed: IFonteArtigos
    {
        public FonteArtigos Fonte { get; set; }

        public Feed(FonteArtigos fonte)
        {
            Fonte = fonte;
        }

        //public abstract bool EhArtigo(Artigo artigo);

        public Artigo ObterArtigo()
        {

            //Obtendo os posts
            var feed = RssHelper.ReadFeed(this.Fonte.Url);

            //Selecionandop o artigo
            var articles = feed.Items
                                    .Select(i => new Artigo(i.Title, i.Link))
                                    .Where(a => a.Url.Contains(this.Fonte.TermoFiltragem));

            //Obtendo o artigo aleatório
            var random = new Random();
            var randomNumber = random.Next(0, articles.Count());
            var article = articles.ToArray()[randomNumber];

            return article;
        }
    }
}
