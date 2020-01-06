using System;
namespace Methods
{
    public class MathForNum
    {
        public MathForNum()
        {
        }

        public decimal userNum { get; }
        public decimal answer;
        
        
        public decimal MathOne(decimal userNum)
        {
            answer = userNum * 10/100;
            return answer;
        }

        public decimal MathTwo(decimal userNum)
        {
            answer = userNum * 15 / 100;
            return answer;
        }

        public decimal MathThree(decimal userNum)
        {
            answer = userNum * 20 / 100;
            return answer;
        }
    }
}
