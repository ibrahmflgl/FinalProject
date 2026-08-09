using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //sucses başarılı demek message ise mesaj demek
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;

        }

        public string Message {  get; }

        public bool Success {  get; }
    }
}
