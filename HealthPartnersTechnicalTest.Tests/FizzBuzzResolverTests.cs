namespace HealthPartnersTechnicalTest.Tests
{
    [TestClass]
    public class FizzBuzzResolverTests
    {
        [TestMethod]
        public void ResolveFizz_ReceivesValueDivisableByThree_ReturnsFizz()
        {
            var result = FizzBuzzResolver.ResolveFizz(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void ResolveFizz_ReceivesValueNotDivisableByThree_ReturnsInput()
        {
            var result = FizzBuzzResolver.ResolveFizz(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void ResolveBuzz_ReceivesValueDivisableByFive_ReturnsBuzz()
        {
            var result = FizzBuzzResolver.ResolveBuzz(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void ResolveBuzz_ReceivesValueNotDivisableByFive_ReturnsInput()
        {
            var result = FizzBuzzResolver.ResolveBuzz(9);
            Assert.AreEqual("9", result);
        }

        [TestMethod]
        public void ResolveFizzBuzz_ReceivesValueDivisableByFifteen_ReturnsFizzBuzz()
        {
            var result = FizzBuzzResolver.ResolveFizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void ResolveFizzBuzz_ReceivesValueNotDivisableByFifteen_ReturnsInput()
        {
            var result = FizzBuzzResolver.ResolveFizzBuzz(16);
            Assert.AreEqual("16", result);
        }
    }
}