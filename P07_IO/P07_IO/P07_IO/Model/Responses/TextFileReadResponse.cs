using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_IO.Model.Responses
{
    class TextFileReadResponse : BaseResponse
    {
        public string FilePath { get; set; }
        public TextFileReadResponse(bool success, string message, string filePath) : base(success, message)
        {
            FilePath = filePath;
        }
    }
}
