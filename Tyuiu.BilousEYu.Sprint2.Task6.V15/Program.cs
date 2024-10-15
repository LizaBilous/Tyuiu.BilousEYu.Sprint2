using Tyuiu.BilousEYu.Sprint2.Task6.V15.Lib;
namespace Tyuiu.BilousEYu.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2  |  Выполнила: Билоус Е.Ю.  |  ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch.                                   *");
            Console.WriteLine("* Задание: #6                                                             *");
            Console.WriteLine("* Вариант: #15                                                            *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение и возвращает   *");
            Console.WriteLine("* результат.                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите номер дня: ");
            int numDay = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numDay < 1) || (numDay > 365))
            {
                res = " Введено неверное значение! ";
            }
            else
            {
                res = "  Этот день: " + ds.FindDayName(numDay);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
