using Xunit;
using BankOCR;

namespace BankOCR.Tests
{
    public class LineParserTests
    {

        [Fact]
        public void Valid_Line_Should_Return_Number()
        {
            var parser = new LineParser();
            var data = new string[]
            {
            "    _  _     _  _  _  _  _ ",
            "  | _| _||_||_ |_   ||_||_|",
            "  ||_  _|  | _||_|  ||_| _|"
            };

            var result = parser.ParseLineIntoNumbers(data[0], data[1], data[2]);
            Assert.True(result == "123456789");
        }

    }
}
