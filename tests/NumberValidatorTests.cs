using Xunit;

namespace BankOCR.Tests
{
    public class NumberValidatorTests
    {
        [Fact]
        public void Short_Number_Should_Return_IsValid_False()
        {
            var validator = new NumberValidator();

            Assert.False(validator.IsValid("3458"));
        }

        [Fact]
        public void Valid_Number_Should_Return_IsValid_True()
        {
            var validator = new NumberValidator();

            var result = validator.IsValid("345882865");
            Assert.True(result);
        }
    }
}
