
// Третье задание C#

// Ввод: числа = [1,3,5,6], цель = 5
// Вывод: 2

int[] nums = { 1, 3, 4, 7, 10, 20 };
int target = 10;

if (target >= nums[^1]) Console.WriteLine(nums.Length);
else 
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] >= target && target <= nums[i] )
        {
            Console.WriteLine(i);
            break;
        }
    }

Console.ReadKey();
