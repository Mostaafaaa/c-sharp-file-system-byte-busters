using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
//using FileInfo = System.IO.FileInfo;
using GZipStream = System.IO.Compression.GZipStream;


namespace Zahraa_FileSystem
{
    internal class FileMethods
    {
        // 1. Create a text file and write "Hello File System" into it.
        public static void CreateTextFile(string path)
        {
            File.WriteAllText(path, "Hello File System");
        }

        // 2. Read the content of a text file and print it line by line.
        public static void ReadFileLineByLine(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        // 3. Append "New Line Added" to an existing file without overwriting it.
        public static void AppendToFile(string path)
        {
            File.AppendAllText(path, "New Line Added");
        }

        // 4. Copy a file from one directory to another.
        public static void CopyFile(string source, string destination)
        {
            File.Copy(source, destination, true);
        }

        // 5. Move a file to a new folder and rename it.
        public static void MoveAndRenameFile(string source, string newFolder, string newFileName)
        {
            Directory.CreateDirectory(newFolder);
            // Combine the new folder path with the new file name.
            string newFilePath = Path.Combine(newFolder, newFileName);
            if (File.Exists(source))
            {
                // Use Move with overwrite option (true) to rename if the destination file exists.
                // Move method will move and rename the file in one step
                File.Move(source, newFilePath, true);
            }
        }

        // 6. Delete a file safely (no exception if the file does not exist).
        public static void SafeDeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        // 7. List all files in a given directory and print their names.
        public static void ListFilesInDirectory(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }

        // 8. List all .txt files in a directory (and subdirectories).
        public static void ListTxtFiles(string directory)
        {
            string[] txtFiles = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);
            foreach (string txtFile in txtFiles)
            {
                Console.WriteLine(Path.GetFileName(txtFile));
            }
        }

        // 9. Get the size (in KB/MB) of all files in a folder.
        //public static void GetTotalSizeOfFiles(string directory)
        //{
        //    string[] files = Directory.GetFiles(directory);
        //    long totalSize = 0;
        //    foreach (string file in files)
        //    {
        //        FileInfo fileInfo = new FileInfo(file);
        //        totalSize += fileInfo.Length;
        //    }
        //    Console.WriteLine($"Total size: {totalSize / 1024.0} MB");
        //}

        // 10. Count how many words are in a file.
        public static void CountWordsInFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist for word count.");
                return;
            }
            string content = File.ReadAllText(path);
            int wordCount = content.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Total words: {wordCount}");
        }

        //// 11. Use FileStream to write and then read data from a file.
        //public static void FileStreamWriteRead(string path, string text)
        //{
        //    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        //    using (StreamWriter writer = new StreamWriter(fs))
        //    {
        //        writer.WriteLine(text);
        //    }

        //    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        //    using (StreamReader reader = new StreamReader(fs))
        //    {
        //        string readText = reader.ReadToEnd();
        //        Console.WriteLine("Read from FileStream: " + readText);
        //    }
        //}

        //// 12. This method monitors a folder and prints a message whenever a new file is created.
        //// NOTE: The program will keep running until you press Enter.
        //public static void CreatedMessage(string folderPath)
        //{
        //    // Create a FileSystemWatcher to monitor the folder.
        //    using (FileSystemWatcher watcher = new FileSystemWatcher())
        //    {
        //        watcher.Path = folderPath; // Set the folder to watch.
        //        watcher.Filter = "*.*"; // Watch all files.
        //        watcher.NotifyFilter = NotifyFilters.FileName; // Only watch for new files.

        //        // When a new file is created, print its name.
        //        watcher.Created += (sender, e) =>
        //        {
        //            Console.WriteLine($"File created: {e.Name}");
        //        };

        //        watcher.EnableRaisingEvents = true; // Start monitoring.

        //        Console.WriteLine($"Monitoring folder: {folderPath} (Press Enter to exit)");
        //        Console.ReadLine(); // Keep the watcher running until Enter is pressed.
        //    }
        //}

        ////13.Write a program to compress a text file using GZipStream.
        //public static void CompressFile(string sourcePath, string compressedPath)
        //{
        //    using (FileStream originalFileStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
        //    using (FileStream compressedFileStream = new FileStream(compressedPath, FileMode.Create))
        //    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
        //    {
        //        originalFileStream.CopyTo(compressionStream);
        //    }
        //    Console.WriteLine($"File compressed to: {compressedPath}");
        //}

        ////15.Read a very large file line by line without loading the entire file into memory.
        //public static void ReadLargeFileLineByLine(string path)
        //{
        //    using (StreamReader reader = new StreamReader(path))
        //    {
        //        string line;
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            Console.WriteLine(line);
        //        }
        //    }
        //}
    }
}
