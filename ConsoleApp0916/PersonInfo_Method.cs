using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertForm;
namespace ConsoleApp0916
{
    class PersonInfo_Method
    {
        Person p1 = new Person();
        public string InputName(string _name)
        {
            Console.Write("이름을 입력해주세요 : ");
            _name = Console.ReadLine();      
            return _name;
        }
        public int InputAge(int _age)
        {
            Console.Write("나이를 입력해주세요 : ");
            _age = Utility.ConvertInt(Console.ReadLine());
            return _age;
        }

        public double InputHeight(double _height)
        {
            Console.Write("키를 입력해주세요 : ");
            _height = Utility.ConvertDouble(Console.ReadLine());       
            return _height;
        }
        public double InputWeight(double _weight)
        {
            Console.Write("몸무게을 입력해주세요 : ");
            _weight = Utility.ConvertDouble(Console.ReadLine());           
            return _weight;
        }
    }
}
