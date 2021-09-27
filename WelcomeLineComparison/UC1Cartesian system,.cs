using System;

namespace Cartesian_system_
{
    class Program
    {
        public void cartesian()
        {
            int lineLength;
            Console.Write("Length of x1 : ");
            int linex1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of x2 : ");
            int linex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y1 : ");
            int liney1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y2 : ");
            int liney2 = Convert.ToInt32(Console.ReadLine());
            lineLength = (linex2 - linex1) * (linex2 - linex1) - (liney2 - liney1) * (liney2 - liney1);
            Console.WriteLine("Length of two points : " + Math.Sqrt(lineLength));
        }
        static void Main(string[] args)
        {
            Program CartSys = new Program();
            CartSys.cartesian();
        }
    }
}
