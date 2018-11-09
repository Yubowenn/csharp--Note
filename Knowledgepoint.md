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
                                                                            
### string.split方法
* 例：
```c#
using System;

public class SplitTest {
    public static void Main() {

        string words = "This is a list of words, with: a bit of punctuation" +
                       "\tand a tab character.";

        string [] split = words.Split(new Char [] {' ', ',', '.', ':', '\t' });

        foreach (string s in split) {

            if (s.Trim() != "")
                Console.WriteLine(s);
        }
    }
}
```
* split()是中的分隔符，在该例中，在char[]类型的一个数组里，意思是遇到以下字符会进行分隔，该例题中分隔后最后得到的数组是{"This","is","a","list","of","words","with","a","bit","of","punctuation","and","a","tab","character"}


###关键字
* sealed:密封的，不能继承
```c#
public sealed class MyClass
{
// Class members.
}
```
