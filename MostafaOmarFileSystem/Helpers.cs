using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MostafaOmarFileSystem
{
    public class Helpers
    {
        //Helper function that Print text file content line by line
        public static void PrintTextFileLIneByLine(string FilePath)
        {
            string[] FileContent = File.ReadAllLines(FilePath);
            foreach (string line in FileContent)
            {
                Console.WriteLine(line);
            }
        }
        //1
        public static void CreateTextFile(string FilePath)
        {
            File.WriteAllText(FilePath, "Hello File System");
        }
        //2
        public static void ReadContentOfTextFileAndPrintIt(string FilePath)
        {
            FilePath = @"D:\CSharp\Halal almshakl\MostafaOmarFileSystem\textFile2.txt";
            PrintTextFileLIneByLine(FilePath);
        }
        //3 
        public static void AppendNewLine(string FilePath,string text)
        {
            File.AppendAllText(FilePath, text);
        }
        //4
        public static void CopyFile(string filePath, string destinationFolder)
        {
            string fileName = Path.GetFileName(filePath);
            string destinationPath = Path.Combine(destinationFolder, fileName);
            File.Copy(filePath, destinationPath);
            AppendNewLine(destinationPath, "\n\n-- text file had been copy to new folder --");
            PrintTextFileLIneByLine(destinationPath);
        }
        //5
        public static void MoveFileAndReNameIt(string filePath, string destinationFolder, string newFileName)
        {
            string destinationFilePath = Path.Combine(destinationFolder, newFileName);
            File.Move(filePath, destinationFilePath);
            Console.WriteLine("file moved and Renamed");
        }
        //6
        public static void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("The File Has Been deleted.");
            }
            else
            {
                Console.WriteLine("The File does not exist. Nothing to delete.");
            }
        }
        //7
        public static void ListAllFiles(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
        //8
        public static void ListAllFilesWithTxt(string folderPath)
        {
            string[] txtFiles = Directory.GetFiles(folderPath, "*.txt", SearchOption.AllDirectories);
            foreach (string file in txtFiles)
            {
                Console.WriteLine(file);
            }
        }
        //9
        public static void GetSizeOfAllFilesInFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            long totalBytes = 0;

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                totalBytes += info.Length;
            }
            Console.WriteLine($"Total size In KB: {totalBytes / 1024.0} KB");
            Console.WriteLine($"Total size In MB: {totalBytes / (1024.0 * 1024.0)} MB");

        }
        //10
        public static int CountWordsInFile(string filePath)
        {
            string text = File.ReadAllText(filePath);
            // \b mean word boundary
            int wordCount = Regex.Matches(text, @"\b\w+\b").Count;
            return wordCount;
        }
        //13
        public static void CompressFile(string sourceFile, string destinationFile)
        {
            using (FileStream originalFile = new FileStream(sourceFile, FileMode.Open))
            using (FileStream compressedFile = new FileStream(destinationFile, FileMode.Create))
            using (GZipStream compression = new GZipStream(compressedFile, CompressionMode.Compress))
            {
                originalFile.CopyTo(compression);
            }
            Console.WriteLine("The File Is Compressed");
        }

        //15
        public static void ReadLargeFileLineByLine(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }
    }
}
