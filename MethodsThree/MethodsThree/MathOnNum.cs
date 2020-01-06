using System;
namespace MethodsThree
{
    public class MathOnNum
    {
        int answer;
        decimal answer2;
        public MathOnNum()
        {
        }

        public int Math(int userNum)
        {
            answer = userNum + 15;
            return answer;
        }

        public decimal Math(decimal userNum)
        {
            answer2 = userNum / 25;
            return answer2;
        }

        public int Math(string userNum)
        {
            answer = Convert.ToInt32(userNum);
            return answer * 2;
        }
    }
}
