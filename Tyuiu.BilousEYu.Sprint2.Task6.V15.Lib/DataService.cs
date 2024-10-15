using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BilousEYu.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            switch (k)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                
                default: throw new ArgumentException($"День должен быть от 1 до 365. {k}");
            }
        }
    }
}
