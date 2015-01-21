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
        public string Titulo { get; set; }
        public string Url { get; set; }

        public Artigo(string titulo, string url)
        {
            // TODO: Validação dos parâmetros.

            Titulo = titulo;
            Url = url;
        }

    }
}
