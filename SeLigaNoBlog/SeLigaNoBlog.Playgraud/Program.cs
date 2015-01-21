using System;

namespace SeLigaNoBlog.Playgraud
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Receber um artigo técnico do Blog do Martin Fowler em e-mail.
             * 
             * ---- Planejamento Básico ----             
             * Obter os posts do Blog
             *      TNX.RssReader
             * Separar os Artigos
             *      Onde aparecer a palavra Artis é um artigo registrado
             * Pegar um artigo aleatório
             * Enviar o link para o e-mail do usuário
             * 
             * Desafios
             * Como pegar os posts
             * - RSS "http://martinfowler.com/feed.atom";
             * Como enviar o e-mail  
             * 
            */

            var servico = new ServicoRecomendacao();

            servico.Executar();

            //Console.WriteLine("URL: " + artigo.Titulo);
            //Console.WriteLine(artigo.Titulo);
            Console.ReadLine();


        }
    }
}
