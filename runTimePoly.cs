using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract_interface_demo_130524
{
    class person
    {
        private int adhar;
        string name;
        string add;
        public person()
        {
            
        }
        public person(int ad,string nm,string add)
        {
            adhar = ad;
            name = nm; 
            this.add = add;
        }
        virtual public void showInfo()
        {
            Console.WriteLine("---person information------");
            Console.WriteLine("Adhar= "+adhar+" Name= "+name+" address="+add);
        }
        public void xyz()
        {

        }
    }
    class teacher:person
    {
        private int empID;
        private int salary;
        public teacher()
        {
                
        }
        public teacher(int ed,int sal,int adr,string nm,string add):base(adr,nm,add)
        {
            empID = ed;
            salary = sal;
        }
        override public void showInfo()
        {
           
            Console.WriteLine("---Teacher information------");
            Console.WriteLine("Emp ID= "+empID+" Salary="+salary);
            base.showInfo();
            showInfo();
            base.xyz();
            xyz();//
            
        }
    }
    class student    : person
    {
        private int roll;
        private int per;
        public student()
        {
            
        }
        public  student(int rl, int per, int adr, string nm, string add) : base(adr, nm, add)
        {
           roll=rl;
            this.per = per;
        }
        override public void showInfo()
        {
            base.showInfo();
            Console.WriteLine("---student information------");
            Console.WriteLine("Roll No= " + roll + " Per=" + per);
        }
    }
    internal class runTimePoly
    {
        public void runTimeDemo()
        {
            person p;// reference variable p of class person
            //1 store object of same class(ie parent class)
            p = new person();
            //2 store object of child class teacher
            p = new teacher();
            //3 store objec of child class student
            p = new student();             
        }
        public void r1(person p)
        {
            p.showInfo();
        }
    }
}
