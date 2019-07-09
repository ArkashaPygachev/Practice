using DictionaryLoader;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLoaderTest
{
    [TestFixture]
    public class LoaderTest
    {
        [Test]
        public void DictionaryLoaderTest() {
            var expectedDictionary = new Dictionary<string, string>() { { "А", "A" },{ "Б", "b" },{ "В", "B" } };
            string[] args = {"1"};
            string inputFileName = "TextFile1.txt";
            //string inputFileName = ConfigurationManager.AppSettings["LoadFileName"];

            Loader loader;
            if (args[0] == "0")
                loader = new XmlLoader(inputFileName);
            else
                loader = new TextLoader(inputFileName);

            var actualDictionary = loader.GetFromConfig();

            Assert.AreEqual(expectedDictionary, actualDictionary);
        }
    }
}
