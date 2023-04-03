// Шестое задание C#

/* Реализуйте метод
Ввод: 2.345
Вывод: Two point three four five
Ввод: -23.809
Вывод: Minus two three point eight zero nine
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            double real = 220.345;
            Word(real);
            Console.ReadKey();
        }


        static string[] Word(double number)
        {

            string words = number.ToString();
            string[] result = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                switch (words[i])
                {
                    case '1':
                        result[i] = " One";
                        break;
                    case '2':
                        result[i] = " Two";
                        break;
                    case '3':
                        result[i] = " Three";
                        break;
                    case '4':
                        result[i] = " Four";
                        break;
                    case '5':
                        result[i] = " Five";
                        break;
                    case '6':
                        result[i] = " Six";
                        break;
                    case '7':
                        result[i] = " Seven";
                        break;
                    case '8':
                        result[i] = " Eight";
                        break;
                    case '9':
                        result[i] = " Nine";
                        break;
                    case '0':
                        result[i] = " Zero";
                        break;
                    default:
                        result[i] = " Point";
                        break;
                }
                
            }
            return result;
        }
}}
    

