
// Триннадцатое задание C#
/* 
   Если номер версии не указывает ревизию в индексе, то обрабатывайте ревизию как 0.
   Например, версия  1.0меньше, чем версия, 1.1 потому что их ревизии 0 одинаковы,
   но их ревизии 1 равны  0 и  1 соответственно, и 0 < 1.
*/

namespace TasksPolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            string version1 = "001.5";
            string version2 = "1.5.1";
            Console.WriteLine(ComparisonVersions(version1, version2));
            
            Console.ReadKey();
        }
        static int ComparisonVersions(string v1, string v2)
        {
            v1 = v1.Trim('0');
            v2 = v2.Trim('0');
            if (String.Compare(v2, v1) == 0) return 0; // Версии одинаковы
            if(v1.IndexOf('.') <= -1 || v2.IndexOf('.') <= -1) return 0; // Версии не имеют точек
            int i = -1;
            do
            {
                i++;
                try
                {
                    if ((int)v1[i] > (int)v2[i])
                    {
                        return 1;
                    }
                }
                catch (Exception)
                {
                    if (v1.Length > v2.Length)
                    {
                        return 1;
                    }
                    else return -1;                  
                }
                 
            }
            while (v1[i]== v2[i]);
            
            return -1;
        }


    }
}
    

