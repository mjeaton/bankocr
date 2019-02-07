using System;
using System.Collections.Generic;
using Xunit;

namespace tests
{
    public class UnitTest1
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
            var digitOne = $"{data[0].Substring(0,3)}\r\n{data[1].Substring(0,3)}\r\n{data[0].Substring(0,3)}";
            var digitTwo = $"{data[0].Substring(3,3)}\r\n{data[1].Substring(3,3)}\r\n{data[0].Substring(3,3)}";
            var digitThree = $"{data[0].Substring(6,3)}\r\n{data[1].Substring(6,3)}\r\n{data[0].Substring(6,3)}";
            var digitFour = $"{data[0].Substring(9,3)}\r\n{data[1].Substring(9,3)}\r\n{data[0].Substring(9,3)}";
            var digitFive = $"{data[0].Substring(12,3)}\r\n{data[1].Substring(12,3)}\r\n{data[0].Substring(12,3)}";
            var digitSix = $"{data[0].Substring(15,3)}\r\n{data[1].Substring(15,3)}\r\n{data[0].Substring(15,3)}";
            var digitSeven = $"{data[0].Substring(18,3)}\r\n{data[1].Substring(18,3)}\r\n{data[0].Substring(18,3)}";
            var digitEight = $"{data[0].Substring(21,3)}\r\n{data[1].Substring(21,3)}\r\n{data[0].Substring(21,3)}";
            var digitNine = $"{data[0].Substring(24,3)}\r\n{data[1].Substring(24,3)}\r\n{data[0].Substring(24,3)}";

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
    }
}
