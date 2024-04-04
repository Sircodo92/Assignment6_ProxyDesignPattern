using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ProxyDesignPattern
{
    // Class implementing the proxy for secure file access
    internal class SecureFileProxy : IFile
    {
        private readonly IFile file; // Private field to hold the reference to the real file manager

        // Constructor initializing the proxy with a real file manager
        public SecureFileProxy()
        {
            file = new FileManager(); // Creating an instance of the real file manager
        }

        // Method to read a file, implementing the IFile interface
        public void ReadFile(string fileName)
        {
            // Check if the file is valid before reading
            if (IsValidFile(fileName))
            {
                Console.WriteLine($"Reading file: {fileName}");
                file.ReadFile(fileName); // Delegate the file reading to the real file manager
            }
            else
            {
                Console.WriteLine("Error: Invalid file or file size exceeds limit");
            }
        }

        // Private method to validate file before reading
        private bool IsValidFile(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName); // Get information about the file
            // Check if the file extension is not '.exe' and file size is within limit (1MB)
            return fileInfo.Extension.ToLower() != ".exe" && fileInfo.Length <= 1024 * 1024;
        }
    }
}
