using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Xml;
using NUnit.Framework;

namespace ConverterNames
{
    class Program
    {
        static void Main(string[] args) {
            string inputFileName = ConfigurationManager.AppSettings["LoadFileName"];
            string outputFileName = ConfigurationManager.AppSettings["SaveFileName"];
            //List<string> example = new List<string>() { "АВВБББА" };

            var charactersDictionary = GetDictionaryFromXml(inputFileName);

            string outputFileNameWithoutExtension = Path.GetFileNameWithoutExtension(outputFileName);
            string extension = Path.GetExtension(outputFileName);
            Guid s = Guid.NewGuid();

            string dateTimeNowUtcString = DateTime.Now.ToString("yyyy-M-d-hh-m-ss");

            outputFileName = $"{outputFileNameWithoutExtension}-{s}-{dateTimeNowUtcString}{extension}";


            //TextWriter tw = new StreamWriter(outputFileName);
            //foreach (var item in charactersDictionary)
            //    tw.WriteLine(item);
            //tw.Close();

            foreach (var item in charactersDictionary)
                File.AppendAllText(outputFileName, $"-123--{item}{Environment.NewLine}");

            //foreach (var item in dictionary) {
            //    File.WriteAllText(saveFileName, $"{item.Key} - {item.Value}");
            //}
            //File.WriteAllLines(saveFileName, result);
            //foreach (string line in result) {
            //    File.WriteAllLines(saveFileName, line);
            //}


            //Console.ReadLine();
            //System.IO.File.WriteAllLines(@"C:\Projects\ConvertedList.txt", ConvertedList);
        }
        public static Dictionary<string, string> GetDictionaryFromXml(string fileName) {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException("fileName");
            if (!File.Exists(fileName))
                throw new InvalidOperationException("The specified file does not exist");
            var rusLatDictionary = new Dictionary<string, string>();
            //if (File.Exists(fileName)) {
                XmlDocument latAlphabet = new XmlDocument();
                latAlphabet.Load(fileName);
                XmlElement letters = latAlphabet.DocumentElement;
                foreach (XmlNode letter in letters) {
                    XmlNode rus = letter.Attributes["rus"];
                    XmlNode lat = letter.Attributes["lat"];
                    rusLatDictionary.Add(rus.Value, lat.Value);
                }
            //}
            return rusLatDictionary;
        }
        static Dictionary<char, char> CollectDictionaryFromAlphabets(List<char> keyUperCaseAlphabet, List<char> keyLowerCaseAlphabet, List<char> valueUperCaseAlphabet, List<char> valueLowerCaseAlphabet) {
            var rusLatDictionaty = new Dictionary<char, char>();
            keyUperCaseAlphabet.AddRange(keyLowerCaseAlphabet);
            valueUperCaseAlphabet.AddRange(valueLowerCaseAlphabet);
            for (int letterIndex = 0; letterIndex < keyUperCaseAlphabet.Count; letterIndex++) {
                rusLatDictionaty.Add(keyUperCaseAlphabet[letterIndex], valueUperCaseAlphabet[letterIndex]);
            }
            return rusLatDictionaty;
        }
        //create new method
        //read tekst file (name)
        //return its content as string 
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

