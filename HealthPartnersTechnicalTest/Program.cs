using HealthPartnersTechnicalTest.Attributes;

namespace HealthPartnersTechnicalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzResult = FizzBuzzRunner.ExecuteFizzBuzz();

            foreach (var result in fizzBuzzResult)
            {
                Console.WriteLine(result);
            }
        }
    }
}