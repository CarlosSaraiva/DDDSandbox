using System;
using System.Text.RegularExpressions;
using SpaUserControl.Common.Resources;

namespace SpaUserControl.Common.Validation
{
    public static class EmailAssertionConcern
    {
        public static Void AssertIsValid(string email)
        {
            if (!Regex.IsMatch(email, @"[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}"))
            {
                throw new Exception(Errors.InvalidEmail);
            }            
        }
        
    }
}
