using Tyuiu.BilousEYu.Sprint2.Task5.V3.Lib;
namespace Tyuiu.BilousEYu.Sprint2.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнила: Билоус Е.Ю. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #2                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнила: Билоус Елизавета Юрьевна | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите номер дня :");
            int numDay = Convert.ToInt32(Console.ReadLine());
            string res;

            if ((numDay < 1) || (numDay > 7))
            {
                res = "Введенно неверное значение";
            }
            else
            {
                res = "Это день " + ds.FindDayName(numDay);
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
