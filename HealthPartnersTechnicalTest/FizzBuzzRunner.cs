using HealthPartnersTechnicalTest.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersTechnicalTest
{
    public class FizzBuzzRunner
    {
        public static List<string> ExecuteFizzBuzz()
        {
            var returnList = new List<string>();

            var dividerMethods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SelectMany(t => t.GetMethods())
                .Where(m => m.GetCustomAttributes(typeof(DividerAttribute), false).Any())
                .OrderByDescending(m1 => m1.GetCustomAttributes(false).OfType<DividerAttribute>().First().Divider);

            for (int i = 1; i <= 100; i++)
            {
                var dividerMethod = dividerMethods.FirstOrDefault(x => i % x.GetCustomAttributes(false)
                                                  .OfType<DividerAttribute>()
                                                  .First().Divider == 0);

                if (dividerMethod == null)
                {
                    returnList.Add(i.ToString());
                    continue;
                }

                var result = dividerMethod.Invoke(new FizzBuzzResolver(), new object[] { i }) as string;
                returnList.Add(result);
            }

            return returnList;

        }
    }
}
