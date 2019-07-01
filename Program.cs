using System;
using System.Collections.Generic;

namespace ConverterNames
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] OriginalList = System.IO.File.ReadAllLines(@"C:\Projects\OriginalList.txt");
            string[] ConvertedList = Convert(OriginalList);*/
            var OriginalList = new List<string>() { "бИ", "bН", "й", "Субару Р567ХН" };
            var ConvertedList = Convert(OriginalList);
            //System.IO.File.WriteAllLines(@"C:\Projects\ConvertedList.txt", ConvertedList);
        }

        public static List<string> Convert(List<string> originalList)
        {
            //https://en.wikipedia.org/wiki/Vehicle_registration_plate#Russian_Federation
            List<char> latUp = new List<char>  { 'A', 'b', 'B', 'G', 'D', 'E', 'E', 'J', 'Z', 'U', 'U', 'K', 'L', 'M', 'H', 'O', 'n', 'P', 'C', 'T', 'Y', 'F', 'X', 'S', '4', 'W', 'W', '6', 'I', '6', 'E', 'Y', '9' };
            List<char> latLow = new List<char> { 'a', 'b', 'B', 'g', 'd', 'e', 'e', 'j', 'z', 'u', 'u', 'K', 'l', 'M', 'H', 'o', 'n', 'p', 'c', 't', 'y', 'f', 'x', 's', '4', 'w', 'w', '6', 'i', '6', 'e', 'y', '9' };
            
            List<char> rusUp = new List<char>  { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            List<char> rusLow = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            for (int listIndex = 0; listIndex < originalList.Count; listIndex++)
            {
                string listElement = originalList[listIndex];

                for (int letterIndexInList = 0; letterIndexInList < listElement.Length; letterIndexInList++)
                {
                    char letter = listElement[letterIndexInList];
                    for (int letterIndexInAlphabet = 0; letterIndexInAlphabet < latUp.Count; letterIndexInAlphabet++)
                    {
                        if (letter==rusUp[letterIndexInAlphabet])
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            letter = latUp[letterIndexInAlphabet];
                            break;
                        }
                        if (letter == rusLow[letterIndexInAlphabet])
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            letter = latLow[letterIndexInAlphabet];
                            break;
                        }
                    }
                    Console.Write(letter);
                    Console.ResetColor();
                }
                Console.WriteLine();

                /*
                int[] letterColors = new int[listElement.Length];
                for (int letterIndex = 0; letterIndex < listElement.Length; letterIndex++)
                {
                    if (rusUp.Contains(listElement[letterIndex]))
                        letterColors[letterIndex] = 1;
                    if (rusLow.Contains(listElement[letterIndex]))
                        letterColors[letterIndex] = 2;
                }
                for (int letterIndex = 0; letterIndex < latUp.Count; letterIndex++)
                {
                    if (listElement.Contains(rusUp[letterIndex]))
                        listElement = listElement.Replace(rusUp[letterIndex], latUp[letterIndex]);
                    if (listElement.Contains(rusLow[letterIndex]))
                        listElement = listElement.Replace(rusLow[letterIndex], latLow[letterIndex]);
                }
                for (int letterIndex = 0; letterIndex < listElement.Length; letterIndex++)
                {
                    if(letterColors[letterIndex]==1)
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    if(letterColors[letterIndex]==2)
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(listElement[letterIndex]);
                    Console.ResetColor();
                }
                Console.WriteLine();*/

                /*foreach (char letter in listElement.ToCharArray())
                {
                    if (rus_up.Contains(letter))
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    if (rus_low.Contains(letter))
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(letter);
                }
                Console.WriteLine();*/

            }
            return originalList;
        }
    }
}
