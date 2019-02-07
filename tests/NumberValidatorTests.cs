using Xunit;

namespace BankOCR.Tests
{
    public class NumberValidatorTests
    {
        [Fact]
        public void Valid_Number_Should_Return_IsValid_True()
        {
            var validator = new NumberValidator();

            Assert.True(validator.IsValid("123456789"));
        }
    }
}
