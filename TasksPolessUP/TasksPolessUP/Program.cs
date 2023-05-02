
// 20 задание C#
/* 
    Учитывая целое число n, вернуть количество простых чисел, которые строго меньше, чем n.
    Вход: n = 10
    Выход: 4
*/

namespace TasksPolessUP
{
    class Program
    {
        static int SimpleCount(int n)
        {
            int count = n >= 2 ? 1: 0;
            bool flag;
            for (int i = n; i > 2; i--)
            {
                flag = false;
                for (int j = 2; j < i; j++)
                {
                 if (i % j == 0) break;
                 if (j + 1 == i) flag = true;
                } 
                if (flag) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
           int n = 10;
           Console.WriteLine("Количество простых чисел " + SimpleCount(n));
           Console.ReadKey();
        }

    }
}
    

