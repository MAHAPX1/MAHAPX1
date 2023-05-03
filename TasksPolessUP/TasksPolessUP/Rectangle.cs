using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksPolessUP
{
    class Rectangle
    {
        int x1; 
        int y1;
        int x2; 
        int y2;

        static public int SquareTwo(Rectangle r1, Rectangle r2)
        {
            int x = 0, y = 0;
            for (int i = r1.x1; i < r1.x2; i++)
            {
                  if(i >= r2.x1 && i < r2.x2) x++;                
            }
            for (int i = r1.y1; i < r1.y2; i++)
            {
                if (i >= r2.y1 && i < r2.y2) y++;               
            }
            return x * y;
        }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
    }
}
