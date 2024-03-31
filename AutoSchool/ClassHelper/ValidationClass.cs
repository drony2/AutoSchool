using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSchool.ClassHelper
{
    internal class ValidationClass
    {
        public static bool ValidationNotClearString(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }

            return true;
        }
    }
}
