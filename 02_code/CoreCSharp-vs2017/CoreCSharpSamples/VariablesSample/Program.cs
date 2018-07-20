using System;
using static System.Console;

namespace VariablesSample
{
    class Program
    {
        static void Main()
        {
            //类型推断
            var name = "Bugs Bunny";
            var age = 25;
            var isRabbit = true;
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();
            WriteLine($"name is type {nameType}");
            WriteLine($"age is type {ageType}");
            WriteLine($"isRabbit is type {isRabbitType}");
        }
    }
}
