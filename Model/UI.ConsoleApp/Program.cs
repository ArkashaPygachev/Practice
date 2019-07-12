using Model;
using System;
using System.Configuration;

namespace UI.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            string alphabetFileName = ConfigurationManager.AppSettings["AlphabetFileName"];
            Localizer localizer = new Localizer();
            localizer.LoadAlphabetFromFile(alphabetFileName);
            do {
                Console.WriteLine("Enter text to convert");
                string originalText = Console.ReadLine();
                string localizedText = localizer.Localize(originalText);
                Console.WriteLine($"Converted text:\n{localizedText}\nContinue?(y/n){Environment.NewLine}");
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }
    }
}
