using System;
using System.Linq;
namespace DecoderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Decoder.SkipCode("Save souls Now! John or James Watson!"));
            //Console.WriteLine(Decoder.SkipCode("Saint or Sinner? James or John? The more is less?"));
            Console.WriteLine(Decoder.FirstLetter("wait oranges really killed eggs dad"));
            
        }
    }

    class Decoder
    {
        /// <summary>
        /// Roman numeral decoder
        /// </summary>
        /// <param name="roman"></param>
        /// <returns>number</returns>
        public static int Solution(string roman)
        {
            return roman
                .Replace("CM", "DCCCC")
                .Replace("CD", "CCCC")
                .Replace("XC", "LXXXX")
                .Replace("XL", "XXXX")
                .Replace("IX", "VIIII")
                .Replace("IV", "IIII")
                .Sum(c => Translate(c));
        }

        public static int Translate(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }

        /// <summary>
        /// Skip Code Decoder, every 2 words is the real word
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns>string</returns>
        public static string SkipCode(string sentence)
        {
            string[] strArr = sentence.Split();

            string result = "";
            //result += strArr[0];

            for (int i = 0; i < strArr.Length; i++)
            {
                if(i % 3 == 0)
                {
                    result += strArr[i] + " ";
                }
            }

            return result;
        }
        /// <summary>
        /// Takes the first letter of a word in a sentence to reveal hidden message
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns>a word or sentence</returns>
        public static string FirstLetter(string sentence)
        {
            string[] strArr = sentence.Split();

            string result = "";

            for (int i = 0; i < strArr.Length; i++)
            {
                result += strArr[i].First<char>();
            }

            return result;
        }
    }


    class Encoder
    {
        /// <summary>
        /// Pig latin encoder
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string PigIt(string str)
        {
            var words = str.Split(' ');
            string rev = "";
            foreach (var w in words)
            {
                var frstLetter = w[0];
                var otherLetter = w.Substring(1);
                string newWord;
                if (w.Length == 1)
                    newWord = w + "ay ";
                else
                {
                    newWord = otherLetter + frstLetter + "ay" + " ";
                }

                rev += newWord;
            }
            rev = rev.TrimEnd();

            return rev;
        }
    }
}
