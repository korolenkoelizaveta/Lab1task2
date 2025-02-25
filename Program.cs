/*
Задача №10. Даны n пар положительных чисел: (a1,b1),(a2,b2),...,(an,bn).
Определить в какой паре среднее арифметическое значений чисел является максимальным.
Если пар с максимальным значением среднего арифметического несколько, найти номер последней из них;
 */
namespace Lab1task2;
public class Second
{
    static void Main()
    {
        // НАЧАЛО взаимодействия с пользователем
        Console.Write("Введите количество пар: ");
        int x = Convert.ToInt32(Console.ReadLine());
        double[] a = new double[x], b = new double[x];

        for (int i = 0; i < x; i++)
        {
            Console.WriteLine($"Введите значения для пары {i + 1} через пробел:");
            string[] input = Console.ReadLine().Split();
            a[i] = double.Parse(input[0]);
            b[i] = double.Parse(input[1]);

        }
        // КОНЕЦ взаимодействия с пользователем

        // НАЧАЛО логики
        double[] res = Average(a, b);
        //КОНЕЦ логики

        // НАЧАЛО взаимодействия с пользователем
        Console.WriteLine($"Последняя пара с максимальным средним арифметическим ({res[0]}) — пара номер {res[1] + 1}.");
        // КОНЕЦ взаимодействия с пользователем
    }

    public static double[] Average(double[] a, double[] b)
    {

        double[] res = { double.MinValue, 0};


        for (int i = 0; i < a.Length; i++)
        {
            double sr = (a[i] + b[i]) / 2;

            if (sr > res[0])
            {
                res[0] = sr;
                res[1] = i;
            }
            else if (sr == res[0])
            {
                res[1] = i;
            }
        }
        return res;

    }
}
