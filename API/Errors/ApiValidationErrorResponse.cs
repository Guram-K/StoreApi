using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public IEnumerable<string> Errors { get; set; }

        private readonly int _statusCode;
        private readonly string _message;

        public ApiValidationErrorResponse() : base(400)
        {
        }
    }
}
