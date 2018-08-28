using System.Collections.Generic;

namespace RomanNumerals
{
    public class Converter
    {
        private readonly Dictionary<char, int> numerals = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int Convert(string input)
        {
            var total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var current = GetValue(i);
                var next = 0;

                if (i < input.Length - 1)
                    next = GetValue(i + 1);

                if (current < next)
                    current = -current;

                total += current;
            }

            return total;

            int GetValue(int position) =>
                numerals[input[position]];
        }
    }
}