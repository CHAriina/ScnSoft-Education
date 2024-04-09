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

            if (string.IsNullOrEmpty(digits))
            {
                return Array.Empty<string>();
            }

            const int maxLetersLength = 4;
            var res = new List<string>(digits.Length * maxLetersLength);

            if (digits.Length == 1)
            {
                if (digitsLettersMap.TryGetValue(digits[0], out var leters))
                {
                    return leters.Select(ch => ch.ToString()).ToList();
                }

                return res;
            }

            for (var i = 0; i < digits.Length - 1; i++)
            {
                var nextIndex = i + 1;
                if (digitsLettersMap.TryGetValue(digits[i], out var leters) && digitsLettersMap.TryGetValue(digits[nextIndex], out var nextLeters))
                {
                    foreach (var ch in leters)
                    {
                        foreach (var ch2 in nextLeters)
                        {
                            string value = new string(new[] { ch, ch2 });
                            res.Add(value);
                        }
                    }
                }
            }

            return res;
        }
    }
}
