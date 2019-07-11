using System.Collections.Generic;
using System.IO;

namespace LibConverterAndDictionaryLoader {
    public static class Converter {
        public static string Convert(string content, Dictionary<string, string> dictionary) {
            foreach (var item in dictionary) {
                content = content.Replace(item.Key, item.Value);
            }
            return content;
        }
        public static List<string> GetFileContentAsString(int fileDir) {
            string s = fileDir.ToString();
            return GetFileContentAsString(s);
        }
        public static List<string> GetFileContentAsString(string fileDir) {
            var result = new List<string>();
            if (File.Exists(fileDir))
                result.AddRange(File.ReadAllLines(fileDir));
            return result;
        }
    }
}
