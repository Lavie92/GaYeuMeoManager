using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Controller
{
    public class InvalidCustomerNameException : Exception
    {
        public string InvalidCustomerName { get; set; }
        public InvalidCustomerNameException() : base() { }
        public InvalidCustomerNameException(string message) : base(message) { }
        public InvalidCustomerNameException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidCustomerNameException(string message, string invalidName)
        {
            this.InvalidCustomerName = invalidName;
        }
    }
}
