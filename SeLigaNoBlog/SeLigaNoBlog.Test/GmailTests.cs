using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace SeLigaNoBlog.Test
{
    [TestClass]
    public class GmailTests
    {
        [TestMethod]
        public void DeveConfigurarSmtpParaGmail()
        {
            //Arrange
            var smtp = new Smtp()
            {
                Login = "login",
                Nome = "nome",
                Senha = "senha"
            };

            var gmail = new Gmail(smtp);

            //act
            var client = gmail.ObterSmtpClient();

            //Assert
            Assert.AreEqual(smtp.Login, ((NetworkCredential)client.Credentials).UserName);
            Assert.AreEqual(smtp.Senha, ((NetworkCredential)client.Credentials).Password);
            Assert.AreEqual(587, client.Port);
            Assert.AreEqual("smtp.gmail.com", Gmail.HOST);

        }
    }
}
