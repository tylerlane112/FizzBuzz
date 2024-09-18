using HealthPartnersTechnicalTest.Attributes;

namespace HealthPartnersTechnicalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dividerMethods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SelectMany(t => t.GetMethods())
                .Where(m => m.GetCustomAttributes(typeof(DividerAttribute), false).Any());

        }
    }
}