using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You want to create, move or delete file?");
            Console.WriteLine("choose an operation: Create (press C), Move (press M) or Delete (press D)");
            char operation = Convert.ToChar(Console.ReadLine().ToLower().ToUpper());

            switch (operation)
            {
                case 'C': CreateFile(); break;
                case 'M': MoveFile(); break;
                case 'D': DeleteFile(); break;
                default: break;
            }

        }
        private static void CreateFile()
        {

            Console.WriteLine("Please, enter a file name:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string fileRoot = @"C:\Users\Ivan\source\repos\WorkingWithFiles\Data\";
            string filePath = fileRoot + fileName + ".txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {fileName}.txt already exists in {fileRoot}.");
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine($"File {fileName}.txt has been created in {fileRoot}.");
            }

        }
        private static void MoveFile()
        {
            Console.WriteLine("Please, enter a file name to be moved from Data to myData:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string sourceDirectory = @"C:\Users\Ivan\source\repos\WorkingWithFiles\Data\";
            string destinationDirectory = @"C:\Users\Ivan\source\repos\WorkingWithFiles\myData\";

            string filePath = sourceDirectory + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, destinationDirectory + fileName + ".txt");
                Console.WriteLine($"File {fileName} has been moved in {destinationDirectory}.");
            }
            else
            {
                Console.WriteLine($"{fileName} not found in Data.");
            }
        }
        private static void DeleteFile()
        {

            Console.WriteLine("Please, enter file to delete:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string fileRooth = @"C:\Users\Ivan\source\repos\WorkingWithFiles\Data\";
            string filePath = fileRooth + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {fileName}.txt has been deleted.");
            }
            else
            {
                Console.WriteLine($"{fileName}.txt was not found.");
            }

        }
    }
}







