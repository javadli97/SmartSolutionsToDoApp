using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionsToDoApp.Application.Core
{
    public class AppException
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

        public AppException(string message, int statusCode, string details = null)
        {
            Details = details;
            Message = message;
            StatusCode = statusCode;
        }
    }
}
