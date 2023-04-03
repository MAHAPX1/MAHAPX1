// Девять задание C#

/* Реализуйте метод
Ввод: 2000
Вывод: true
Ввод: 2015
Вывод: false
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2015;
            Console.WriteLine(Visokos(year));

            Console.ReadKey();
        }

        static bool Visokos(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

