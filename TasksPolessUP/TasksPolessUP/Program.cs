
// 16 задание C#
/* 
   Учитывая целое число n, верните true,
   если можно представить n как сумму различных степеней трех. 
   В противном случае возвращайте false.
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
            if (n % 3 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            
            Console.ReadKey();
        }

    }
}
    

