using Tyuiu.BilousEYu.Sprint2.Task0.V26.Lib;
namespace Tyuiu.BilousEYu.Sprint2.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1045;
            int y = 975;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнила: Билоус Е.Ю. | ИСТНб - 24-1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                     *");
            Console.WriteLine("* Тема: Операции сравнения                                                      *");
            Console.WriteLine("* Задание #0                                                                    *");
            Console.WriteLine("* Вариант #26                                                                   *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб - 24-1                            *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,               *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических выражений, *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (False, False, False,   *");
            Console.WriteLine("* True, True, True)                                                             *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine(" X = " + x);
            Console.WriteLine(" Y = " + y);

            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("*********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}
