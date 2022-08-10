using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Controller
{
    public class InvalidSubscriptionNameException : Exception
    {
        public string SubscriptionName { get; set; }
        public InvalidSubscriptionNameException() : base() { }
        public InvalidSubscriptionNameException(string message) : base(message) { }
        public InvalidSubscriptionNameException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidSubscriptionNameException(string message, string invalidName)
        {
            this.SubscriptionName = invalidName;
        }
    }
}
