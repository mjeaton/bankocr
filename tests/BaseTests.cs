using System;
using System.Collections.Generic;
using Xunit;

namespace BankOCR.Tests
{
    public class BaseTests
    {
        [Fact]
        public void Valid_line_should_return_9_segments()
        {
            var data = new string[]
            {
            "    _  _     _  _  _  _  _ ",
            "  | _| _||_||_ |_   ||_||_|",
            "  ||_  _|  | _||_|  ||_| _|"
            };

            // basically, a bunch of substring operations
            var digitOne = $"{data[0].Substring(0,3)}\r\n{data[1].Substring(0,3)}\r\n{data[2].Substring(0,3)}";
            var digitTwo = $"{data[0].Substring(3,3)}\r\n{data[1].Substring(3,3)}\r\n{data[2].Substring(3,3)}";
            var digitThree = $"{data[0].Substring(6,3)}\r\n{data[1].Substring(6,3)}\r\n{data[2].Substring(6,3)}";
            var digitFour = $"{data[0].Substring(9,3)}\r\n{data[1].Substring(9,3)}\r\n{data[2].Substring(9,3)}";
            var digitFive = $"{data[0].Substring(12,3)}\r\n{data[1].Substring(12,3)}\r\n{data[2].Substring(12,3)}";
            var digitSix = $"{data[0].Substring(15,3)}\r\n{data[1].Substring(15,3)}\r\n{data[2].Substring(15,3)}";
            var digitSeven = $"{data[0].Substring(18,3)}\r\n{data[1].Substring(18,3)}\r\n{data[2].Substring(18,3)}";
            var digitEight = $"{data[0].Substring(21,3)}\r\n{data[1].Substring(21,3)}\r\n{data[2].Substring(21,3)}";
            var digitNine = $"{data[0].Substring(24,3)}\r\n{data[1].Substring(24,3)}\r\n{data[2].Substring(24,3)}";

            var segments = new List<string>()
            {
                digitOne,
                digitTwo,
                digitThree,
                digitFour,
                digitFive,
                digitSix,
                digitSeven,
                digitEight,
                digitNine
            };
            Assert.True(segments.Count == 9);
        }

        [Fact]
        public void Valid_Segment_Should_Be_A_Number()
        {
            var data = new string[]
            {
            "    _  _     _  _  _  _  _ ",
            "  | _| _||_||_ |_   ||_||_|",
            "  ||_  _|  | _||_|  ||_| _|"
            };

            // basically, a bunch of substring operations
            var digitOne = $"{data[0].Substring(0,3)}\r\n{data[1].Substring(0,3)}\r\n{data[2].Substring(0,3)}";

            var one = "   \r\n" +
                      "  |\r\n" +
                      "  |";

            var result = "";
            if(digitOne == one)
                result = "1";

            Assert.True(result == "1");
        }

        [Fact]
        public void Valid_Number_Checksum_Should_Equal_Zero()
        {
            // 3  4  5  8  8  2  8  6  5
            // -------------------------
            // 9  8  7  6  5  4  3  2  1
            //var number = "345882865";

            // checksum calculation:
            // (d1 + 2*d2 + 3*d3 +... +9*d9) mod 11 = 0

            var checksum = (5 + (2*6) + (3*8) + (4*2) + (5*8) + (6*8) + (7*5) + (8*4) + (9*3)) % 11;
            Assert.True(checksum == 0);
        }

        [Fact]
        public void Invalid_Number_Checksum_Should_Not_Equal_Zero()
        {
            //var number = "923456789";

            // checksum calculation:
            // (d1 + 2*d2 + 3*d3 +... +9*d9) mod 11 = 0

            var checksum = (9 + (2*8) + (3*7) + (4*6) + (5*5) + (6*4) + (7*3) + (8*2) + (9*9)) % 11;
            Assert.False(checksum == 0);
        }

    }
}
