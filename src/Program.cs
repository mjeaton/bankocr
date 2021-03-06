﻿using System;
using System.Collections.Generic;
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
            var numbers = new List<string>();
            var parser = new LineParser();
            var validator = new NumberValidator();
            for(int x = 0; x <= lines.Length - 1; x += 4) 
            {
                // each number consists of 4 lines - 3 with data and a blank line at the end
                var line1 = lines[x];
                var line2 = lines[x + 1];
                var line3 = lines[x + 2];
                
                //System.Console.WriteLine($"{line1}\r\n{line2}\r\n{line3}");

                // hand off the line to something that will cut it into individual segments and then convert each segment into a number
                numbers.Add(parser.ParseLineIntoNumbers(line1, line2, line3));
            }

            System.Console.WriteLine("Initial results:");

            // Story 2
            // validation of numbers
            // pass a converted number into a validator and calculate the checksum

            // Story 3
            // formatted output file
            // ILL, ERR and happy path

            var outputFileName = "output.txt";
            // write to an output file (console for now)
            foreach(var n in numbers)
            {
                if(validator.IsValid(n))
                {
                    System.Console.WriteLine(n);
                } else if(n.Contains('?'))
                {
                    System.Console.WriteLine($"{n} ILL");
                } else 
                {
                    System.Console.WriteLine($"{n} ERR");
                }
            }


            // Story 4
            // deal with ambiguous numbers
            // ???
        }
    }
}
