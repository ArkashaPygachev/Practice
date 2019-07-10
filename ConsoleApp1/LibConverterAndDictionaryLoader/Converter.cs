using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibConverterAndDictionaryLoader {
    public static class Converter {
        public static List<string> Convert(string fileDir, Dictionary<string, string> dictionary) {
            List<string> content = GetFileContentAsString(fileDir);
            foreach (var item in dictionary) {
                for (int lineIndex = 0; lineIndex < content.Count; lineIndex++) {
                    content[lineIndex] = content[lineIndex].Replace(item.Key, item.Value);
                }
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
