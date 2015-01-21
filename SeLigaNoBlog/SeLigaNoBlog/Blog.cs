using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNX.RssReader;

namespace SeLigaNoBlog
{
    public abstract class Blog : IBlog
    {
        public string Url { get; set; }

        protected Blog(string url)
        {
            Url = url;
        }

        public abstract bool EhArtigo(Artigo artigo);

        public Artigo ObterArtigo()
        {

            //Obtendo os posts
            var feed = RssHelper.ReadFeed(Url);

            //Selecionandop o artigo
            var articles = feed.Items
                                    .Select(i => new Artigo(i.Title, i.Link))
                                    .Where(a => a.Url.Contains("articles"));

            //Obtendo o artigo aleatório
            var random = new Random();
            var randomNumber = random.Next(0, articles.Count());
            var article = articles.ToArray()[randomNumber];

            return article;
        }
    }
}
