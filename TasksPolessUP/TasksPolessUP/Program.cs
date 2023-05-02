
// 19 задание C#
/* 
    Переставьте штрих-коды так, чтобы никакие два соседних штрих-кода не были одинаковыми.
    Ввод: штрих-коды = [1,1,1,2,2,2]
    Вывод: [2,1,2,1,2,1]
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ithbarcodes = new int[] { 1, 2, 1, 1, 2, 2, 2, 2, 1, 2};
            for (int i = 0; i < ithbarcodes.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ithbarcodes[i] = ithbarcodes.Max();
                }
                else
                {
                    ithbarcodes[i] = ithbarcodes.Min();
                }
                               

            }

        }

    }
}
    

