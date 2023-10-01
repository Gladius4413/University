internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Бочков Михаил Алексеевич ПРИ-120");

        int resault = 777;

        if (resault == 777)
        {

            Console.WriteLine("Congratulations, you win!!!!"); // выведет: «Поздравляем, вы победили»
        }
        else
        {
            Console.WriteLine("please, try again \n"); // выведет: «Пожалуйста, попробуйте снова»
            Console.WriteLine("we are confident - you will be lucky"); //выведет: «Мы уверены- вам повезет»
        }

        int value = 2;

        switch (value)
        {
            case 1:
                Console.WriteLine("Цифра 1");
                break;

            case 2:
                Console.WriteLine("Цифра 2");
                break;

            case 3:
                Console.WriteLine("Цифра 3");
                break;
            default:
                Console.WriteLine("для этого варианта действие не определено");
                break;
        }


        int a = 8;
        while (a > 5)
        {
            Console.WriteLine(a);
            a--;
        }
        Console.WriteLine();
        int b = 8;
        do
        {
            Console.WriteLine(a);
            b--;
        } while (b > 5);
        Console.WriteLine();

        for (int i = 8; i > 5; i--)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();
        int[] arr = new int[] { 1, 2, 3 }; // наш массив 
        foreach (int x in arr)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();

        int[] arr_name = new int[2];
        arr_name[0] = 1;
        arr_name[1] = 2;

        //int[] arr_name = new int[] { 1, 2 };
        // int[] arr_name = { 1, 2 };


       // int[,] arr_name_1 = new int[4, 2];
          int[,] arr_name_2 = { { 0, 1, 2, 3 }, { 0, 1,3,4 } };
        for (int i = 0; i < arr_name_2.GetLength(0); i++)
        {
            for (int j = 0; j < arr_name_2.GetLength(1); j++)
            {
                Console.WriteLine(arr_name_2[i, j]);
            }
        }
    }
}
