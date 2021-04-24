using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {           
            Menu();            
        }
        static void Menu()
        {
            int day, times;


            Console.WriteLine("Input days number : ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Time : ");
            times = int.Parse(Console.ReadLine());
            Console.WriteLine("We got Breakfast Set, Weekend Set and Coffee");
            int z = 5;
            int x = 2;
            int c = 3;
            for (int i = 0; ; i++)
            {
                string Menu;
                Console.WriteLine("Please Enter your Menu and if you're done type End : ");
                Menu = Console.ReadLine();
                if (Menu == "Breakfast Set")
                {
                    
                    
                    if (z == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    if (times > 11)
                    {
                        Console.WriteLine("Sorry your order is unavaliable");
                    }
                    z--;

                }
                else if (Menu == "Weekend Set")
                {
                   
                    
                    if (x == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    if (day != 6 && day != 7)
                    {
                        Console.WriteLine("Sorry your order is unavaliable");
                    }
                    x--;
                }
                else if (Menu == "Coffee")
                {
                    
                    
                    if (c == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    c--;
                }
                else if (Menu == "End")
                {
                    Console.WriteLine("Thanks you for your order, Sir");
                    break;
                }
                else if (Menu != "Breakfast Set" || Menu != "Weekend Set" || Menu != "Coffee" || Menu != "End")
                {
                    Console.WriteLine("Please Enter Valid Menu");
                }
                

            }
            Console.ReadLine();
        }
        
    }
}
