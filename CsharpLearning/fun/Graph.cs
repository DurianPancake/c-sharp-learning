using System;
using System.Runtime.CompilerServices;

namespace CsharpLearning.fun
{
    public class Rectangle
    {
        // 成员变量
        private double length;
        private double width;

        public Rectangle()
        {
            this.length = 1;
            this.width = 2;
        }
        
        public void setProperties(double length, double width)
        {
            if (!(isLegalNum(length) && isLegalNum(width)))
            {
                throw new RuntimeWrappedException("invalid number: "+ length);
            }
            this.length = length;
            this.width = width;
        }

        public double getArea()
        {
            return this.length * width;
        }
        
        public void display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getArea());
            Console.WriteLine("Length: {0} and Area: {1}", length, getArea());
        }
        
        private bool isLegalNum(in double num)
        {
            return num > 0;
        }
    }

    class ExecuteRectangle
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.display();
            
            r.setProperties(4.3,5.9);
            r.display();
            
            Console.WriteLine("size of {0}", sizeof(int));

            Object d = 30;
            Console.ReadLine();
        }
    }
}
