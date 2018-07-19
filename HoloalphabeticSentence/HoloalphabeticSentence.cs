using System;
using System.Collections.Generic;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            if (input.Length == 0) return false;
            int previous = alphabets[0];
            int end = alphabets[alphabets.Length-1];
            char[] CharacterArray = input.ToLower().ToCharArray();
            List<char> SortedList = CharacterArray.OrderBy(x => x).ToList();
            foreach (char a in SortedList)
            {
                int AsciiValue = a;
                if (AsciiValue < previous) continue;
                if (AsciiValue > end) break;
                if (AsciiValue != previous && AsciiValue != previous + 1)
                {
                    return false;
                }
                previous = AsciiValue;
            }
            return true;
        }
    }
}
