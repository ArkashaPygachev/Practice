using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ConsoleApp1 {
    public abstract class Loader {
        protected string fInputFileName;
        public Loader(string inputFileName) {
            if (string.IsNullOrEmpty(inputFileName))
                throw new ArgumentNullException("fileName");
            fInputFileName = inputFileName;
        }
        public abstract Dictionary<string, string> GetFromConfig();
    }
    public class XmlLoader : Loader {
        public XmlLoader(string inputFileName) : base(inputFileName) { }
        public override Dictionary<string, string> GetFromConfig() {
            var rusLatDictionary = new Dictionary<string, string>();
            XmlDocument latAlphabet = new XmlDocument();
            latAlphabet.Load(fInputFileName);
            XmlElement letters = latAlphabet.DocumentElement;
            foreach (XmlNode letter in letters) {
                XmlNode rus = letter.Attributes["rus"];
                XmlNode lat = letter.Attributes["lat"];
                rusLatDictionary.Add(rus.Value, lat.Value);
            }
            return rusLatDictionary;
        }
    }
    public class TextLoader : Loader
    {
        public TextLoader(string inputFileName) : base(inputFileName) { }
        public override Dictionary<string, string> GetFromConfig() {
            var rusLatDictionary = new Dictionary<string, string>();
            string[] alphabet = File.ReadAllLines(fInputFileName);
            foreach (string pair in alphabet) {
                string[] letters = pair.Split('|');
                rusLatDictionary.Add(letters[0], letters[1]);
            }
            return rusLatDictionary;
        }
    }
}
