using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeLigaNoBlog.Test
{
    [TestClass]
    public class UsuarioTests
    {

        [TestMethod]
        public void DeveAtribuirValoresAsPropriedades()
        {
            //Arrange            
            var nome = "Arizio A O Louzada";
            var email = "arizio.louzada@pm.es.gov.br";

            //Act
            var usuario = new Usuario(nome, email);

            //Assert
            Assert.AreEqual(nome, usuario.Nome); 
            Assert.AreEqual(email, usuario.Email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarNomeNulo()
        {
            //act
            var usuario = new Usuario(null, "arizio.louzada@pm.es.gov.br");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarEmailNulo()
        {
            //act
            var usuario = new Usuario("Arizio A O Louzada", null);
        }


    }
}