        public static List<string> Convert(List<string> originalList, Dictionary<string, string> dictionary) {
            //https://en.wikipedia.org/wiki/Vehicle_registration_plate#Russian_Federation
            //var lowerCase = new Dictionary<char, char>() { { 'а', 'a' }, { 'б', 'b' }, { 'в', 'B' }, { 'г', 'g' }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, { 'х', 'x' }, { 'ц', 's' }, { 'ч', '4' }, { 'ш', 'w' }, { 'щ', 'Щ' }, { 'ъ', '6' }, { 'ы', 'i' }, { 'ь', '6' }, { 'э', 'e' }, { 'ю', 'y' }, { 'я', '9' } };
            //var lowerCase = new Dictionary<char, char>();
            //List<char> latUp = new List<char> { 'A', 'b', 'B', 'G', 'D', 'E', 'E', 'J', 'Z', 'U', 'U', 'K', 'L', 'M', 'H', 'O', 'n', 'P', 'C', 'T', 'Y', 'F', 'X', 'S', '4', 'W', 'W', '6', 'I', '6', 'E', 'Y', '9' };
            //List<char> latLow = new List<char> { 'a', 'b', 'B', 'g', 'd', 'e', 'e', 'j', 'z', 'u', 'u', 'K', 'l', 'M', 'H', 'o', 'n', 'p', 'c', 't', 'y', 'f', 'x', 's', '4', 'w', 'w', '6', 'i', '6', 'e', 'y', '9' };

            //var uperCase = new Dictionary<char, char>();
            //List<char> rusUp = new List<char> { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            //List<char> rusLow = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            //var rusLatDictionaty = CollectDictionaryFromAlphabets(rusUp, rusLow, latUp, latLow);
            //Without coloring, one dictionary
            foreach (var item in dictionary) {
                for (int listIndex = 0; listIndex < originalList.Count; listIndex++) {
                    originalList[listIndex] = originalList[listIndex].Replace(item.Key, item.Value);
                }
            }

            //Without coloring
            //for (int letterInAlphabet = 0; letterInAlphabet < lowerCase.Count; letterInAlphabet++) {
            //    for (int listIndex = 0; listIndex < originalList.Count; listIndex++) {
            //        string listElement = originalList[listIndex];
            //        //uperCase
            //        if (listElement.Contains()) {
            //            originalList[listIndex] = originalList[listIndex].Replace();
            //        }
            //        //lowerCase
            //        if (listElement.Contains()) {
            //            originalList[listIndex] = originalList[listIndex].Replace();
            //        }

            //        //for (int letterIndexInList = 0; letterIndexInList < listElement.Length; letterIndexInList++) {
            //        //    char letter = listElement[letterIndexInList];
            //        //    if (lowerCase.ContainsKey(letter)) {
            //        //        originalList[listIndex]= originalList[listIndex].Replace(letter, )
            //        //    }
            //        //}
            //    }
            //}

            //With coloring
            //for (int listIndex = 0; listIndex < originalList.Count; listIndex++) {
            //    string listElement = originalList[listIndex];
            //    for (int letterIndexInList = 0; letterIndexInList < listElement.Length; letterIndexInList++) {
            //        char letter = listElement[letterIndexInList];
            //        if (lowerCase.ContainsKey(letter)) {
            //            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //            originalList[listIndex] = originalList[listIndex].Replace(letter, lowerCase[letter]);
            //            letter = lowerCase[letter];
            //        }
            //        if (uperCase.ContainsKey(letter)) {
            //            Console.ForegroundColor = ConsoleColor.Cyan;
            //            originalList[listIndex] = originalList[listIndex].Replace(letter, uperCase[letter]);
            //            letter = uperCase[letter];
            //        }

            //        //Without dictionary
            //        //for (int letterIndexInAlphabet = 0; letterIndexInAlphabet < latUp.Count; letterIndexInAlphabet++) {
            //        //    if (letter == rusUp[letterIndexInAlphabet]) {
            //        //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        //        originalList[listIndex] = originalList[listIndex].Replace(letter, latUp[letterIndexInAlphabet]);
            //        //        letter = latUp[letterIndexInAlphabet];
            //        //        break;
            //        //    }
            //        //    if (letter == rusLow[letterIndexInAlphabet]) {
            //        //        Console.ForegroundColor = ConsoleColor.DarkGreen;
            //        //        originalList[listIndex] = originalList[listIndex].Replace(letter, latLow[letterIndexInAlphabet]);
            //        //        letter = latLow[letterIndexInAlphabet];
            //        //        break;
            //        //    }
            //        //}
            //        Console.Write(letter);
            //        Console.ResetColor();
            //    }
            //    Console.WriteLine();

            //}
            return originalList;
        }
    }

    [TestFixture]
    class ProgramTest
    {
        [Test]
        public void TextContentTest() {



            string expectedContent = "1DdsDSGD\n2flkEJflkml\n3jmenfn";
            string fileDir = @"C:\MyRepos\Practice\bin\TestText.txt";

            List<string> actualContent = Program.GetFileContentAsString(fileDir);

            AssertFileContent(expectedContent, actualContent);
        }
        static void AssertFileContent(string expectedContent, List<string> actualContent) {
            List<string> expectedContentList = new List<string>(expectedContent.Split('\n'));
            if (actualContent.Count != 0) {
                Assert.AreEqual(expectedContentList.Count, actualContent.Count, "Amount of lines does't match");
                for (int lineIndex = 0; lineIndex < expectedContentList.Count; lineIndex++) {
                    Assert.AreEqual(expectedContentList[lineIndex], actualContent[lineIndex], $"Line number {lineIndex + 1}");
                }
            } else Assert.Fail("File not found or empty");
        }
        [Test]
        public void ConvertTest() {
            //arrange
            List<string> inputParameters = new List<string>() { "АВВБББА" };
            List<string> expectedConverionResult = new List<string>() { "ABBbbbA" };
            string xmlFileNameWithAlphabets = ConfigurationManager.AppSettings["LoadFileName"];

            //act
            //Dictionary<string, string> dictionary = Program.CollectDictionaryFromXml(xmlFileNameWithAlphabets);
            Dictionary<string, string> dictionary = Program.GetDictionaryFromXml("");
            List<string> actualConverionResult = Program.Convert(inputParameters, dictionary);

            //assert
            Assert.AreEqual(expectedConverionResult.Count, actualConverionResult.Count);
            for (int index = 0; index < actualConverionResult.Count; index++) {
                Assert.AreEqual(expectedConverionResult[index], actualConverionResult[index]);
            }

            for (int stringIndex = 0; stringIndex < actualConverionResult.Count; stringIndex++) {
                string actualListElement = actualConverionResult[stringIndex];
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
