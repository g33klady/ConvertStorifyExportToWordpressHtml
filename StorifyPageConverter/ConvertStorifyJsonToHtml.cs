using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StorifyPageConverter
{
    public static class ConvertStorifyJsonToHtml
    {
        public static string GetStringForElement(Element element)
        {
            var result = "";

            if(element.type == "text")
            {
                result = String.Format("<p>{0}</p>", element.data.text);
            }
            else if (element.type == "image" || element.type == "video" || element.type == "link")
            {
                result = element.permalink;
            }
            else
            {
                throw new NotImplementedException();
            }

            return result;
        }

        public static Rootobject GetObjectFromFile(string path)
        {
            string jsonObject;
            using (StreamReader sr = new StreamReader(path))
            {
                jsonObject = sr.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<Rootobject>(jsonObject);
        }

        public static void WriteToFile(string path, List<string> content)
        {
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (String c in content)
                    tw.WriteLine(c);
            }
        }

        public static void GetHtmlFileFromJsonFile(string jsonFile, string htmlFile)
        {
            /* get object from jsonfile
             * loop through elements in curObject
             * - get string for each element
             * output to htmlfile
             */
            List<string> content = new List<string>();
            var curObject = GetObjectFromFile(jsonFile);
            content.Add("Title: " + curObject.content.title);
            content.Add("Description: " + curObject.content.description);
            content.Add("<p>Originally published on Storify: " + curObject.content.date.published + "</p>");
            foreach (Element element in curObject.content.elements)
            {
                content.Add(GetStringForElement(element) + "\r\n");
            }

            WriteToFile(htmlFile, content);
        }
    }
}
