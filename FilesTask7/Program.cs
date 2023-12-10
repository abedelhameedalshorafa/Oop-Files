using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = "G:\\OrangeTasks\\Oop&Files\\Oop&Files\\readFile.txt";
            string information = ReadFromFileLineByLine(sourceFilePath);
            Console.WriteLine(information);
            Console.WriteLine($"the number of characters is : {getTotalNumberOfCharacters(information)}");
            Console.WriteLine($"the number of words is : {getTotalNumberOfwords(information)}");

        }

        static int getTotalNumberOfwords(string information)
        {
            int count = 0;
            for (int i = 1; i < information.Length; i++)
            {
                if (!char.IsWhiteSpace(information[i - 1]) && char.IsWhiteSpace(information[i]))
                {
                    count++;
                }
            }
            if (!char.IsWhiteSpace(information[information.Length - 1]))
            {
                count++;
            }
            return count;
        }

        static int getTotalNumberOfCharacters(string information)
        {
            int count = 0;
            for (int i = 0; i < information.Length; i++)
            {
                if (char.IsWhiteSpace(information[i]))
                {
                    count++;
                }
            }
            return information.Length - count;
        }


        static string ReadFromFileLineByLine(string sourceFilePath)
        {
            try
            {
                string information = string.Empty;
                using (StreamReader reader = new StreamReader(sourceFilePath))
                {

                    while (!reader.EndOfStream)
                    {
                        information += " " + reader.ReadLine();
                    }

                }
                return information;
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
    }
}
