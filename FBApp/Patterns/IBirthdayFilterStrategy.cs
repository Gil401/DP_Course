using System;

namespace FBApp.Patterns
{
    public interface IBirthdayFilterStrategy
    {
        bool IsBirthdayNeeded(DateTime i_UsersBirthday, BirthdayData i_BData);
    }
}