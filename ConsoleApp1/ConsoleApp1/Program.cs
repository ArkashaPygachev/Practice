using LibConverterAndDictionaryLoader;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1 {
    class Program {
        enum LoaderType {
            Xml = 0,
            Text = 1
        }
        static void Main(string[] args) {
            if (args.Length == 0)
                throw new InvalidOperationException("Command Line parameters were not specified");
            string inputFileName = ConfigurationManager.AppSettings["LoadFileName"];

            Console.WriteLine("Start dictionary loading");

            Loader loader;
            if (args[0] == "0") {
                loader = new XmlLoader(inputFileName);
            }
            else
                loader = new TextLoader(inputFileName);
            loader.DictionaryLoaded += Loader_DictionaryLoaded;
            var resultDictionary = loader.GetFromConfig();
            

            List<string> allConvertedText = new List<string>();
            if (resultDictionary.Error == null) {
                do {
                    Console.WriteLine("Enter text to convert");
                    string text = Console.ReadLine();
                    string convertedText = Converter.Convert(text, resultDictionary.Data);
                    allConvertedText.Add(convertedText);
                    Console.WriteLine($"Converted text:\n{convertedText}\nContinue?(y/n)");
                } while (Console.ReadKey(true).Key == ConsoleKey.Y);
                SaveResult(allConvertedText);
                Environment.Exit(0);
            } else
                Environment.Exit(1);
        }

        private static void Loader_DictionaryLoaded(object sender, EventArgs e) {
            Console.WriteLine((e as LoaderEventArgs).result.Data);
            //if (e is LoaderEventArgs) {
            //    LoaderEventArgs loaderEventArgs = e as LoaderEventArgs;
            //    List<string> allConvertedText = new List<string>();
            //    if (loaderEventArgs.result.Error == null) {
            //        do {
            //            Console.WriteLine("Enter text to convert");
            //            string text = Console.ReadLine();
            //            string convertedText = Converter.Convert(text, loaderEventArgs.result.Data);
            //            allConvertedText.Add(convertedText);
            //            Console.WriteLine($"Converted text:\n{convertedText}\nContinue?(y/n)");
            //        } while (Console.ReadKey(true).Key == ConsoleKey.Y);
            //        SaveResult(allConvertedText);
            //        Environment.Exit(0);
            //    } else
            //        Environment.Exit(1);
            //}
            //if (e is LoaderEventArgs) {
            //    LoaderEventArgs loaderEventArgs = e as LoaderEventArgs;
            //    List<string> allConvertedText = new List<string>();
            //    if (loaderEventArgs.result.Error == null) {
            //        do {
            //            Console.WriteLine("Enter text to convert");
            //            string text = Console.ReadLine();
            //            string convertedText = Converter.Convert(text, loaderEventArgs.result.Data);
            //            allConvertedText.Add(convertedText);
            //            Console.WriteLine($"Converted text:\n{convertedText}\nContinue?(y/n)");
            //        } while (Console.ReadKey(true).Key == ConsoleKey.Y);
            //        SaveResult(allConvertedText);
            //        Environment.Exit(0);
            //    } else
            //        Environment.Exit(1);
            //}
        }

        static void SaveResult(List<string> result) {
            string outputFileName = ConfigurationManager.AppSettings["SaveFileName"];
            string outputFileNameWithoutExtension = Path.GetFileNameWithoutExtension(outputFileName);
            string extension = Path.GetExtension(outputFileName);
            Guid randomGuid = Guid.NewGuid();
            string dateTimeNowUtcString = DateTime.Now.ToString("yyyy-M-d-hh-m-ss");
            outputFileName = $"{outputFileNameWithoutExtension}-{randomGuid}-{dateTimeNowUtcString}{extension}";
            foreach (var line in result)
                File.AppendAllText(outputFileName, $"{line}{Environment.NewLine}");
        }
    }
}
