namespace BankOCR
{
    public class SegmentParser
    {
        // candidate for refactoring
        public string GetNumberForSegment(string segment)
        {
            if(segment == " _ \r\n" +
                          "| |\r\n" +
                          "|_|"
            )
                return "0";

            if(segment == "   \r\n" +
                          "  |\r\n" +
                          "  |"
            )
                return "1";

            if(segment == " _ \r\n" +
                          " _|\r\n" +
                          "|_ "
            )
                return "2";

            if(segment == " _ \r\n" +
                          " _|\r\n" +
                          " _|"
            )
                return "3";

            if(segment == "   \r\n" +
                          "|_|\r\n" +
                          "  |"
            )
                return "4";

            if(segment == " _ \r\n" +
                          "|_ \r\n" +
                          " _|"
            )
                return "5";

            if(segment == " _ \r\n" +
                          "|_ \r\n" +
                          "|_|"
            )
                return "6";

            if(segment == " _ \r\n" +
                          "  |\r\n" +
                          "  |"
            )
                return "7";

            if(segment == " _ \r\n" +
                          "|_|\r\n" +
                          "|_|"
            )
                return "8";

            if(segment == " _ \r\n" +
                          "|_|\r\n" +
                          " _|"
            )
                return "9";
            
            return "";
        }
    }
}
