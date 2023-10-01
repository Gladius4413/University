internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Бочков Михаил Алексеевич ПРИ-120");
        // переменная, которая будет хранить команду пользователя
        string user_command = "";
        // бесконечный цикл
        bool Infinity = true;
        Man SomeMan = null;

        while (Infinity) // пока Infinity равно true
        {
            // приглашение ввести команду
            Console.WriteLine("Пожалуйста, введите команду");

            // получение строки (команды) от пользователя
            user_command = Console.ReadLine();

            switch (user_command)
            {

                // если user_command содержит строку exit
                case "exit":
                    Infinity = false;
                    // теперь цикл завершиться, и программа завершит свое выполнение
                    break;

                // если user_command содержит строку help
                case "help":


                    Console.WriteLine("Список команд:");
                    Console.WriteLine("---");

                    Console.WriteLine("create_man : команда создает человечка, (экземпляр класса Man)");
                    Console.WriteLine("kill_man : команда убивает человечка");
                    Console.WriteLine("talk : команда заставляет человечка говорить (если создан экземпляр класса)");
                    Console.WriteLine("go : команда заставляет человечка идти (если создан экземпляр класса)");
                    Console.WriteLine("info : команда показывает инмормацию о человеке (если создан экземпляр класса)");
                    Console.WriteLine("resurrect : команда воскрешает человека, если он мертв (если создан экземпляр класса)");
                    Console.WriteLine("---");
                    Console.WriteLine("---");

                    break;

                case "create_man":
                    {
                        // проверяем, создан ли уже какой либо человечек
                        if (SomeMan != null)
                        {
                            // человечек уже существует - "убиваем" его
                            SomeMan.Kill();
                        }
                        // просим ввести имя человечка
                        Console.WriteLine("Пожалуйста, введите имя создаваемого человечка \n");

                        // получаем строку введенную пользователем
                        user_command = Console.ReadLine();

                        // создаем новый объект в памяти, в качестве параметра
                        // передаем имя человечка
                        SomeMan = new Man(user_command);

                        // сообщаем о создании
                        Console.WriteLine("Человечек успешно создан \n");
                        SomeMan.ShowInfo();
                        Console.WriteLine();

                        break;

                    }
                case "kill_man":
                    {
                        // проверяем, что объект существует в памяти
                        if (SomeMan != null)
                        {
                            // вызываем фукнцию "смерти"
                            SomeMan.Kill();
                            Console.WriteLine();
                        }

                        break;
                    }
                case "talk":
                    {
                        // проверяем, что объект существует в памяти
                        if (SomeMan != null)
                        {
                            // вызываем фукнцию разговора
                            string resultTalking = SomeMan.Talk();
                            Console.WriteLine($"{resultTalking}");
                            Console.WriteLine();
                        }
                        else // иначе
                        {
                            Console.WriteLine("Человечек не создан. Команда не может быть выполнена");
                        }
                        break;

                    }
                case "go":
                    {

                        // проверяем, что объект существует в памяти
                        if (SomeMan != null)
                        {
                            // вызываем фукнцию передвижения
                            SomeMan.Go();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Человечек не создан. Команда не может быть выполнена");
                        }
                        break;

                    }
                case "info":

                    if (SomeMan != null)
                    {
                        SomeMan.ShowInfo();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Человечек не создан. Команда не может быть выполнена");

                    }
                    break;

                case "resurrect":

                    if (SomeMan != null)
                    {
                        SomeMan.Resurrect();
                    }
                    else
                    {
                        Console.WriteLine("Человечек не создан. Команда не может быть выполнена");
                    }
                    break;
                // если команду определить не удалось
                default:

                    System.Console.WriteLine("Ваша команда не определена, пожалуйста повторите снова");
                    System.Console.WriteLine("Для вывода списка команд введите команду help");
                    System.Console.WriteLine("Для завершения программы введите команду exit");
                    break;
            }
        }
    }
}
public class Man
{
    private Random rnd = new Random();
    // конструктор класса (данная функция вызывается
    // при создании нового экземпляра класса
    public Man(string name)
    {
        Name = name;
        isLife = true;
        Age = (uint)rnd.Next(15, 50);
        // и здоровье, от 10 до 100%
        Health = (uint)rnd.Next(10, 100);
    }
    // закрытые члены, которые нельзя именить
    // извне класса

    // строка, содержащая имя
    private string Name;

    // беззнаковое целое число, содержащая возраст
    private uint Age;

    // беззнаковое целое число, отражающее уровень здоровья
    private uint Health;

    // булево, означающее жив ли данный человечек
    private bool isLife;

    // заготовка функции "говорить"
    public string Talk()
    {
        // генерируем случайное число от 1 до 3
        int random_talk = rnd.Next(1, 3);

        // объявляем переменную, в которой мы будем хранить строку
        string tmp_str = "";
        switch (random_talk)
        {

            case 1: // если 1 - называем свое имя
                tmp_str = "Привет, меня зовут " + Name + ", рад познакомиться";
                break;

            case 2: // возраст
                // генериуем текст сообщения
                tmp_str = "Мне " + Age + ". А тебе?";
                // завершаем оператор выбора
                break;

            case 3: // говорим о своем здоровье

                // в зависимости от параметра здоровья
                if (Health > 50)
                    tmp_str = "Да я зводоров как бык!";
                else
                    tmp_str = "Со здоровьем у меня неважно, дожить бы до " + (Age + 10).ToString();


                // завершаем оператор выбора
                break;
        }
        return tmp_str;
    }

    // заготовка функции "идти"
    public void Go()
    {
        // если объект жив
        if (isLife == true)
        {
            // если показатель более 40
            // считаем объект здоровым
            if (Health > 40)
            {
                // генерируем строку текста
                string outString = Name + " мирно прогуливается по городу";
                // выводим в консоль
                Console.WriteLine(outString);
            }
            else
            {
                // генерируем строку текста
                string outString = Name + " болен и не может гулять по городу";
                // выводим в консоль
                Console.WriteLine(outString);
            }
        }
        else
        {
            // генерируем строку текста
            string outString = Name + " не может идти, он умер";
            System.Console.WriteLine(outString);
        }
    }

    // функция, возвращающая показатель - жив ли данный человечек.
    public bool IsAlive()
    {
        // возращаем значение, к которому мы не можем
        // обратиться на прямую из вне класса,
        // так как оно имеет статус private
        return isLife;
    }
    public void Kill()
    {
        // устанавливаем значение isLife (жив)
        // в false...
        isLife = false;
        Console.WriteLine("Человек убит");
    }

    public void ShowInfo()
    {

        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Здоровье: {Health}");
        if (isLife == true) Console.WriteLine("Человек жив");
        else Console.WriteLine("Человек мертв");
    }

    public void Resurrect()
    {
        if (isLife == false)
        {
            isLife = true;
            Console.WriteLine("Человек воскрешён");

        }
        else { Console.WriteLine("Человек и так жив"); }
    }
}