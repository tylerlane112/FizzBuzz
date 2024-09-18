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
    }
}