using Lab3FrajeTest2Console.Models;
using System;
using System.Collections.Generic;

namespace Lab3FrajeTest2Console
{
    class Program
    {
        static List<WordList> WordLists { get; set; }
        static void Main(string[] args)
        {
            WordLists = new List<WordList>();

            myMenu();
        }


        static WordList createWordList(string listName, string languageOne, string languageTwo)
        {
            return new WordList(listName, languageOne, languageTwo);
        }
        static string getHelpText()
        {
            return "Use any of the following parameters: \n" +
                "-lists \n" +
                "-new <list name> <language 1> <language 2> \n" +
                "-add <list name>\n" +
                "-remove <list name> <language> <word 1> <word 2>... <word n>\n" +
                "-words <list name> <sortByLanguage>\n" +
                "-count <list name>\n" +
                "-practise <listname>\n";
        }
        static void myMenu()
        {
            Console.Clear();
            Console.WriteLine("Glosmaster");
            Console.WriteLine("==============");

            Console.WriteLine(getHelpText());

            var commandLine = Console.ReadLine().Split(" ");
            if (commandLine.Length > 0)
            {
                if (commandLine[0] == "-new")
                {
                    var listName = "Testlista";
                    var languageOne = "Svenska";
                    var languageTwo = "Engelska";
                    var wordList = createWordList(listName, languageOne, languageTwo);
                    WordLists.Add(wordList);                    
                }
                if (commandLine[0] == "-add")
                {
                    var listName = "Testlista";
                    var wordList = WordLists.Find(wordList => wordList.Name == listName);
                    if (wordList != null)
                    {
                        while (true)
                        {
                            Console.WriteLine($"Enter word in {wordList.Languages[0]}");
                            var languageOneWord = Console.ReadLine();
                            if (languageOneWord == "")
                            {
                                break;
                            }
                            Console.WriteLine($"Enter word in {wordList.Languages[1]}");
                            var languageTwoWord = Console.ReadLine();
                            wordList.addWord(languageOneWord, languageTwoWord);
                        }
                    }
                }
               
            }
            myMenu();

        }
    }

}



