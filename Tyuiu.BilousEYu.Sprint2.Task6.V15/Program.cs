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
            Console.WriteLine("* Написать программу, которая использует сокращённую форму switch         *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
            Console.WriteLine("* недели (понедельником, вторником, …, субботой или воскресеньем)         *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января понедельник.  *");
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
