using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class Artigo
    {
        //propriedades da classe
        public string Titulo { get; protected set; }
        public string Url { get; protected set; }

        public Artigo(string titulo, string url)
        {
            if (string.IsNullOrEmpty(titulo))            
                throw new ArgumentNullException("titulo");
            
            if (string.IsNullOrEmpty(url))            
                throw new ArgumentNullException("url");
            

            Titulo = titulo;
            Url = url;
        }

    }
}
