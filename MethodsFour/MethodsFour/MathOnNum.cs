using System;


namespace MethodsFour
{
    public class MathOnNum
    {
        decimal answer;

        public MathOnNum()
        {
        }

        public decimal Math(int userInput, int userInput2 = 1)
        {
            answer = userInput * userInput2;
            return answer;
        }
    }
}
