namespace prakt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean x = true;
            do
            {
                Console.WriteLine("Выберите какую операцию вы хотите выполнить:");
                Console.WriteLine("1. Сложить 2 числа");
                Console.WriteLine("2. Вычесть первое из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выйти из программы");
                string input = Console.ReadLine();
                int y = Convert.ToInt32(input);
                if (y == 1)
                {
                    Console.WriteLine("Введите первое число:");
                    string inputs = Console.ReadLine();
                    int a = Convert.ToInt32(inputs);
                    Console.WriteLine("Введите второе число:");
                    string inputss = Console.ReadLine();
                    int b = Convert.ToInt32(inputss);
                    int c = a + b;
                    Console.WriteLine("Результат: " + c);
                }
                else if (y == 2)
                {
                    Console.WriteLine("Введите первое число:");
                    string inputz = Console.ReadLine();
                    int d = Convert.ToInt32(inputz);
                    Console.WriteLine("Введите второе число:");
                    string inputzz = Console.ReadLine();
                    int e = Convert.ToInt32(inputzz);
                    int f = d - e;
                    Console.WriteLine("Результат: " + f);
                }
                else if (y == 3)
                {
                    Console.WriteLine("Введите первое число:");
                    string input1 = Console.ReadLine();
                    int aa = Convert.ToInt32(input1);
                    Console.WriteLine("Введите второе число:");
                    string input2 = Console.ReadLine();
                    int bb = Convert.ToInt32(input2);
                    int cc = aa * bb;
                    Console.WriteLine("Результат: " + cc);
                }
                else if (y == 4)
                {
                    Console.WriteLine("Введите первое число:");
                    string input3 = Console.ReadLine();
                    int dd = Convert.ToInt32(input3);
                    Console.WriteLine("Введите второе число:");
                    string input4 = Console.ReadLine();
                    int ee = Convert.ToInt32(input4);
                    int ff = dd / ee;
                    Console.WriteLine("Результат: " + ff);
                }
                else if (y == 5)
                {
                    Console.WriteLine("Введите первое число:");
                    string input5 = Console.ReadLine();
                    int a1 = Convert.ToInt32(input5);
                    Console.WriteLine("Введите степень в которую хотите возвести первое число:");
                    string input6 = Console.ReadLine();
                    int b1 = Convert.ToInt32(input6);
                    double c1 = Math.Pow(a1, b1);
                    Console.WriteLine("Результат: " + c1);
                }
                else if (y == 6)
                {
                    Console.WriteLine("Введите первое число:");
                    string input11 = Console.ReadLine();
                    int a1 = Convert.ToInt32(input11);
                    double b1 = Math.Sqrt(a1);
                    Console.WriteLine("Результат: " + b1);
                }
                else if (y == 7)
                {
                    Console.WriteLine("Введите первое число:");
                    string input22 = Console.ReadLine();
                    double a2 = Convert.ToInt32(input22);
                    Console.WriteLine("Результат: " + (a2 / 100));
                }
                else if (y == 8)
                {
                    Console.WriteLine("Введите первое число:");
                    string input111 = Console.ReadLine();
                    int a3 = Convert.ToInt32(input111);
                    int b = 1;
                    for (int i = 2; i <= a3; i++)
                    {
                        b = b * i;
                    }
                    Console.WriteLine("Результат: " + b);
                }
                else if (y == 9)
                    x = false;
            }
            while (x);
        }
    }
}