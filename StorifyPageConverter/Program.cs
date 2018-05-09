using System;

namespace StorifyPageConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* get path for input - if folder, loop through
             * get path for output - if folder, use json name + .html
             * 
             */
            Console.WriteLine("Enter the path to the JSON File you wish to convert from: ");
            string jsonPath = Console.ReadLine();

            Console.WriteLine("Enter the path to the HTML File you wish to convert to: ");
            string htmlPath = Console.ReadLine();

            ConvertStorifyJsonToHtml.GetHtmlFileFromJsonFile(jsonPath, htmlPath);
            Console.WriteLine("Done! You can now paste the HTML into the HTML Editor in Wordpress and voila!");
            Console.WriteLine("Be sure to cut/paste the title and description out of the body!");
            Console.Read();
        }
    }
}
