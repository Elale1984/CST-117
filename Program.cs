using System;
using System.IO;
using System.Linq;


/*
 * Solution written by Edward Lale for CST-117
 * All work is my own.
 *
 * The purpose of this solution is to read a txt file and then search through the words and find
 * all of the words that end in 't' or 'e' and count these words.
 *
 * The output should display the number of words that end in these characters.
 * 
 */

namespace Ex10_ReadAndCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //The string path holds the path of the file that is being read. and a StreamReader object is created
            //reading from that path. The console request the path from user and then reads that path. 
            Console.WriteLine("Please enter the path to the file you wish to read: ");
            
            String path =  Console.ReadLine();
            

            //Method call that reads the file and stores the words of the file in a string[] and returns
            //that string[] for further use.
            string[] fileWords = ReadFile(path);
            
            
            //Method call for LastLetter returns an integer representing the number of words ending in
            //'t' or 'e'
            int wrdCnt = LastLetter(fileWords);
            
            //A message showing the number of words ending in 't' or 'e' is displayed in console.
            Console.WriteLine("There are " + wrdCnt + " words that end in t of e");
            
        }
        
        /*
         * This method takes the path that the user enters in the console and opens the path, reads
         * the file and stores the words in the file in a string[] and returns that string[] for further
         * use. The string[] only contains the words and separates by delimiter.
         */
        private static string[] ReadFile(string path)
        {
            //try/Catch for exception handling
            try
            {
                // a StreamReader object is created reading from the path.

                StreamReader readFile = new StreamReader(path);

                //String allwords uses the StreamReader.ReadToEnd to store all words in the file to one string. 
                //i have used the .ToLower method to convert all characters in file to lowercase as it is being saved
                //in the string var.
                String allWords = readFile.ReadToEnd().ToLower();

                //an array is storing the words individually for future access. I am splitting the string by an
                //array of delimiters and removing all empty spaces. This will make sure only the words are present 
                //in the array.
                string[] fileWords = allWords.Split(new char[] {' ', '!', ',', '?', '.', '\n', '\r'},
                    StringSplitOptions.RemoveEmptyEntries);
                return fileWords;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file path is incorrect");
                throw;
            }
            

        }

        /*
         * This method takes in the string array as argument. It goes through each of the words and
         * if the word ends in 't' or 'e', a counter increases. The method returns the number of
         * words that end in 't' or 'e'.
         */
        private static int LastLetter(string[] fileWords)
        {
            var wrdCnt = 0;
            
            //foreach loops through the array one word at a time
            foreach (var t in fileWords)
            {
                var c = t.Last(); //stores the last letter of the word pointed to in the array
                
                //Test if the char c is equal to the chars 't' or 'e'. If so, count is increased
                if (c.Equals('t') || c.Equals('e'))
                {
                    wrdCnt++;
                }
            }
            return wrdCnt;
        }
    }
}