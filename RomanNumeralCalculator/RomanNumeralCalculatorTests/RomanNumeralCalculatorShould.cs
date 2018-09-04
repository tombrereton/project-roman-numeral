using NUnit.Framework;
using RomanNumeralProject;

namespace RomanNumeralCalculatorTests
{
    //1 -> "I" | 10 -> "X" | 100 -> "C" | 1000 -> "M"
    //2 -> "II" | 20 -> "XX" | 200 -> "CC" | 2000 -> "MM"
    //3 -> "III" | 30 -> "XXX" | 300 -> "CCC" | 3000 -> "MMM"
    //4 -> "IV" | 40 -> "XL" | 400 -> "CD" | 4000 -> "MMMM"
    //5 -> "V" | 50 -> "L" | 500 -> "D" |
    //6 -> "VI" | 60 -> "LX" | 600 -> "DC" |
    //7 -> "VII" | 70 -> "LXX" | 700 -> "DCC" |
    //8 -> "VIII" | 80 -> "LXXX" | 800 -> "DCCC" |
    //9 -> "IX" | 90 -> "XC" | 900 -> "CM" |

    //1990 -> "MCMXC" (1000 -> "M" + 900 -> "CM" + 90 -> "XC")
    //2008 -> "MMVIII" (2000 -> "MM" + 8 -> "VIII")
    //99 -> "XCIX" (90 -> "XC" + 9 -> "IX")
    //47 -> "XLVII" (40 -> "XL" + 7 -> "VII")
    [TestFixture]
    public class RomanNumeralCalculatorShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(39, "XXXIX")]
        [TestCase(41, "XLI")]
        [TestCase(50, "L")]
        [TestCase(1990, "MCMXC")]
        public void ConvertArabicNumberIntoRomanNumeral(int number, string expectedRomanNumeral)
        {
            var actualRomanNumeral = RomanNumeralCalculator.Convert(number);

            Assert.That(actualRomanNumeral, Is.EqualTo(expectedRomanNumeral));
        }
    }
}