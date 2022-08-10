using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Controller
{
    internal class InvalidPhoneException : Exception
    {
        public string invalidPhone { get; set; }
        public InvalidPhoneException() : base()
        {

        }
        public InvalidPhoneException(string message) : base(message) { }
        public InvalidPhoneException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidPhoneException(string message, string invalidPhone) : base(message)
        {
            this.invalidPhone = invalidPhone;
        }
    }
}
