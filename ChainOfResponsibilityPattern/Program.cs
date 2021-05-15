using System.Collections.Generic;
using ChainOfResponsibilityPattern.Classes;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new Dictionary<string, string>();
            PrepareFiles(args, files);
            
            FileDeserializationClient client = new FileDeserializationClient();
            
            foreach (var file in files)
            {
                client.Run(file.Key, file.Value);
            }
        }

        private static void PrepareFiles(string[] filePathes, Dictionary<string, string> files)
        {
            if (filePathes.Length == 0)
            {
                files.Add("testxml",
                    "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>");
                files.Add("testjson", "{\"data\":\"Click Here\",\"size\":36,\"style\":\"bold\"}");
                files.Add("testcsv", "Иванов,25\nПетров,30");
            }
            else
            {
                FileOperator fileOperator = new FileOperator();
                foreach (string filePath in filePathes)
                {
                    files.Add(filePath, fileOperator.ReadTextFromFile(filePath));
                }
            }
        }
    }
}