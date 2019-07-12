using System.Collections.Generic;
using System.IO;

namespace Data {
    public class Loader {
        public static Dictionary<string, string> LoadAlphabet(string fileName) {
            //not empty name
            //file exist
            Dictionary<string, string> alphabet = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string pair in lines) {
                string[] letters = pair.Split('|');
                alphabet.Add(letters[0], letters[1]);
            }
            return alphabet;
        }
    }
}
