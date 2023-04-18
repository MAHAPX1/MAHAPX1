
// Двенадцатое задание C#
/* Реализовать метод ISBN-10.
   3-598-21508-8 true;
   3-598-21508-9 false;
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "0-553-41802-5";

            Console.WriteLine(ISBN(str));
            Console.ReadKey();
        }

        static bool ISBN(string str)
        {
            int checkSum = 0;
            int num = 10;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'X') checkSum += 10;
                if (char.IsNumber(str[i]))
                {
                    checkSum +=(int)str[i] * num;
                    --num;
                }
                
            }

            if (checkSum % 11 == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
    

