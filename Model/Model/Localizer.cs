using System.Collections.Generic;

using Data;

namespace Model {
    public class Localizer {
        Dictionary<string, string> latinAlphabet;
        public Localizer() { }
        public bool LoadAlphabetFromFile(string fileName) {
            try {
                this.latinAlphabet = Loader.LoadAlphabet(fileName);
                return true;
            } catch {
                return false;
            }
        }
        public string Localize(string inputCyrillicText) {
            foreach (var pair in this.latinAlphabet)
                inputCyrillicText = inputCyrillicText.Replace(pair.Key, pair.Value);
            return inputCyrillicText;
        }
    }
}
