using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_CircleCircumference
{
    public static class Validator
    {

        public static bool radiusIsValid(string inputRadius, out double x )
        {
          if (double.TryParse(inputRadius, out x))
            {
                if (x <= 0)
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
}
