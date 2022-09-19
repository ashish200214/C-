using System;
namespace areaofrectangle{
    class areaofrec{
        public static void area(int length,int breadth)
        {
            int area;
            area=length*breadth;
            Console.WriteLine("area of rectangle is "+area);
        }
        class main{
            static void Main(String[]args)
            {
                int length,breadth;
                Console.WriteLine("enter the length");
                length=int.Parse(Console.ReadLine());
                Console.WriteLine("enter the breadth");
                breadth=int.Parse(Console.ReadLine());
                area(length,breadth);
            }
        }
        
    }
}
