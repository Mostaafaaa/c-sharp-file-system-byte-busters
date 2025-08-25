using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahraa_FileSystem
{
    internal class Helpers
    {
        public static void CreateLargeFile(string path, int numberOfLines)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 1; i <= numberOfLines; i++)
                {
                    writer.WriteLine($"This is line ((({i}))), HI THERE!");
                }
            }
        }
    }   
}
