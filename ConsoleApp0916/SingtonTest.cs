using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{

    class button1
    {
        static int buttonCnt = 0;
        static button1 btn;
        int click = 0;
        public void Click()
        {
            click++;
            Console.WriteLine(click);
        }
       private button1() //싱글톤을 할때는 밖에서 main()에서 new 안되게 하는게 핵심
        {
            buttonCnt++;
            Console.WriteLine("버튼 {0}",buttonCnt);
        }
        public static button1 CreateInstance()//호출할수 있는 인스턴스가 없기 때문에 부르기 위해서 static 을 사용한다.
        {
            if (btn == null) 
            {
                btn = new button1();
            }
            return btn;
        }
    }
    
    class ClickCount
        {
            static void Main(string[] args)
        {
            if (args.Length == 2)
          
                Console.WriteLine(args[0] + "/" + args[1]);
          

           
            
            button1 btn1 = button1.CreateInstance();

            btn1.Click();
            btn1.Click();
            btn1.Click();

            button1 btn2 = button1.CreateInstance();
            btn2.Click();


        }

       
        }

}
