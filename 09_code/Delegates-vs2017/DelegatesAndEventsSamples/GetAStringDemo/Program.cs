using static System.Console;

namespace GetAStringDemo
{
  class Program
  {
    //定义一个委托
    private delegate string GetAString();

    static void Main()
    {
      int x = 40;
      //实例化委托
      GetAString firstStringMethod = new GetAString(x.ToString);
      WriteLine($"String is {firstStringMethod()}");
      // With firstStringMethod initialized to x.ToString(),
      // the above statement is equivalent to saying
      // Console.WriteLine("String is {0}", x.ToString());

      var balance = new Currency(34, 50);

      // firstStringMethod references an instance method
      firstStringMethod = balance.ToString;
      WriteLine($"String is {firstStringMethod()}");

      // firstStringMethod references a static method
      firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
      WriteLine($"String is {firstStringMethod()}");
    }
  }
}
