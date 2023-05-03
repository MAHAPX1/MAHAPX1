
// 21 задание C#
/* 
    Учитывая координаты двух прямолинейных прямоугольников в 2D-плоскости, верните общую площадь, покрытую двумя прямоугольниками.
    Первый прямоугольник определяется своим нижним левым и (ax1, ay1) верхним правым углами (ax2, ay2).
    Второй прямоугольник определяется левым нижним и (bx1, by1) правым верхним углами (bx2, by2).

    Ввод: ax1 = -3, ay1 = 0, ax2 = 3, ay2 = 4, bx1 = 0, by1 = -1, bx2 = 9, by2 = 2 
    Вывод: 45 ((((ЭТО НЕ ПРАВИЛЬНО))))
*/

namespace TasksPolessUP
{
    class Program
    {    
        static void Main(string[] args)
        {
            // Исходные данные из условия
            Rectangle r1 = new Rectangle(-3, 0, 3, 4);
            Rectangle r2 = new Rectangle(0, -1, 9, 2);

            // Пример где прямоугольники не соприкасаются
            //Rectangle r1 = new Rectangle(1, 1, 3, 3);
            //Rectangle r2 = new Rectangle(3, 3, 4, 5);

            // Просто пример для теста
            //Rectangle r1 = new Rectangle(1, 1, 3, 6);
            //Rectangle r2 = new Rectangle(2, 3, 5, 5);
            Console.WriteLine(Rectangle.SquareTwo(r1, r2));
            Console.ReadKey();
        }

    }
}
    

