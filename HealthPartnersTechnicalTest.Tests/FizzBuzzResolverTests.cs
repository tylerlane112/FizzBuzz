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
    }
}