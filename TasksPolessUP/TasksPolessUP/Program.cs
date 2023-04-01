// Пятое задание C#

/* Реализуйте алгоритм, который находит элемент с максимальным значением. Не используйте LINQ. 
Ввод: nums = [2, 3, 1]
Вывод: 1
Объяснение: Поскольку 3 является максимальным числом, то выводим его индекс.
*/
int[] nums = { 10, 8, 70, int.MaxValue, 9, 11};

int max = int.MinValue;
int index = 0;
for (int i = 0; i < nums.Length; i++)
{
        if (nums[i] > max)
        {
           max = nums[i];
           index = i;                          
        }
}

Console.WriteLine(index);


Console.ReadKey();

