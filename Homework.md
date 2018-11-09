# homework
新建的一个测试仓库，用来存放我的作业代码
```c#
/*结构体的定义*/
using System;
namespace example1
{
    class Program
    {
        static void Main()
        {
            ComplexNumber c1;//定义结构体变量
            c1.a=1;c1.b=2;
            Console.Write("c1= ");
            c1.Write();
            Console.ReadLine();
        }
    }
    struct ComplexNumber
    {
        public double a;//注意这里的权限修饰符，internal也可以
        public double b;

        public void Write()
        {
            Console.WriteLine("{0}+{1}i",a,b);
        }
    }
}
```