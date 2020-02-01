using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_Net
{
    public class Verification
    {
        public bool IsNumeric(string number)
        {
            try
            {
                Convert.ToDecimal(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
