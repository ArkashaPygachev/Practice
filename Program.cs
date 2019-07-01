using System;
using System.Collections.Generic;

namespace ConverterNames
{
    class Program
    {
        static void Main(string[] args){
            /*string[] OriginalList = System.IO.File.ReadAllLines(@"C:\Projects\OriginalList.txt");
            string[] ConvertedList = Convert(OriginalList);*/
            string[] OriginalList = new List<string>() { "б", "b", "й" }.ToArray();
            string[] ConvertedList = Convert(OriginalList);
            foreach (string text in ConvertedList)
            {
                Console.WriteLine(text);
            }
            System.IO.File.WriteAllLines(@"C:\Projects\ConvertedList.txt", ConvertedList);
        }

        public static string[] Convert(string[] List){
            //https://en.wikipedia.org/wiki/Vehicle_registration_plate#Russian_Federation
            string[] lat_up =  { "A", "b", "B", "G", "D", "E", "E", "J", "Z", "U", "U", "K", "L", "M", "H", "O", "n", "P", "C", "T", "Y", "F", "X", "S", "4", "W", "W", "6", "I", "6", "E", "Y", "9" };
            string[] lat_low = { "a", "b", "B", "g", "d", "e", "e", "j", "z", "u", "u", "K", "l", "M", "H", "o", "n", "p", "c", "t", "y", "f", "x", "s", "4", "w", "w", "6", "i", "6", "e", "y", "9" };

            string[] rus_up =  { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
            string[] rus_low = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };

            for (int j = 0; j < List.Length; j++){
                for (int i = 0; i < 32; i++){
                    List[j] = List[j].Replace(rus_up[i], lat_up[i]);
                    List[j] = List[j].Replace(rus_low[i], lat_low[i]);
                }
            }
            return List;
        }
    }
}
