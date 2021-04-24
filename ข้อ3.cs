using System;

namespace examGrab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String mode:");
            string Mode = Console.ReadLine();
            Console.Write("Input filmBackWidth:");
            float filmBackWidth = float.Parse(Console.ReadLine());
            while (filmBackWidth <= 0)
            {
                Console.WriteLine("Invalid filmBackWidth. Please input again.");
                filmBackWidth = float.Parse(Console.ReadLine());
            }
            float fLength, fov;
            if (Mode == "fLength")
            {
                fLength = float.Parse(Console.ReadLine());
                while (fLength <= 0)
                {
                    Console.WriteLine("Invalid filmBackWidth. Please input again.");
                }
                fov = 2 * Math.Atan(filmBackWidth / (2 * fLength);
                Console.WriteLine("fLength={0},fov={1}", fLength, fov);
            }
            else if (mode == "fov")
            {
                fov = double.Parse(Console.ReadLine());
                while (fov > 0.1 && fov < 6.28)
                {
                    Console.WriteLine("Invalid fov.Please input again.");
                    fov = double.Parse(Console.ReadLine());
                }
                fov = filmBackWidth / (2 * Math.Tan(fov / 2));
                Console.WriteLine("fLength={0},fov={1}", fLength, fov);
            }
        }
    }
