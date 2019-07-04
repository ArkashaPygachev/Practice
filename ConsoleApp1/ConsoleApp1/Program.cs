using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace ConverterNames
{
    class Program
    {
        static void Main(string[] args) {
            /*string[] OriginalList = System.IO.File.ReadAllLines(@"C:\Projects\OriginalList.txt");
            string[] ConvertedList = Convert(OriginalList);*/

            var OriginalList = new List<string>() { "бИбИбИбИ", "bН", "йз", "Субару Р567ХН", "" };
            var ConvertedList = Convert(OriginalList);
            //var uperCase = new Dictionary<int, char>() { {1, 'a' }, {2, 'b' } };
            foreach (var item in ConvertedList) {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            //System.IO.File.WriteAllLines(@"C:\Projects\ConvertedList.txt", ConvertedList);
        }

        public static List<string> Convert(List<string> originalList) {
            //https://en.wikipedia.org/wiki/Vehicle_registration_plate#Russian_Federation
            //var lowerCase = new Dictionary<char, char>() { { 'а', 'a' }, { 'б', 'b' }, { 'в', 'B' }, { 'г', 'g' }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, {, }, { 'х', 'x' }, { 'ц', 's' }, { 'ч', '4' }, { 'ш', 'w' }, { 'щ', 'Щ' }, { 'ъ', '6' }, { 'ы', 'i' }, { 'ь', '6' }, { 'э', 'e' }, { 'ю', 'y' }, { 'я', '9' } };
            var lowerCase = new Dictionary<char, char>();
            List<char> latUp = new List<char> { 'A', 'b', 'B', 'G', 'D', 'E', 'E', 'J', 'Z', 'U', 'U', 'K', 'L', 'M', 'H', 'O', 'n', 'P', 'C', 'T', 'Y', 'F', 'X', 'S', '4', 'W', 'W', '6', 'I', '6', 'E', 'Y', '9' };
            List<char> latLow = new List<char> { 'a', 'b', 'B', 'g', 'd', 'e', 'e', 'j', 'z', 'u', 'u', 'K', 'l', 'M', 'H', 'o', 'n', 'p', 'c', 't', 'y', 'f', 'x', 's', '4', 'w', 'w', '6', 'i', '6', 'e', 'y', '9' };

            var uperCase = new Dictionary<char, char>();
            List<char> rusUp = new List<char> { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            List<char> rusLow = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            for (int letterIndex = 0; letterIndex < latUp.Count; letterIndex++) {
                lowerCase.Add(rusLow[letterIndex], latLow[letterIndex]);
                uperCase.Add(rusUp[letterIndex], latUp[letterIndex]);
            }

            foreach (var item in uperCase) {
                for (int listIndex = 0; listIndex < originalList.Count; listIndex++) {
                    originalList[listIndex] = originalList[listIndex].Replace(item.Key, item.Value);
                }
            }
            foreach (var item in lowerCase) {
                for (int listIndex = 0; listIndex < originalList.Count; listIndex++) {
                    originalList[listIndex] = originalList[listIndex].Replace(item.Key, item.Value);
                }
            }

            //Without coloring
            //for (int letterInAlphabet = 0; letterInAlphabet < lowerCase.Count; letterInAlphabet++) {
            //    for (int listIndex = 0; listIndex < originalList.Count; listIndex++) {
            //        string listElement = originalList[listIndex];
            //        //TODO:
            //        //
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
        public void ConvertTest() {
            //arrange
            List<string> inputParameters = new List<string>() { "чКФдз" };
            List<string> expectedConverionResult = new List<string>() { "4KFdz" };

            //act
            List<string> actualConverionResult = Program.Convert(inputParameters);

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
