using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Application.Exceptions
{
    public class ExceptionModel : ErrorStatusCode
    {
        public IEnumerable<string> Errors { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this); // this = Errors
        
    }

    public class ErrorStatusCode
    {
        public int StatusCode { get; set; }
    }
}
