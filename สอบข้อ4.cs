using System;

namespace Examyes
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            float x1, y1, x2, y2;
            Console.WriteLine("Input x1 : ");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input y1 : ");
            y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input x2 : ");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input y1 : ");
            y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }
            dx /= step;
            dy /= step;
            x = x1;
            y = y1;
            int i = 1;
            while (i <= step)
            {
                Console.WriteLine("{0} {1}", x, y);
                x += dx;
                y += dy;
                i++;
            }
            Console.ReadLine();

            
        }
    }
}
