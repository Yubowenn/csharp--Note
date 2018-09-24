using System;
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
    
}