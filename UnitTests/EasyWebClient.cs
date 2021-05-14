using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class EasyWebClientTests
    {
        [Test]
        public void SendsGetRequest()
        {
            // arrange
            var endpoint = "http://localhost:42112/api/Testing";
            var webClient = new EasyWebClient.EasyWebClient(new Uri(endpoint));

            // act
            var actual = webClient.Get();

            // assert
            Assert.That(actual, Is.Not.Empty);
        }
    }
}
