// Десятое задание C#

/* Реализуйте метод, который вычисляет сумму первых n элементов последовательности
Пример:
1     2        3          4            5
a + (a+r) + (a+r+r) + (a+r+r+r) + (a+r+r+r+r) 
2 + (2+3) + (2+3+3) + (2+3+3+3) + (2+3+3+3+3) = 40
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
          
            int r = 3;
            int n = 5;
            Console.WriteLine(Sumn(ref a, ref r, n));

            Console.ReadKey();
        }

        static int Sumn(ref int a, ref int r, int n)
        {

            int sum = n <= 0 ? 0: a;
            for (int i = 1; i < n; i++)
            {
                sum += a + i * r;
            }
            return sum;
        }
    }
}
    

