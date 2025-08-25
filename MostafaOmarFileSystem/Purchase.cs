using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaOmarFileSystem
{
    /// <summary>
    /// class i wrote to use file json from it by creating object and store it
    /// in the program file
    /// </summary>
    public class Purchase
    {
        public string ProductName { get; set; }
        public DateTime dateTime { get; set; }
        public float ProductPrice  { get; set; }
        public enum ProductCategory
        {
            Electronics,
            Grocery,
            Clothing,
            Furniture,
            Books
        }
        public ProductCategory Category { get; set; }


    }
}
