using System;
using System.Configuration;

namespace SeLigaNoBlog.Playgraud
{
    class Program
    {
        static void Main(string[] args)
        {
            var setServer = ConfigurationManager.AppSettings["servidorSmtp"];

            Console.WriteLine(setServer);

            //var servico = new ServicoRecomendacao();
            //servico.Executar();

            Console.ReadLine();


        }
    }
}
