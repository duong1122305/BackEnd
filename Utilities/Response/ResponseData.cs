using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Response
{
    public class ResponseData<T>
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public T? DataRespone { get; set; }
        public ResponseData()
        {
        }

        public ResponseData(T data)
        {
            IsSuccess = true;
            DataRespone = data;
        }

        public ResponseData(bool isSuccess, string error)
        {
            IsSuccess = isSuccess;
            ErrorMessage = error;
        }
    }
}
