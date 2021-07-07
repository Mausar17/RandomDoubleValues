using System;

namespace RandomDoubleValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double[] randomDoubles = new double[20];

            for (int i = 0; i < randomDoubles.Length; i++)
            {
                randomDoubles[i] = random.NextDouble();
            }

            foreach (var value in randomDoubles)
            {
                Console.WriteLine(value);
            }
        }
    }
}
