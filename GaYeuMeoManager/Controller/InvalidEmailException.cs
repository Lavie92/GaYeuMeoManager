using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Controller
{
    public class InvalidEmailException : Exception
    {
        public string invalidEmail { get; set; }
        public InvalidEmailException():base()   { }
        public InvalidEmailException(string message) : base(message) { }
        public InvalidEmailException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidEmailException(string message, string invalidEmail) : base(message)
        {
            this.invalidEmail = invalidEmail;
        }
    }
}
