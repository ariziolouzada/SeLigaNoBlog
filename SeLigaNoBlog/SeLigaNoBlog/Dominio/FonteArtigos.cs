using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class FonteArtigos
    {
        public string Url { get; set; }
        public string TermoFiltragem { get; set; }

        public FonteArtigos(string url)
        {
            Url = url;
        }

        public FonteArtigos(string url, string termoFiltragem) 
            : this(url)
        {
            TermoFiltragem = termoFiltragem;
        }

    }
}
