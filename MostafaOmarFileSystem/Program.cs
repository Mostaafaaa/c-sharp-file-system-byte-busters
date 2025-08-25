using System;
using System.IO;
using System.Xml.Linq;
using System.Text.Json;
using static MostafaOmarFileSystem.Purchase;

namespace MostafaOmarFileSystem;

class Program
{
    static void Main(string[] args)
    {
        ////1
        //Console.WriteLine("-------------1--------------");
        //string FilePath1 = @"D:\CSharp\Halal almshakl\MostafaOmarFileSystem\textFile1.txt";
        //Helpers.CreateTextFile(FilePath1);
        //Console.WriteLine("\nText File Has Been Created!");
        //Helpers.PrintTextFileLIneByLine(FilePath1);
        //Console.WriteLine("\n-------------2--------------");
        ////2
        //string FilePath2 = @"D:\CSharp\Halal almshakl\MostafaOmarFileSystem\textFile2.txt";
        //Helpers.ReadContentOfTextFileAndPrintIt(FilePath2);
        ////3
        //Console.WriteLine("\n-------------3--------------");
        //Helpers.AppendNewLine(FilePath1, ", This is new text I append it");
        //Helpers.PrintTextFileLIneByLine(FilePath1);
        ////4
        //Console.WriteLine("\n-------------4--------------");
        //string DestinationFolder = @"D:\CSharp\Halal almshakl\MostafaOmarFileSystem\NewFolder";
        //Helpers.CopyFile(FilePath1, DestinationFolder);
        ////5
        //Console.WriteLine("\n-------------5--------------");
        //string NewFileName = "NewFileName.txt";
        //Helpers.MoveFileAndReNameIt(FilePath1, DestinationFolder, NewFileName);
        ////6
        //Console.WriteLine("\n-------------6--------------");
        //Helpers.DeleteFile("NewFileName.txt");
        ////7
        //Console.WriteLine("\n-------------7--------------");
        //Helpers.ListAllFiles(@"D:\CSharp\Halal almshakl\MostafaOmarFileSystem");
        ////8
        //Console.WriteLine("\n-------------8--------------");
        //Helpers.ListAllFilesWithTxt(@"D:\CSharp\Halal almshakl\MostafaOmarFileSystem");
        ////9
        //Console.WriteLine("\n-------------9--------------");
        //Helpers.GetSizeOfAllFilesInFolder(@"D:\CSharp\Halal almshakl\MostafaOmarFileSystem");
        ////10
        //Console.WriteLine("\n-------------10--------------");
        //int WordsInFile = Helpers.CountWordsInFile(FilePath2);
        //Console.WriteLine($"Number of words in the file: {WordsInFile}");

        ////11
        //Console.WriteLine("\n-------------11--------------");
        ////13
        //Console.WriteLine("\n-------------13--------------");
        //string originalFile = @"D:\CSharp\Halal almshakl\MostafaOmarFileSystem\NewFolder\textFile1.txt";
        //string compressedFile = @"D:\CSharp\Halal almshakl\MostafaOmarFileSystem\textFile1.gz";

        //Helpers.CompressFile(originalFile, compressedFile);
        ////15
        //Console.WriteLine("\n-------------15--------------");
        //Helpers.ReadLargeFileLineByLine(FilePath2);

        // Json File 
        Purchase product1 = new Purchase
        {
            ProductName = "Iphone 11 Pro Max",
            dateTime = DateTime.Now,
            ProductPrice = 499.999f,
            Category = ProductCategory.Electronics
        };

        string FilePath = "Purchase.json";
        // convert to json file
        string SerializedJsonFile = JsonSerializer.Serialize(product1);
        File.WriteAllText(FilePath, SerializedJsonFile);

        // convert every field in json file back to its type
        var purchase = JsonSerializer.Deserialize<Purchase>(SerializedJsonFile);

        Console.WriteLine(SerializedJsonFile);
        Console.WriteLine($"\n{purchase.ProductName}\n{purchase.dateTime}\n{purchase.ProductPrice+"$"}\n{purchase.Category}");
    }
}