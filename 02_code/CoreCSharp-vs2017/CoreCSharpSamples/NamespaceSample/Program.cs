﻿using Introduction = Wrox.ProCSharp.Basics;
using static System.Console;

class Program
{
    static void Main()
    {
        //命名空间的别名的使用
        Introduction::NamespaceExample NSEx =
          new Introduction::NamespaceExample();
        WriteLine(NSEx.GetNamespace());
    }
}

namespace Wrox.ProCSharp.Basics
{
    class NamespaceExample
    {
        public string GetNamespace()
        {
            return this.GetType().Namespace;
        }
    }
}
