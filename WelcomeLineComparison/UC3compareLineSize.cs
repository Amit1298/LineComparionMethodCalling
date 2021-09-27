using System;

namespace compareLineSize
{
    class Program
    {
        public static void Size()
        {
            int lineLength1;
            Console.Write("Length of x1 : ");
            int linex1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of x2 : ");
            int linex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y1 : ");
            int liney1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y2 : ");
            int liney2 = Convert.ToInt32(Console.ReadLine());
            lineLength1 = (linex2 - linex1) * (linex2 - linex1) - (liney2 - liney1) * (liney2 - liney1);
            Console.WriteLine("Length of two points : " + Math.Sqrt(lineLength1));

            int lineLength2;
            Console.Write("Length of x3 : ");
            int linex3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of x4 : ");
            int linex4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y3 : ");
            int liney3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y4 : ");
            int liney4 = Convert.ToInt32(Console.ReadLine());
            lineLength2 = (linex4 - linex3) * (linex4 - linex3) - (liney4 - liney3) * (liney4 - liney3);
            Console.WriteLine("Length of two points : " + Math.Sqrt(lineLength2));
            if (lineLength1 == lineLength2)
            {
                Console.WriteLine("line are equal");
            }
            else if (lineLength1 > lineLength2)
            {
                Console.WriteLine("lineLength1 is greater than lineLength2");
            }
            else
            {
                Console.WriteLine("lineLength1 is less than lineLength2");
            }
        }
        static void Main(string[] args)
        {
            Program.Size();
        }
    }
}
