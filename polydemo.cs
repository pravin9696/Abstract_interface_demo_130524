using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface_demo_130524
{
    class myClass
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
    class calculator
    {
      
       virtual public void add(int a,int b)
        {
            Console.WriteLine("add from calculator class");
            Console.WriteLine(a+b);
        }
      
      virtual  public void add(float f1,float f2)
        { 
            Console.WriteLine(f1+f2); 
        }
    }
    class myCalculator:calculator
    {
    override    public void add(int a, int b)
        {
            Console.WriteLine("add from child class myCalculator###");
            Console.WriteLine(a + b);
        }
    }
    internal class polydemo
    {
        public void temp()
        {
            calculator c1 = new calculator();
            c1.add(1,2);
        }
    }
}
