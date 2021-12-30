using System;

class Program
{
    static void Main()
    {
        int wide = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int area = wide * length;
        int pices = 0;
        int  result = 0;

        for (int i = 0; i < area; i++)
        {
            string stop = Console.ReadLine().ToLower();
            pices += int.Parse(stop);

            if (stop == "stop")
            {
                break;
            }
           
            if (pices > area)
            {
                break;
            }
        }
        if (area >= pices)
        {
            result = area - pices;
            Console.WriteLine("{0} pieces are left.", result);
        }
        else
        {
            result =pices - area;
            Console.WriteLine("No more cake left! You need {0} pieces more.", result);
        }
    }
}
