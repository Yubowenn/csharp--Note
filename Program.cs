using System;
<<<<<<< HEAD
namespace P5_3
{
    class Program
    {
        public static void Main()
        {
            Son s1 = new Son();
            System.GC.Collect();
        }
    }

    public class Grandsire
    {
        public Grandsire()
        {  Console.WriteLine("调用Grandsire的构造函数");   }

        ~Grandsire()
        {  Console.WriteLine("调用Grandsire的析构函数");   }
    }

    public class Father : Grandsire
    {
        public Father()
        {   Console.WriteLine("调用Father的构造函数");     }

        ~Father()
        {   Console.WriteLine("调用Father的析构函数");     }
    }

    public class Son : Father
    {
        public Son()
        {   Console.WriteLine("调用Son的构造函数");        }

        ~Son()
        {   Console.WriteLine("调用Son的析构函数");        }
    }
=======
namespace example1
{
    class Program
    {
        static void Main()
        {
            string b;
            int i;
            int[] a=new int[10];
            for(i=0;i<10;i++)
            {
                a[i]=i+1;
            }
            for(i=0;i<10;i++)
            {
                Console.Write("{0},",a[i]);
            }
            b=Console.ReadLine();
            Console.Write("{0}",b);
        }
    }
    
>>>>>>> 0de9b756c88fbda0f3cb91cfefe2553d3e1b72c3
}