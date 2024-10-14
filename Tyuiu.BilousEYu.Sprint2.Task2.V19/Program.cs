using Tyuiu.BilousEYu.Sprint2.Task2.V19.Lib;
namespace Tyuiu.BilousEYu.Sprint2.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #2 | Выполнила:  Билоус Е.Ю.| ИСТНб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #2                                                               *");
            Console.WriteLine("* Тема : Оператор if – полная и короткая форма записи                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("*и вычисляет находится ли точка с координатами X,Y                        *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();

        }
    }
}
