using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.DTOS
{
    public class ResponseDto<T> where T : class
    {
       
            public ResponseDto()
            {

            }
            public ResponseDto(string _statuscode, string _status, string _message, T _results)
            {
                statusCode = _statuscode;
                status = _status;
                message = _message;
                results = _results;

            }

            public ResponseDto(string _status, string _message, T _results)
            {

                status = _status;
                message = _message;
                results = _results;

            }


            public ResponseDto(string _message, T _results)
            {


                message = _message;
                results = _results;

            }

            public ResponseDto(string _statusCode,string _status,string _message)
            {

            statusCode = _statusCode;
                message = _message;
                status = _status;

            }

            public string statusCode { get; set; }
            public string status { get; set; }
            public string message { get; set; }
            public T results { get; set; }
        }
    
}
