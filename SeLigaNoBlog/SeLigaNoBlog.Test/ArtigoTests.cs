using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeLigaNoBlog.Test
{
    [TestClass]
    public class ArtigoTests
    {
        [TestMethod]
        public void DeveAtribuirValoresAsPropriedades()
        {
            //Arrange            
            var titulo = "Blog da Azys";
            var url = "http://www.azys.com.br/blog/";

            //Act
            var artigo = new Artigo(titulo, url);

            //Assert
            Assert.AreEqual(titulo, artigo.Titulo);
            Assert.AreEqual(url, artigo.Url);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarTituloNulo()
        {
            //act
            var artigo = new Artigo(null, "http://www.azys.com.br/blog/");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarUrlNulo()
        {
            //act
            var artigo = new Artigo("titulo", null);
        }



    }
}
