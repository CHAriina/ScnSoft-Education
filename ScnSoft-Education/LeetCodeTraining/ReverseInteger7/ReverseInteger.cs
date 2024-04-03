namespace LeetCodeTraining.ReverseInteger7;
public class Solution
{
    public int Reverse(int inputNumber)
    {
        int reversed = 0;

        while (inputNumber != 0)
        {
            inputNumber /= 10;
            int digit = inputNumber % 10;
            reversed = reversed * 10 + digit;
            if (reversed > Int32.MaxValue / 10 || reversed < Int32.MinValue / 10)
            {
                return 0;
            }
        }

        return reversed;
    }
}