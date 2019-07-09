using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DictionaryLoader
{
    public abstract class Loader
    {
        protected string fInputFileName;
        public Loader(string inputFileName) {
            if (string.IsNullOrEmpty(inputFileName))
                throw new ArgumentNullException("fileName");
            fInputFileName = inputFileName;
        }
        public abstract LoadResult GetFromConfig();
    }
    public class XmlLoader : Loader
    {
        public XmlLoader(string inputFileName) : base(inputFileName) { }
        public override LoadResult GetFromConfig() {
            LoadResult result = new LoadResult();
            XmlDocument latAlphabet = new XmlDocument();
            try {
                latAlphabet.Load(fInputFileName);
            } catch (XmlException e) {
                result.Error = e;
                //Console.Error.WriteLine($"Invalid Xml file format. {e.Message}");
                //throw new XmlException("Invalid Xml file format.", e);
            } catch (Exception ex) {
                result.Error = ex;
                //Console.WriteLine("Xml file doesn't exist");
                //throw new FileNotFoundException("Xml file doesn't exist");
            }
            //latAlphabet.Load(fInputFileName);
            if (result.Error != null) {
                XmlElement letters = latAlphabet.DocumentElement;
                foreach (XmlNode letter in letters) {
                    XmlNode rus = letter.Attributes["rus"];
                    XmlNode lat = letter.Attributes["lat"];
                    result.Data.Add(rus.Value, lat.Value);
                }
            }
            return result;
        }
    }
    //public class TextLoader : Loader
    //{
    //    public TextLoader(string inputFileName) : base(inputFileName) { }
    //    public override Dictionary<string, string> GetFromConfig() {
    //        var rusLatDictionary = new Dictionary<string, string>();
    //        string[] alphabet = File.ReadAllLines(fInputFileName);
    //        foreach (string pair in alphabet) {
    //            string[] letters = pair.Split('|');
    //            rusLatDictionary.Add(letters[0], letters[1]);
    //        }
    //        return rusLatDictionary;
    //    }
    //}
    public class LoadResult {
        public Dictionary<string, string> Data { get; set; }
        public Exception Error { get; set; }
        public LoadResult() {
            Data = new Dictionary<string, string>();
        }
    }
}
