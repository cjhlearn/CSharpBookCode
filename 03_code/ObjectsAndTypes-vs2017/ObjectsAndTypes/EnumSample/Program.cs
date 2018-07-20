using System;
using static System.Console;

namespace EnumSample
{
    class Program
    {
        static void Main()
        {
            DaysOfWeekSamples();
            ColorSamples();
            UsingEnumClass();

            ReadLine();
        }

        private static void UsingEnumClass()
        {
            Color red;
            //TryParse声明为无论解析成功与否，都返回一个bool类型。解析的结果是使用out修饰符返回一个参数
            if (Enum.TryParse<Color>("Red", out red))
            {
                WriteLine($"successfully parsed {red}");
            }

            //Enum.GetName返回一个包含所有枚举名的字符串数组
            string redtext = Enum.GetName(typeof(Color), red);
            WriteLine(redtext);

            foreach (var day in Enum.GetNames(typeof(Color)))
            {
                WriteLine(day);
            }

            //Enum.GetValues返回枚举的所有值
            foreach (short val in Enum.GetValues(typeof(Color)))
            {
                WriteLine(val);
            }

            foreach (var item in Enum.GetValues(typeof(Color)))
            {
                WriteLine(item);
            }

        }

        private static void DaysOfWeekSamples()
        {
            DaysOfWeek mondayAndWednesday = DaysOfWeek.Monday | DaysOfWeek.Wednesday;
            WriteLine(mondayAndWednesday);
            DaysOfWeek weekend = DaysOfWeek.Saturday | DaysOfWeek.Sunday;
            WriteLine(weekend);
            DaysOfWeek workday = DaysOfWeek.Monday | DaysOfWeek.Tuesday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday  | DaysOfWeek.Friday;
            WriteLine(workday);
        }

        private static void ColorSamples()
        {

            Color c1 = Color.Red;
            WriteLine(c1);

            Color c2 = (Color)2;
            WriteLine(c2);
            WriteLine((short)c2);
        }
    }
}
