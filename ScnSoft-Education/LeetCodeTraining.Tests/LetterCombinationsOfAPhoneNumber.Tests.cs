using LeetCodeTraining.LetterCombinationsOfAPhoneNumber15;

namespace LeetCodeTraining.Tests.LetterCombinationsOfAPhoneNumber
{
    public class SolutionTests
    {
        private readonly Solution resultSolution;
            
        public SolutionTests()
        {
            resultSolution = new Solution();
        }

        [Theory]
        [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("231", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("79", new string[] { "pw", "px", "py", "pz", "qw", "qx", "qy", "qz", "rw", "rx", "ry", "rz", "sw", "sx", "sy", "sz" })]
        public void LetterCombinations_ShouldReturnCorrectResult(string digits, string[] expected)
        {
            var result = resultSolution.LetterCombinations(digits);
            Assert.Equal(expected, result);
        }
    }
}
