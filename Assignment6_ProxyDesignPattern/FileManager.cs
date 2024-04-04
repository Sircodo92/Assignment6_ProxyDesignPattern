using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ProxyDesignPattern
{
    // Class implementing the real file manager
    internal class FileManager : IFile
    {
        // Method to read the content of a file
        public void ReadFile(string fileName)
        {
            // Read the content of the file
            string content = File.ReadAllText(fileName);
            // Output the content to the console
            Console.WriteLine($"File content: \n{content}");
        }
    }
}
