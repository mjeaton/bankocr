using System.Linq;

namespace BankOCR
{
    public class NumberValidator
    {
        public bool IsValid(string number)
        {
            if(number.Length != 9)
                return false;

            var chars = number.ToCharArray();

            var d1 = char.GetNumericValue(chars[8]);
            var d2 = char.GetNumericValue(chars[7]);
            var d3 = char.GetNumericValue(chars[6]);
            var d4 = char.GetNumericValue(chars[5]);
            var d5 = char.GetNumericValue(chars[4]);
            var d6 = char.GetNumericValue(chars[3]);
            var d7 = char.GetNumericValue(chars[2]);
            var d8 = char.GetNumericValue(chars[1]);
            var d9 = char.GetNumericValue(chars[0]);

            double result = d1 + (2*d2) + (3*d3) + (4*d4) + (5*d5) + (6*d6) + (7*d7) + (8*d8) + (9*d9);
            var checksum = result % 11;

            return checksum == 0;
        }
    }
}
