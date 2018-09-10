using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            if(a<5)
            {
                Console.WriteLine("This is my first line.");
            }
            else
            {
                Console.WriteLine("This is my second line.");
                Console.Beep(1000,1000);//发出一个蜂鸣
            }
            
        }
    }
}
