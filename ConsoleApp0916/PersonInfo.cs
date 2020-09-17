using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ConvertForm;

namespace ConsoleApp0916
{
    public class Person
    {
        string name;
        int age;
        double height;
        double weight;
        #region Property
        public string Name 
        {
            get {return name;}
            set { name = value;}
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        #endregion   
       
    }
    class PersonInfo
    {
        static void Main(string[] args)
        {
            
            Console.Write("원하는 인원수를 적어주세요:");
            int a = Utility.ConvertInt(Console.ReadLine());
            Person[] arr = new Person[a];
            
            PersonInfo_Method m1 = new PersonInfo_Method();
            for (int i = 0; i < arr.Length; i++)
            {
                
                Person p1 = new Person();
                p1.Name     = m1.InputName(p1.Name);
                p1.Age      =   m1.InputAge(p1.Age);
                p1.Height   =   m1.InputHeight(p1.Height);
                p1.Weight   =   m1.InputWeight(p1.Weight);

                arr[i] = p1;
            }
            
            //입력된 3명의 정보를 출력하세요
            foreach(Person per in arr)
            {
                Console.WriteLine($"\n{per.Name}-{per.Age}-{per.Height}-{per.Weight}");
            }
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"\n{arr[i].Name}");
            }

        }
    }
}
