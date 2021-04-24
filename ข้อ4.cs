using System;

namespace examGrab
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            Console.Write("Input X1:");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Input Y1:");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Input X2:");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Input Y2:");
            float y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;

            float dxABS = Math.Abs(dx);
            float dyABS = Math.Abs(dy);
            if (dxABS >= dyABS)
            {
                step = dxABS;
            }
            else step = dyABS;
            dx /= step;
            dy /= step;
            x = x1;
            y = y1;
            int i = 1;
            if (i <= step)
            {
                do
                {
                    Console.WriteLine(x, y);
                    x += dx;
                    y += dy;
                    i++;
                } while ();
            }
        }
    }
