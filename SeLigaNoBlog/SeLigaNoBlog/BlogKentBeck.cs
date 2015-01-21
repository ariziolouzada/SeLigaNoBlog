using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNX.RssReader;

namespace SeLigaNoBlog
{
    public class BlogKentBeck : Blog
    {

        public BlogKentBeck()
            :base("http://www.threeriversinstitute.org/rss2.xml")
        {

        }

        public override bool EhArtigo(Artigo artigo)
        {
            return true;
        }


    }
}
