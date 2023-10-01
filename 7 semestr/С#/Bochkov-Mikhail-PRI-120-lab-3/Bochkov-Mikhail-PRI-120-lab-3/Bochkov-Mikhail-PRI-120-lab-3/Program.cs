internal class Program
{
    private static void Main(string[] args)
    {
        Thread th_1 = new Thread(Func);
        Thread th_2 = new Thread(Func);
        Thread th_3 = new Thread(Func);
        Thread th_4 = new Thread(Func);

        //  расставляем приоритеты для потоков

        th_1.Priority = ThreadPriority.Highest; // самый высокий
        th_2.Priority = ThreadPriority.BelowNormal; // выше среднего
        th_3.Priority = ThreadPriority.Normal; // средний
        th_4.Priority = ThreadPriority.Lowest; // низкий

        //  запускаем каждый поток, в качестве параметра передаем номер потока

        th_1.Start();
        th_2.Start();
        th_3.Start();
        th_4.Start();

        Console.WriteLine("все потоки запущены\n\n");
        // Ждем заврешения каждого потока
        th_1.Join();
        th_2.Join();
        th_3.Join();
        th_4.Join();

        Console.ReadLine();

        void Func()
        {
            double a = -3;
            double b = 3;
            double n = 20;
            double x = 0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Итерация номер {i} - ");
                x = a + i * h;
                double y = 3 * (x + 3) / (Math.Pow(x, 2) + 1) - Math.Log10(x * Math.Tan(x)) - Math.Exp(7 * Math.Sqrt(x)) + 0.3 * (Math.Pow(x, 3) + Math.Pow(x, 2) - 1);
                Console.WriteLine(y);

            }
        }

    }

}

