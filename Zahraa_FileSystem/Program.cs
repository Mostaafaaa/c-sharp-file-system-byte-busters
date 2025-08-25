using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zahraa_FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "E:\\Problems_Solver_Bootcamp\\FileSystem in C#\\test.txt";
            string sourcePath = "E:\\Problems_Solver_Bootcamp\\FileSystem in C#\\test.txt";
            string destinationPath = "E:\\Problems_Solver_Bootcamp\\FileSystem in C#222\\test_copy.txt";
            string newFolderPath = "E:\\Problems_Solver_Bootcamp\\FileSystem in C#333";
            string directoryPath = "E:\\Problems_Solver_Bootcamp\\FileSystem in C#";
            string fsPath = "E:\\Problems_Solver_Bootcamp\\FileSystem in C#\\filestream_test.txt";
            string fsText = "Hello from FileStream!";

            FileMethods.CreateTextFile(filePath);
            FileMethods.ReadFileLineByLine(filePath);
            FileMethods.AppendToFile(filePath);
            FileMethods.CopyFile(sourcePath, destinationPath);
            FileMethods.MoveAndRenameFile(filePath, newFolderPath, "renamed_test.txt");
            FileMethods.SafeDeleteFile(filePath);
            FileMethods.ListFilesInDirectory(directoryPath);
            FileMethods.ListTxtFiles(directoryPath);
            //FileMethods.GetTotalSizeOfFiles(directoryPath);
            FileMethods.CountWordsInFile(filePath);
            //FileMethods.FileStreamWriteRead(fsPath, fsText);
            //FileMethods.CreatedMessage(directoryPath);
            //FileMethods.CompressFile(fsPath, fsPath + ".gz");
            Helpers.CreateLargeFile("E:\\Problems_Solver_Bootcamp\\FileSystem in C#\\largefile.txt", 100);
            //FileMethods.ReadLargeFileLineByLine("E:\\Problems_Solver_Bootcamp\\FileSystem in C#\\largefile.txt");
        }

    }
}

