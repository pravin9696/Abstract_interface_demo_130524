using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface_demo_130524
{
   abstract class abc
    {
        public void add(int a,int b)
        {
            Console.WriteLine("addition ="+(a+b));
        }
     abstract public void multiplication(int x, int y);
       abstract public  int div(int a, int b);

        abstract public void SetStudentInfo(int roll, String name, int TotalMarks);
        
    }
    class child2_abc : abc
    {
        int var1;
        public child2_abc()
        {
            
        }
        public child2_abc(int x)
        {
            var1 = x;
        }
        public override int div(int a, int b)
        {
            Console.WriteLine("var 1="+var1);
            Console.WriteLine("$$$$$$$$$$$ div");
            return 0;
        }

        public override void multiplication(int x, int y)
        {
            Console.WriteLine("$$$$$$$$$$$4 multiplication");
        }

        public override void SetStudentInfo(int roll, string name, int TotalMarks)
        {
            Console.WriteLine("$$$$$$$$$$ student from child 2");
        }
    }
    class child_abc : abc
    {
        public void myMethod111()
        {

        }
        public override int div(int a, int b)
        {
            Console.WriteLine("#####child_ABC  Div="+(a/b));
            return a / b;
        }

        public override void multiplication(int x, int y)
        {
            Console.WriteLine("#####mul="+x*y);
        }

        public override void SetStudentInfo(int roll, string name, int TotalMarks)
        {
            Console.WriteLine("######student information collected");
        }
    }
    class xyz
    {
        public void show()
        {
            Console.WriteLine("show from xyz");
        }
    }
    class Child_xyz:xyz
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //xyz objX=new xyz();
            ////abc objA=new abc();
            //child_abc objCA = new child_abc();

            //objCA.add(11, 22);
            //objCA.div(10, 2);

            //----------------------------------------------------
            //Run time polymorphism



            //ref(parent class)  = object(child)
            // abc objA1 = new abc();
            //abc objA = new child_abc();

            //objA.div(100, 50);

            //Console.WriteLine(" -----------------------------------");
            //objA = new child2_abc(999);

            //objA.div(2, 2);

            //Console.WriteLine("--------------------");
            //objA = new child2_abc(1111);
            //objA.div(3, 3);

            //Circle c1 = new Circle(10);
            //c1.Area();
            //c1.Display();
            //ref and object of same class
            //myCalculator c1 = new myCalculator();
            //c1.add(1, 2);// compile time polymorphism


            ////ref parent and object of child

            //calculator c2 = new myCalculator();
            //c2.add(3, 4);
            //c2.add(1.1f, 2.2f);

            person p1 = new person(111,"rajesh","solapur");
            teacher t1 = new teacher(456,45000,3333,"Vijay","Nagar");
            student s1 = new student(99,78,222,"dinesh","Nashik");


            runTimePoly rtp = new runTimePoly();
            rtp.r1(p1);
            Console.WriteLine("--------------");
            rtp.r1(s1);
            Console.WriteLine("-----------------");
            rtp.r1(t1);

            Console.ReadKey();
        }
    }
}
