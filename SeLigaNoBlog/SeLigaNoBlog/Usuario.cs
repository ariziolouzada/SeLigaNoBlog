using System;

namespace SeLigaNoBlog
{
    public class Usuario
    {
        //propriedades da classe
        //public string Nome { get; set; }
        public string nome;
        public string Nome 
        { 
            get{return Nome;}
            set 
            { 
                if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("value");

                nome = value;             
            }        
        }
        

        public string Email { get; set; }
        
        public Usuario(string nome, string email)
        {
            
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException("email");

            Nome = nome;
            Email = email;
        }
    }
}
