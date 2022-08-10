using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Controller
{
    public interface ISubscriptionController
    {
        bool IsValidSubscriptionName(string subscriptionName);
    }
}
