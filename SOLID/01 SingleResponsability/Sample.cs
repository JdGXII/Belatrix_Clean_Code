using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        private string CreateResultMessage(int operationResult)
        {
            if (operationResult > 0 && operationResult <= 10)
                return string.Format("The sum is: {0} and is in range {1}", operationResult, "Value between 0 and 10");
            else if (operationResult > 10 && operationResult <= 20)
                return string.Format("The sum is: {0} and is in range {1}", operationResult, "Value between 11 and 20");  
            else if (operationResult > 20 && operationResult <= 30)
                return string.Format("The sum is: {0} and is in range {1}", operationResult, "Value between 21 and 30");

            return "Value out of range";            
        }

        public void PrintResultMessage(string resultMessage)
        {
            Console.WriteLine(resultMessage);
        }
    }
}
