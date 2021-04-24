using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avaliable Mode fLength / fov");
            string Mode;
            Console.WriteLine("Input Mode : ");
            Mode = Console.ReadLine();
            int i = 1;
            double fLength, fov;
            while (i != 0)
            {
                float Backwidth;
                Console.WriteLine("Input filmBackWidth : ");
                Backwidth = float.Parse(Console.ReadLine());
                if (Backwidth > 0)
                {                   
                    if (Mode == "fLength")
                    {
                        while (Mode == "fLength")
                        {
                            Console.WriteLine("Input fLength value : ");
                            fLength = float.Parse(Console.ReadLine());
                            if (fLength > 0)
                            {
                                fov = 2 * Math.Atan(Backwidth / (2 * fLength));
                                Console.WriteLine("fLength = {0}, fov = {1}", fLength, fov);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid fLength Please Input again");
                            }
                        }
                    }
                    else if (Mode == "fov")
                    {
                        while (Mode == "fov")
                        {
                            Console.WriteLine("Input fov value : ");
                            fov = float.Parse(Console.ReadLine());
                            if (fov > 0.1 && fov < 6.28)
                            {
                                fLength = Backwidth / (2 * Math.Tan(fov / 2));
                                Console.WriteLine("fLength = {0}, fov = {1}", fLength, fov);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid fov Please Input again");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid filmBackWidth Please Input again");
                }
                
            }
            Console.ReadLine();
        }
    }
}
