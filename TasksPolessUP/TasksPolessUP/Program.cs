// Одиннадцатое задание C#

/* Реализовать метод, который сортирует массив по возрастанию элементов.

*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,5,2,5,3,1,-10};
            Sort(arr);

            Console.ReadKey();
        }

        static int[] Sort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
    

