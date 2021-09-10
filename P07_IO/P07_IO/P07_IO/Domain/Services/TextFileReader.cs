
using P07_IO.Model.Responses;
using System;
using System.IO;


namespace P07_IO.Domain.Services
{
    class TextFileReader
    {
        public string TargetFilePath { get; set; }
        

        public TextFileReadResponse ReadFile(string filePath)
        {
            var bf = new byte[1024];
            TargetFilePath = filePath;
            try
            {
                var fs = new FileStream(TargetFilePath, FileMode.Open);
                var pos = fs.Read(bf, 0, 1024);

                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("The text:");
                Console.WriteLine("");

                while (pos != 0)
                {
                    for (int i = 0; i < 1024; i++) Console.Write((Char)bf[i]);
                    pos = fs.Read(bf, 0, 1024);
                }

                return new TextFileReadResponse(true, "Text file read successfully!", TargetFilePath);
            }
            catch(FileNotFoundException e)
            {
                return new TextFileReadResponse(false, "The file path was not fot foud", TargetFilePath);
            }
            
        }
    }
}
