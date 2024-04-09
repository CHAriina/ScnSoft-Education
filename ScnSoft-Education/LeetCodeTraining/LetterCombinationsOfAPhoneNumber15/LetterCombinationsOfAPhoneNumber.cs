namespace LeetCodeTraining.LetterCombinationsOfAPhoneNumber15
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var digitsLettersMap = new Dictionary<char, string>()
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };

            var res = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return res;
            }

            res.Add(string.Empty);
            for (var i = 0; i < digits.Length; i++)
            {
                if (digitsLettersMap.ContainsKey(digits[i]))
                {
                    res = res
                        .SelectMany(x => digitsLettersMap[digits[i]].Select(y => x + y))
                        .ToList();
                }
            }
            return res;

        }
    }
}
