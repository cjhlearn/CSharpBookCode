using static System.Console;

namespace VariableScopeSample2
{
    class Program
    {
        //成员属性与局部变量的
        //static int j = 0;
        static int Main(string[] args)
        {
            int j = 20;
            for (int i = 0; i < 10; i++)
            {
                //j = 30; // Can't do this — j is still in scope
                WriteLine(j + i);
            }
            return 0;
        }
    }
}
