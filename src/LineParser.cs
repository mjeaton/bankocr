using System;
using System.Linq;
using System.Collections.Generic;

namespace BankOCR
{
    public class LineParser
    {
        public string ParseLineIntoNumbers(string line1, string line2, string line3)
        {
            var segmentParser = new SegmentParser();
            List<string> segments = parseLineIntoSegments(line1, line2, line3);

            return string.Join("", segments.Select(segmentParser.GetNumberForSegment));
        }

        // candidate for refactoring
        private List<string> parseLineIntoSegments(string line1, string line2, string line3)
        {
            return new List<string>
            {
                $"{line1.Substring(0,3)}\r\n{line2.Substring(0,3)}\r\n{line3.Substring(0,3)}",
                $"{line1.Substring(3,3)}\r\n{line2.Substring(3,3)}\r\n{line3.Substring(3,3)}",
                $"{line1.Substring(6,3)}\r\n{line2.Substring(6,3)}\r\n{line3.Substring(6,3)}",
                $"{line1.Substring(9,3)}\r\n{line2.Substring(9,3)}\r\n{line3.Substring(9,3)}",
                $"{line1.Substring(12,3)}\r\n{line2.Substring(12,3)}\r\n{line3.Substring(12,3)}",
                $"{line1.Substring(15,3)}\r\n{line2.Substring(15,3)}\r\n{line3.Substring(15,3)}",
                $"{line1.Substring(18,3)}\r\n{line2.Substring(18,3)}\r\n{line3.Substring(18,3)}",
                $"{line1.Substring(21,3)}\r\n{line2.Substring(21,3)}\r\n{line3.Substring(21,3)}",
                $"{line1.Substring(24,3)}\r\n{line2.Substring(24,3)}\r\n{line3.Substring(24,3)}"
            };
        }
    }
}
