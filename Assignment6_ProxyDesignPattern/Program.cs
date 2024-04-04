using System;
using System.IO;

namespace Assignment6_ProxyDesignPattern
{
    partial class Program
    {

        static void Main(string[] args)
        {
            // Create a file named "omoruyi.txt" and write content to it
            // Create a file named "omoruyi.exe" 
            CreateExampleFile();

            static void CreateExampleFile() //
            {
                string filePath = "omoruyi.txt";
                string exeFilePath = "omoruyi.exe";


                // Check if the file already exists
                if (!File.Exists(filePath))
                {
                    // Create a new file and write content to it
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine("Hello World, I love Data Structure.");
                    }

                    Console.WriteLine($"File '{filePath} created successfully.");
                }
                else
                {
                    Console.WriteLine($"File '{filePath} already exists.");
                }

                // Check if the .exe file already exists
                if (!File.Exists(exeFilePath))
                {
                    // Create a new .exe file
                    using (FileStream fs = File.Create(exeFilePath))
                    {
                        // You can write any content to the .exe file if needed
                    }

                    Console.WriteLine($"File '{exeFilePath}' created successfully.");
                }
                else
                {
                    Console.WriteLine($"File '{exeFilePath}' already exists.");
                }
            }

            // Create a secure file proxy
            IFile file = new SecureFileProxy();

            try
            {
                // Read a file
                file.ReadFile("omoruyi.txt"); 

                // Try reading an invalid file
                file.ReadFile("omoruyi.exe"); 
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

       
    }
}
