using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.DTOS
{
    public class ResponseDtos<T> where T : class
    {
        public ResponseDtos()
        {

        }
        public ResponseDtos(string _statuscode,string _status,string _message, List<T> _results)
        {
            statusCode = _statuscode;
            status = _status;
            message = _message;
            results = _results;

        }

        public ResponseDtos(string _status, string _message, List<T> _results)
        {
           
            status = _status;
            message = _message;
            results = _results;

        }


        public ResponseDtos(string _message, List<T> _results)
        {

            message = _message;
            results = _results;

        }

        public ResponseDtos(string _statuscode,string _status ,string _message)
        {

            statusCode = _statuscode;
            status = _status;
            message = _message;
            

        }

        public string statusCode { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public IEnumerable<T> results { get; set; }
    }
}
