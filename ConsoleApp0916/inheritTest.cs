using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Man
    {
        private string fName;

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
        private string lName;

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public virtual void PrintInfo()//virtual는 OverRide를 가능하게 해주는것(허락해주는것)
        {
            Console.WriteLine("=============Employee==============");
            Console.WriteLine("First Name: {0}",fName);
            Console.WriteLine("Last Name: {0}",lName);
            Console.WriteLine("==============================");
        }

       
    }
    class Employee : Man // private은 상속이여도 못받는다.
    {
        int employeeID;//생성자
        public Employee(int employeeID)
        {
            
            this.employeeID = employeeID;
        }
        public override void PrintInfo()//new를 쓰면 물려준 클래스것을 무시하고 이것만 출력한다.(OverLoad 다형성, OverRide는 재정의)
                                        //new를 쓰는 이유는 virtual를 못붙여줄때 즉, 오버라이딩이 안될때 사용한다.
        {
            Console.WriteLine("=============Employee==============");
            Console.WriteLine("employeeID:{0}",employeeID);
            Console.WriteLine("First Name: {0}",this.FirstName);
            Console.WriteLine("Last Name: {0}",this.LastName);
            Console.WriteLine("==============================");
        }
    }
    class InheritTest
    {
        static void Main()
        {
            Man man = new Man();
            man.FirstName ="류";
            man.LastName = "현진";
            man.PrintInfo();

            Employee emp1 = new Employee(2020155);
            emp1.FirstName = "아";
            emp1.LastName = "이유";
            emp1.PrintInfo();

            Console.WriteLine(man.ToString());
        }
    }
}
