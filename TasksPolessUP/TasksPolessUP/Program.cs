// Четвертое задание C#

// Ввод: nums = [2,3,1]
// Вывод: 1
// Объяснение:
// Первый отчетливый максимум равен 3.
// Второй отчетливый максимум равен 2.
// Третий отчетливый максимум равен 1.

int[] nums = { 100, int.MaxValue, 80, 25, 8, int.MinValue, 30, 41, 40, 20};

int count = 3; // количество максимумов. В условии 3, но если поставить 6, то выведет шестой максимум

    for (int j = 1; j <= count; j++)
    {
        int max = int.MinValue;
        for (int i = 0; i <= nums.Length - j ; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                nums[i] = nums[nums.Length - j ];
                nums[nums.Length - j ] = max;
                --i;
            }
        }
        Console.WriteLine(max);
    }

Console.ReadKey();

