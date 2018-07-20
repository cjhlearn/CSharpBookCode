using static System.Console;
/**
 *  结构体的使用
 *  结构体的无参构造函数，不随构造函数的重载而隐藏
 * 
 */
namespace StructsSample
{
    class Program
    {
        static void Main()
        {
            var point = new Dimensions();
            point.Length = 3;
            point.Width = 6;

            ReadLine();
        }
    }
}
