using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface_demo_130524
{
    public abstract class Shape
    {
        public abstract void Area();
        public abstract void Display();
        
    }
    public class Circle:Shape
    {
        int radius;
        float ar;
        public Circle(int r)
        {
            radius = r;
        }
        public override void Area()
        {
            ar = 3.14f * radius*radius;
        }
        override public void Display()
        {
            Console.WriteLine("Area of Circle="+ar);
        }
    }


    internal class assign1
    {
    }
}
