namespace TestConsole2
{
    partial class Program
    {
        public class Calculator
        {
            public int Add (params int[] numbers)
            {
                int sum=0;
                foreach (int num in numbers)
                {
                    sum += num;

                }
                return sum;
            }
        }
    }
}
