// Восьмое задание C#

/* Реализуйте метод
Ввод:(255,255,255)
Вывод: "FFFFFF"
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            string rgb = "10,78,2595"; // Несколько тестовых вариантов ввода строки
           // string rgb = "10,678,-9";
           // string rgb = "10 678,90";
            // string rgb = "10,90 ";
            Console.WriteLine(RGB(rgb));
            Console.ReadKey();
        }

        static string RGB(string rgb)
        {
            rgb += ",";
            string res = string.Empty;
            string strnumber = string.Empty;
            int number;

            for (int i = 0; i < rgb.Length; i++)
            {
                if (char.IsDigit(rgb[i]))
                {
                    strnumber += rgb[i];
                }
                else if (rgb[i] == ',')
                {            
                    try
                    {
                        number = Convert.ToInt32(strnumber);
                        res += number > 255 ? "ff," : Convert.ToString(number, 16) + ',';
                    }
                    catch
                    {
                        return "Исходная строка ведена неверно";
                    }
                    strnumber = string.Empty;                   
                }
                else return "Исходная строка ведена неверно";

            }

            return res[..^1];
        }
    }
}
    

