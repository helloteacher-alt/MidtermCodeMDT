using System;

namespace examGrab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's day today:");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Time:");
            int Time = int.Parse(Console.ReadLine());
            int breakfastSet = 5;
            int weekendSet = 2;
            int coffee = 3;
            int Whatchoose;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------- Order Avaiable----------");
                Console.WriteLine("breakfastSet = {0}  |  weekendSet = {1}  |  coffee = {2}", breakfastSet, weekendSet, coffee);
                Console.Write("Choose the set:");
                Whatchoose = int.Parse(Console.ReadLine());
                if (Whatchoose == breakfastSet)
                {
                    if (Time < 8 && Time > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else if (Time >= 8 && Time <= 11)
                    {
                        if (breakfastSet == 0)
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        else breakfastSet = breakfastSet - 1;
                    }
                }
                else if (Whatchoose == weekendSet)
                {
                    if (Day == 6 || Day == 7)
                    {
                        if (weekendSet == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        else weekendSet = weekendSet - 1;
                    }
                    else Console.WriteLine("Sorry your order is not available");
                }
                else if (Whatchoose == coffee)
                {
                    if (coffee == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else coffee = coffee - 1;
                }

            } while (breakfastSet != 0 && weekendSet != 0 && coffee != 0);
            Console.ReadLine();
        }
    }
}
