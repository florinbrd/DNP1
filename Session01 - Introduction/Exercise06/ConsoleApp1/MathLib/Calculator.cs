namespace MathLib
{
    public class Calculator
    {
        public int add(int a, int b)
        {
            return (a + b);
        }

        public int add(int[] a)
        {
            int sum = 0;
            foreach (var b in a)
            {
                sum += b;
            }

            return sum;
        }
    }
}