using LibConverterAndDictionaryLoader;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContentConverterTest
{
    [TestFixture]
    class ConverterTest {
        [Test]
        public void ConvertTest() {
            //arrange
            string fileDir = @"C:\MyRepos\Practice\bin\TestText.txt";
            List<string> expectedConverionResult = new List<string>() { "ABBbbbA" };
            string fileName = "XMLFile1.xml";

            //act
            //Dictionary<string, string> dictionary = Program.CollectDictionaryFromXml(xmlFileNameWithAlphabets);
            Loader loader = new XmlLoader(fileName);
            var result = loader.GetFromConfig();
            List<string> actualConvertionResult = Converter.Convert(fileDir, result.Data);

            //assert
            Assert.AreEqual(expectedConverionResult.Count, actualConvertionResult.Count);
            for (int index = 0; index < actualConvertionResult.Count; index++) {
                Assert.AreEqual(expectedConverionResult[index], actualConvertionResult[index]);
            }

            for (int stringIndex = 0; stringIndex < actualConvertionResult.Count; stringIndex++) {
                string actualListElement = actualConvertionResult[stringIndex];
                string expectedListElement = expectedConverionResult[stringIndex];
                for (int letterIndex = 0; letterIndex < actualListElement.Length; letterIndex++) {
                    char actualLetter = actualListElement[letterIndex];
                    char expectedLetter = expectedListElement[letterIndex];
                    Assert.IsTrue((int)actualLetter <= 122);
                    Assert.IsTrue((int)actualLetter <= (int)expectedLetter);
                }
            }
        }
    }
}
