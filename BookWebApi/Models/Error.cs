using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.Models
{
    public class Error
    {
        public int status { get; set; }
        public string message { get; set; }

        public Error(int status, string message)
        {
            this.status = status;
            this.message = message;
        }
    }
}
