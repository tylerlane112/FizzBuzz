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
            var dividerAttribute = GetDividerAttribute(MethodBase.GetCurrentMethod());
            if (value % dividerAttribute.Divider == 0)
            {
                return "Fizz";
            }

            return value.ToString();
        }

        [Divider(5)]
        public static string ResolveBuzz(int value)
        {
            var dividerAttribute = GetDividerAttribute(MethodBase.GetCurrentMethod());
            if (value % dividerAttribute.Divider == 0)
            {
                return "Buzz";
            }

            return value.ToString();
        }

        [Divider(15)]
        public static string ResolveFizzBuzz(int value)
        {
            var dividerAttribute = GetDividerAttribute(MethodBase.GetCurrentMethod());
            if (value % dividerAttribute.Divider == 0)
            {
                return "FizzBuzz";
            }

            return value.ToString();
        }

        private static DividerAttribute GetDividerAttribute(MethodBase? methodBase)
        {
            return (DividerAttribute)methodBase.GetCustomAttributes(typeof(DividerAttribute), false)[0];
        }
    }
}
