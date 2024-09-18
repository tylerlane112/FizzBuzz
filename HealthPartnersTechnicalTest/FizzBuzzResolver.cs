using HealthPartnersTechnicalTest.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersTechnicalTest
{
    public class FizzBuzzResolver
    {
        [Divider(3)]
        public static string ResolveFizz(int value)
        {
            var currentMethod = MethodBase.GetCurrentMethod();
            var dividerAttribute = (DividerAttribute)currentMethod.
                                    GetCustomAttributes(typeof(DividerAttribute), false)[0];

            if (value % dividerAttribute.Divider == 0)
            {
                return "Fizz";
            }

            return value.ToString();
        }
    }
}
