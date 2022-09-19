using System;
namespace Rectangleapp{

    class Main{
        double length;
        double width;
        public void Acceptdetails()
        {
            length=4.5;
            width=3.5;
        }
        public double GetArea()
        {
            return length*width;
        }
        public void Display()
        {
            Console.WriteLine("Length = {0}",length);
            Console.WriteLine("breadth = {0}",width);
            Console.WriteLine("Area is = {0}",GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main (String[]args)
        {
        Main r=new Main();
        r.Acceptdetails();
        r.Display();
        }
        
    }
}

