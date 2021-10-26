using NUnit.Framework;
using HtmlFormartter;

namespace HtmlFormartter.Test
{
    public class HtmlFormartterTest

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Hola Mundo", "<strong>Hola Mundo</strong>")]
        [TestCase("Henry", "<strong>Henry</strong>")]
        public void FormatAsBold_Simple(string input, string expected)
        {
            // Arrange
            HtmlFormartter.HtmlFormarter _htm = new HtmlFormarter();
            // Act
            var result = _htm.FormatAsBold(input);
            //Assert
            Assert.AreEqual(result,expected);
        }
        [Test]
       public void FormatAsBold_Null()
        {
            string input, expected= " < strong ></ strong > ";
            input = null;
            // Arrange
            HtmlFormartter.HtmlFormarter _htm = new HtmlFormarter();
            // Act
            var result = _htm.FormatAsBold(input);
            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}