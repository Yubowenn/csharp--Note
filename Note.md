# 这个仓库专门用来记录我的csharp学习的

## github相关学习
### 本地项目的知识总结
* 观看了视频后，我在电脑上也安装了github desktop这个简易的托管软件。大概总结出了一个简单的是用流程：
* 首先在自己的github里面新建了一个仓库，这里也跟视频里的一样作为testapp，并且勾选同时创建.md文件。
该笔记就是通过markdown文件编写的，也供自己日后查看。
* 在上一步中新建的仓库在本地选取存储路径，并且通过desktop打开同步到本地。
* 第二步在vs code中打开刚才保存的文件夹，这样就将新建的项目通过vs code打开了。这里发现vs code和微软
office套件的用法差不多，比如我在编写自己新建的testapp项目中的.md文件，同时也可以在另外一个vs code窗
口打开文件夹参考程老师的csharp的源代码和.md文件（在一个编译器中不能打开两个文件夹，是在不同的窗口打开的）
* 然后我在自己的学习笔记中更新我的笔记，然后通过desktop更新到的github远程仓库，这样我的笔记以及代码全部
保存下来了，我在不同的电脑上都可以查看我自己的代码和笔记。                                            2018/9/23

### 联机学习和项目
* 还没有正式开始一个项目的合作和代码编写，看课件和视频了解了一些基本的联机完成项目的步骤。主要的就是首先拷贝
项目的原始仓库。自己在本地对项目的代码进行完善或者改善后，向队长管理员管理的仓库发起一个推送pull request，
来更新。
另外，别人更新的仓库，我可以在desktop上同步到本地观察最新的动态。                                     2018/9/23


## c#基本语法（主要写上一些与java不一样的新的，还有一些不认识的）
### 结构体变量
* 与定义成员方法有点像，这里定义的是一个变量，放在c语言里就比较好理解了，不要与定义类和定义方法弄混了，这里是
一个变量
* 例：
```c#
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
            Console.Readline();
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
* 在这里权限修饰符，结构体中的变量a，b还有方法全部都用的public，public不仅允许本数据集，还可以在其他的文件
中调用。如果不用public，那么默认为private，只能在声明的类或者结构中使用。在这里是用internal修饰符也是可以的。

### 定义数组的方法
* 声明数组定义数组的大小:
```c#
int[] a=new int[10];
```
* 初始化赋初值：
```c#
int[] a={1,2,3};
```
* 多维数组的初始化：
```c#
int[,] a={{1,2,3},{2,3,4}};
```                                                                                                 
                                                                                                2018/9/23

###


## c#零碎知识点（不认识的，不定期更新）
### 函数Console.WriteLine与Console.Write的区别
* Console.WriteLine()会在输出字符串之后换行，与java中的println类似；
* Console.Write()不会换行

### c#访问权限修饰符
* public：程序集内外都可访问，枚举类型成员或接口隐含的访问权限
* internal：程序集内或友元程序集内可访问（同一命名空间中），非嵌套类型的默认访问权限
* private：仅在包含类型中可见，类成员或结构体成员的默认访问权限
* protected：仅在包含类型中或子类中可见
* proctected internal：protected和internal访问权限的并集（在程序集中或其他程序集的子类中可访问）。

* private< protected/internal< public 这个很明显了。 关键是protected和internal的问题。

### ReadLine和Read的用法
* 其实与WriteLine和Write的区别是一样的。Read()是读取屏幕上输入的一个字符。
* 在老师给的很多例子中，有的有在主函数最后加上一个Console.WriteLine()函数。其作用就是在终端输出显示
结果之后，需要再次按屏幕任意键即可继续使用命令行工具，如果不按任意键，该程序其实还未终止。这里通过调试，
可以将最后ReadLine()读取的字符给输出出来。

### get和set的用法
* 用于外部访问私有成员变量时，可以起到一个读和写的作用，以下是参考网站资料
https://www.cnblogs.com/lixiaolu/p/8214037.html
https://www.cnblogs.com/liuyaozhi/p/4920275.html                                          
                                                                                                2018/9/23




