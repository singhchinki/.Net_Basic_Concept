
namespace TestNameValidation
{
    public class Tests
    {

        [Test]
        public void GivenFirstName_CheckRegexPattern_ReturnTrue()
        {
            string FirstName = "Chinki";
            RegexWithTesting.RegexNameValidation check = new RegexWithTesting.RegexNameValidation();
            bool actualResult = check.FirstNameValidation(FirstName);
            Assert.IsTrue(actualResult);
        }
        [Test]
        public void GivenLastName_CheckRegexPattern_ReturnTrue()
        {
            string LastName = "Singh";
            RegexWithTesting.RegexNameValidation check = new RegexWithTesting.RegexNameValidation();
            bool actualResult = check.LastNameValidation(LastName);
            Assert.IsTrue(actualResult);
        }
    }
}