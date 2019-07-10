using LibConverterAndDictionaryLoader;
using System;
using System.Collections.Generic;
using System.Configuration;
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

            Loader loader;
            if (args[0] == "0")
                loader = new XmlLoader(inputFileName);
            else
                loader = new TextLoader(inputFileName);
            Console.WriteLine(loader.ToString());
            var result = loader.GetFromConfig();

            if (result.Error != null) {
                Console.WriteLine(result.Error);
                Environment.Exit(1);
            } else {
                foreach (var letters in result.Data) {
                    Console.WriteLine($"{letters.Key} {letters.Value}");
                }
            }

            Console.ReadLine();

            string outputFileName = ConfigurationManager.AppSettings["SaveFileName"];
            string outputFileNameWithoutExtension = Path.GetFileNameWithoutExtension(outputFileName);
            string extension = Path.GetExtension(outputFileName);
            Guid s = Guid.NewGuid();

            string dateTimeNowUtcString = DateTime.Now.ToString("yyyy-M-d-hh-m-ss");

            outputFileName = $"{outputFileNameWithoutExtension}-{s}-{dateTimeNowUtcString}{extension}";


            //TextWriter tw = new StreamWriter(outputFileName);
            //foreach (var item in charactersDictionary)
            //    tw.WriteLine(item);
            //tw.Close();

            //foreach (var item in charactersDictionary)
            //    File.AppendAllText(outputFileName, $"-123--{item}{Environment.NewLine}");

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
    }
}
