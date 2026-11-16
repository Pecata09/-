using System.Diagnostics;

namespace domashna16._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chisla s interval:");
            string[] input = Console.ReadLine().Split(' ');

            int n = input.Length;
            double[] numbers = new double[n];
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(input[i]);
                sum += numbers[i];
            }

            double average = sum / n;

            Array.Sort(numbers);

            double median;
            if (n % 2 == 0)
            {
                median = (numbers[n / 2 - 1] + numbers[n / 2]) / 2;
            }
            else
            {
                median = numbers[n / 2];
            }

            int maxCount = 0;
            List<double> modes = new List<double>();

            for (int i = n - 1; i >= 0; i--)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    modes.Clear(); 
                    modes.Add(numbers[i]);
                }
                else if (count == maxCount && !modes.Contains(numbers[i]))
                {
                    modes.Add(numbers[i]);
                }
            }

            Console.WriteLine("1) Sredno aritmetichno: " + average);
            Console.WriteLine("2) Mediana: " + median);

            if (maxCount <= 1)
            {
                Console.WriteLine("3) Moda: nqma moda");
            }
            else
            {
                Console.WriteLine("3) Moda: " + string.Join(", ", modes));
            }

        }
    }
}
