using System;
using System.Linq;
using TNX.RssReader;


namespace SeLigaNoBlog
{
    class BolgMatinFowler : Blog
    {
        public BolgMatinFowler()
            :base("http://martinfowler.com/feed.atom")
        {

        }

        public override bool EhArtigo(Artigo artigo)
        {
            return artigo.Url.Contains("articles");
        }


        //public Artigo ObterArtigo()
        //{

        //    //var url = ;

        //    //Obtendo os posts
        //    var feed = RssHelper.ReadFeed(Url);

        //    //Selecionandop o artigo
        //    var articles = feed.Items.Where(i => i.Link.Contains("articles"));

        //    //Obtendo o artigo aleatório
        //    var random = new Random();
        //    var randomNumber = random.Next(0, articles.Count());
        //    var article = articles.ToArray()[randomNumber];

        //    var artigo = new Artigo(article.Title, article.Link);
            
        //    return artigo;

        //}

    }
}
