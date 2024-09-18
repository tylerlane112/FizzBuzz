using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersTechnicalTest
{
    public class FizzBuzzResolver
    {
        public static string ResolveFizz(int value)
        {
            if (value % 3 == 0)
            {
                return "Fizz";
            }

            return value.ToString();
        }
    }
}
