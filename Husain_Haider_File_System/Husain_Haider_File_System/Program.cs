using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace Husain_Haider_File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Q1	Write a program to create a text file and write "Hello File System" into it.


            String path = "C:\\Users\\lenovo\\Desktop\\textFile1.txt";
            String text = "Hello File System";


            File.WriteAllText(path, text);

            Console.ReadLine();

            //  Q2	Read the content of a text file and print it line by line.
            String path2 = "C:\\Users\\lenovo\\Desktop\\TestLineByLine.txt";
            var Line = File.ReadAllLines(path2);

            foreach (var line in Line)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();


            //  Q3 Append "New Line Added" to an existing file without overwriting it.


            File.AppendAllText(path, "\nNew Line Added");


            Console.ReadLine();


            //  Q4 Copy a file from one directory to another.


            //  new path for the copy File
            String CopyPath = "C:\\Users\\lenovo\\Desktop\\textFile1(Copy).txt";
            File.Copy(path, CopyPath);

            Console.ReadLine();


            //  Q5 	Move a file to a new folder and rename it.

            //  the will move the file: textFile1(Copy) to another path and rename it as: MovedFile
            File.Move(CopyPath, "C:\\Users\\lenovo\\Desktop\\TestingFolder\\MovedFile.txt");

            Console.ReadLine();



            //  Q6	Delete a file safely (no exception if the file does not exist).

            //  here we will delete the file: MovedFile.txt
            try
            {
                File.Delete("C:\\Users\\lenovo\\Desktop\\TestingFolder\\MovedFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //  Q7	List all files in a given directory and print their names.



            var FilesNames = Directory.GetFiles("C:\\Users\\lenovo\\Desktop\\TestingFolder");
            foreach (String FileName in FilesNames)
            {
                Console.WriteLine(FileName);
            }
            Console.ReadLine();


            //  Q8  List all .txt files in a directory (and subdirectories).


            var AllTxtFilesNames = Directory.GetFiles("C:\\Users\\lenovo\\Desktop\\TestingFolder", "*.txt*", SearchOption.AllDirectories);

            foreach (String FileName in AllTxtFilesNames)
            {
                Console.WriteLine(FileName);
            }
            Console.ReadLine();



            //  Q9 	Write a program to get the size (in KB/MB) of all files in a folder.

            var DInfo = new DirectoryInfo("C:\\Users\\lenovo\\Desktop\\TestingFolder");
            var FilesOfDirectoryWithFileForm = DInfo.GetFiles("*.*", SearchOption.AllDirectories);


            //  now to turn the size to KB and MB and divide by 1024 to get to that
            //  to get FileName then FileSize next to it (FileName (FileSize : 10 MB))

            foreach (var File in FilesOfDirectoryWithFileForm)
            {
                Console.Write(File.ToString());
                var FileSize = File.Length;
                int UnitNumber = 0;
                while (FileSize >= 1000)
                {
                    FileSize /= 1024;
                    UnitNumber += 1;

                }

                //  the eazist way to turn 1 to KB and 2 to MB I will just use an array and use the UnitNumber as it's index

                String[] UnitNaming = { "B", "KB", "MB", "GB" };


                Console.WriteLine($" (Size : {FileSize} {UnitNaming[UnitNumber]})");

            }
            Console.ReadLine();





            //  Q10 Write a program that counts how many words are in a file.

            var PathForQ10 = "C:\\Users\\lenovo\\Desktop\\TestingFolder\\subDirectory\\The Road Not Taken.txt";

            var FileToGetNumberOfWords = File.ReadAllLines(PathForQ10);


            int WordsCount = 0;
            String WordFindingRegex = @"\b\w+\b";       //  regex to iderntify words

            //  counting words  using regex(Matches) + 

            MatchCollection maches;
            foreach (var line in FileToGetNumberOfWords)
            {
                maches = Regex.Matches(line, WordFindingRegex);
            
                WordsCount += maches.ToArray().Count();



            }
            Console.WriteLine($"in this file there was about {WordsCount} Words...");



            //  Q11 Use FileStream to write and then read data from a file.

            using (var sr = new StreamReader("C:\\Users\\lenovo\\Desktop\\TestingFolder\\subDirectory\\The Road Not Taken.txt"))
            {
                
                Console.WriteLine(sr.ReadToEnd());
                
                //same result diffrent way
                //string line;
                //while ((line = sr.ReadLine()) is not null) // != null
                //{
                //    Console.WriteLine(line);
                //}
            }




            //  Q12	Monitor a folder using FileSystemWatcher and display a message whenever a file is created.




        }
    }
}
