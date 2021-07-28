using System;


namespace TASK
{
    class B
    {
        
        int s1 = 10, s2 = 20;
        public void show()

        {
            A a = new A();
            Console.WriteLine(a.cal(s1, s2));
          
        }

    }
}


-------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace TASK
{
    class A
    {


        public int cal(int a, int b)
        {
            return a + b;
        }
    }
}


-------------------------------------------
using System;

namespace TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            
            b.show();

            Console.ReadKey();
        }
    }
}
