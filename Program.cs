using System;
namespace homework2
{
    class Program
    {
        static void Main()
        {
            int i;
            int score;

            for(i=1;;i++)
            {
                Random rd = new Random();
                score = rd.Next(100);

                Console.Write("**第{0}次老师给小兰的表演打分为：",i);
                Console.WriteLine(score);

                if(score >= 60)
                {
                    Console.WriteLine("**老师对小兰的表演很满意，小兰可以回家**");break;
                }
                else
                {
                    Console.WriteLine("**老师对小兰的表演不满意，小兰重新表演一次**\n");
                }
            }

            Console.ReadLine();
        }
    }
    
}
