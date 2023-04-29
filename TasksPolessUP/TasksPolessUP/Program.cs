
// 17 задание C#
/* 
    Ввод: s = "a1b2"
    Вывод: ["a1b2", "a1B2", "A1b2", "A1B2"]
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a1b23d";
            //string s = "abCd";
            //string s = "ABC";
          
            string news;
            s = s.ToLower();
            List<string> list = new List<string>() { s };
            
            for (int i = 0; i < s.Length;)
            {
                news = s;
                for (int j = i + 1; j < s.Length;j++)
                {
                    list.Add(news[..j]);
                    list[^1] += char.ToUpper(news[j]) + news[++j..];

                    --j;
                }
                s = s[..i] + char.ToUpper(s[i]) + s[++i..];
                list.Add(s);
            }
            foreach (var item in list.Distinct())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}
    

