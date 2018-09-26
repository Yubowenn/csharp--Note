using System;
namespace homework2
{
    class Program
    {
        static void Main()
        {
            int number;
            int i,j;
            Console.Write("**请输入一个正整数：");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**以下是加法表**");
            for(i=0,j=number;i<=number;i++,j--)
            {
                Console.WriteLine(i+"+"+j+"="+number);
            }
            Console.ReadLine();
        }
    }  
}



