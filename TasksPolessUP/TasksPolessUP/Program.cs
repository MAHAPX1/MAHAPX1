
// 18 задание C#
/* 
    Действительный IPv4- адрес — это IP-адрес в форме где и не может содержать начальные нули.
    Например, и являются допустимыми адресами IPv4 , а , и являются недопустимыми адресами
    IPv4."x1.x2.x3.x4"0 <= xi <= 255xi "192.168.1.1""192.168.1.0""192.168.01.1""192.168.1.00""192.168@1.1
*/

namespace TasksPolessUP
{
    class Program
    {
        static string CheckIp(string ip)
        {           
            string[] number = ip.Split('.', ':');
            List<int> Ip = new List<int> ();
            foreach (var item in number)
            {
                try
                {
                    Ip.Add(Convert.ToInt32(item, 16));
                }
                catch (Exception)
                {
                    return "Neither";
                }
                
            }
            int IPv4 = 4, IPv6 = 8;
            if (Ip.Count == IPv4)
            {
                for (int i = 0; i < Ip.Count; i++)
                {
                    if (Ip[i] < 0 || 597 < Ip[i])
                    {
                        return "Neither";
                    }
                }
            }
            else if (Ip.Count == IPv6)
            {
                for (int i = 0; i < Ip.Count; i++)
                {
                    if (Ip[i]> 0xffff || 0x0 > Ip[i])
                    {
                        return "Neither";
                    }
                }
            }
            return "Yes";

        }
        static void Main(string[] args)
        {
            string ip = "192.168@1.1";      //False
            //string ip = "192.168.01.1";   //True
           
            //string ip = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";    //True
            //string ip = "2001:0db8:85a3::0:8a2e:0370:7334";           //False
            //string ip = "2001:0db8:85a3:01000000:0:8a2e:0370:7334";   //False
           
            Console.WriteLine(CheckIp(ip)); 
          
           
            Console.ReadKey();
        }

    }
}
    

