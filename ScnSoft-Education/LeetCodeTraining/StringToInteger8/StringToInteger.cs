namespace LeetCodeTraining.StringToInteger8
{
    public class Solution
    {
        public int MyAtoi(string inputString)
        {
            int index = 0;
            int sign = 1;
            int result = 0;

            while (index < inputString.Length && inputString[index] == ' ')
            {
                index++;
            }

            if (index < inputString.Length && (inputString[index] == '+' || inputString[index] == '-'))
            {
                sign = inputString[index] == '-' ? -1 : 1;
                index++;
            }

            while (index < inputString.Length && char.IsDigit(inputString[index]))
            {
                int digit = inputString[index] - '0';
                if (result > (Int32.MaxValue - digit) / 10)
                {
                    return sign == 1 ? Int32.MaxValue : Int32.MinValue;
                }
                result = result * 10 + digit;
                index++;
            }

            return sign * result;
        }
    }
}
