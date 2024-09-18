using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersTechnicalTest.Tests
{
    [TestClass]
    public class FizzBuzzRunnerTests
    {
        [TestMethod]
        public void ExecuteFizzBuzz_Contains100Items()
        {
            var result = FizzBuzzRunner.ExecuteFizzBuzz();
            Assert.AreEqual(result.Count, 100);
        }

        [TestMethod]
        public void ExecuteFizzBuzz_ContainsFizz()
        {
            var result = FizzBuzzRunner.ExecuteFizzBuzz();
            Assert.AreEqual(result.Contains("Fizz"), true);
        }

        [TestMethod]
        public void ExecuteFizzBuzz_ContainsBuzz()
        {
            var result = FizzBuzzRunner.ExecuteFizzBuzz();
            Assert.AreEqual(result.Contains("Buzz"), true);
        }

        [TestMethod]
        public void ExecuteFizzBuzz_ContainsFizzBuzz()
        {
            var result = FizzBuzzRunner.ExecuteFizzBuzz();
            Assert.AreEqual(result.Contains("FizzBuzz"), true);
        }
    }
}
