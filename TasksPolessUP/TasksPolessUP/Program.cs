// Второе задание C#

// Ввод: nums = [2, 7, 11, 15], target = 9
// Вывод: [0,1]
// Объяснение: Поскольку nums[0] +nums[1] == 9, мы возвращаем[0, 1].

int[] nums = { 15, 7, 11, 2, 15, 2 };
int target = 30;
string str = "Няма такого";

for (int i = 0; i < nums.Length; i++)
{
    for (int j = 1 + i; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == target)
        {
            str = i + " И " + j;
            break;
        }
    }
}

Console.WriteLine(str);
Console.ReadKey();
