using System.Collections.Generic;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string> () {"blue", "green", "red", "yellow", "orange", "purple", "brown", "gray", "black" };
            
            //Order the list of colors by length of the color name using LINQ

            var lengthOfColorName = colors.OrderBy (c => c.Length);    //where c is a string in the list and .Length gives the length of that string
            
            foreach (var item in lengthOfColorName) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
