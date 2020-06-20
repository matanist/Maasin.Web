using System;
namespace Maasin.WEB.Models
{
    public class ApiResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public object Set { get; set; }
    }
}
