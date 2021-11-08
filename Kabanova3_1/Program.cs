using System;

namespace Kabanova3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1 Вариант 6, средний уровень
            try
            {
                Console.WriteLine("Введите число k:");
                int k = int.Parse(Console.ReadLine());
                double S = 0;
                for (int i = -2; i <= k; i++)
                {
                    if (i == 4) continue;
                    long F = 1;
                    for (int j = 1; j <= i + 3; j++) F *= j;
                    S += Math.Pow(-1, i) * F / (i - 4);
                }
                Console.WriteLine($"W={S:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
