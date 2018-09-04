using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralProject
{
    public class RomanNumeralCalculator
    {
        public static string Convert(int arabicNumber)
        {
            var romanNumerals = new Dictionary<int, string>
            {
                {1, "I"},
                {4, "IV"},
                {5, "V"},
                {9, "IX"},
                {10, "X"},
                {40, "XL"},
                {50, "L"},
                {90, "XC"},
                {100, "C"},
                {400, "CD"},
                {500, "D"},
                {900, "CM"},
                {1000, "M"},
            };

            if (arabicNumber == 0)
            {
                return string.Empty;
            }

            foreach (var romanNumeral in romanNumerals.Reverse())
            {
                if (arabicNumber >= romanNumeral.Key)
                {
                    return romanNumeral.Value + Convert(arabicNumber - romanNumeral.Key);
                }
            }

            return string.Empty;
        }
    }
}