
// 15 задание C#
/* 
   Красота строки заключается в разнице частот между наиболее часто встречающимися и наименее часто встречающимися символами
   Например, "abaacc" красота 3 - 1 = 2.
   Ввод: s = "aabcb"
   Выход: 1
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aabcb";           
            Console.WriteLine(BeautyLine(str));
            
            Console.ReadKey();
        }
        static int BeautyLine(string str)
        {
            int count;
            int max = int.MinValue;
            int min = int.MaxValue;
            char temp;
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i];
                count = 0;
                foreach (char ch in str)
                {
                    if (ch == temp)
                    {
                        count++;
                    }
                }
                if(count > max) max = count;
                if(count < min) min = count;
            }
            return max - min;
        }


    }
}
    

