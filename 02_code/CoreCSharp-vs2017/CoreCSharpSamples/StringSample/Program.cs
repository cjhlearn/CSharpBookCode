using static System.Console;

namespace StringSample
{
    class Program
    {
        static void Main()
        {
            //string对象是生存在堆上的，引用类型
            //s1指向“a string的内存地址”
            string s1 = "a string";
            //s2也指向“a string的内存地址”
            string s2 = s1;
            WriteLine("s1 is " + s1);
            WriteLine("s2 is " + s2);
            //s1指向新的内存地址“another string”
            //但s2依旧指向“a string”的内存地址，这要与一般的对象引用区别对待
            s1 = "another string";
            WriteLine("s1 is now " + s1);
            WriteLine("s2 is now " + s2);
        }
    }
}
