using System;
using System.IO;

namespace BankOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank OCR Kata");

            // Story 1
            // read file and parse data into numbers
            // Need a way to read the file, parse it into chunks (4 lines) so it can then be reduced to individual
            // segments that will be converted into numbers.
            var lines = File.ReadAllLines("../data.txt");
            for(int x = 0; x <= lines.Length - 1; x += 4) 
            {
                // each number consists of 4 lines - 3 with data and a blank line at the end
                var line1 = lines[x];
                var line2 = lines[x + 1];
                var line3 = lines[x + 2];
                
                System.Console.WriteLine($"{line1}\r\n{line2}\r\n{line3}");

                // hand off the line to something that will cut it into individual segments and then convert each segment into a number
            }

            // Story 2
            // validation of numbers
            // pass a converted number into a validator and calculate the checksum

            // Story 3
            // formatted output file
            // ILL, ERR and happy path

            // Story 4
            // deal with ambiguous numbers
            // ???
        }
    }
}
