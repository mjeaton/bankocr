using Xunit;

namespace BankOCR.Tests
{
    public class SegmentParserTests
    {
        [Fact]
        public void Valid_One_Segment_Should_Return_1()
        {
            var parser = new SegmentParser();
            var segment = "   \r\n" +
                          "  |\r\n" +
                          "  |";

            var result = parser.GetNumberForSegment(segment);
            Assert.True(result == "1");
        }

        [Fact]
        public void Valid_Two_Segment_Should_Return_2()
        {
            var parser = new SegmentParser();
            var segment = " _ \r\n" +
                          " _|\r\n" +
                          "|_ ";

            var result = parser.GetNumberForSegment(segment);
            Assert.True(result == "2");
        }
    }
}
