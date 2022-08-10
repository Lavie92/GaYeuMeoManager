using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Controller
{
    public class CustomerController : ICustomerController
    {
        public bool IsEmailValid(string email)
        {
            var pattern = @"(^[a-zA-Z0-9_.]+[@]{1}[a-z0-9]+[\.][a-z]+$)";
            var regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        public bool IsNameValid(string name)
        {
            //var pattern = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$$";
            var pattern = @"^[A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(name);
        }
        
        public bool IsPhoneValid(string phone)
        {
            var pattern = @"(84|0[3|5|7|8|9])+([0-9]{8})";
            var regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }
    }
}
