using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBApp.Patterns
{
    public interface IBirthdayFilterStrategy
    {
        bool IsBirthdayNeeded(DateTime i_UsersBirthday, BirthdayData i_BData);
    }
}