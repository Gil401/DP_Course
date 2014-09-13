using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBApp.Exceptions
{
    public class FacebookAppExceptions : Exception
    {
        public FacebookAppExceptions() : base(string.Format("Error creating feature/s"))
        {
        }
    }
}
