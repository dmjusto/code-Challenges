using System;

namespace Factorial
{
  class Program
  {
    static void Main(string[] args)
    {
      int factorial = GetFactorialRecursive(4);
      //int factorial = GetFactorialItterative(4);
      Console.WriteLine(factorial);
    }

    public static int GetFactorialRecursive(int n)
    {
      if (n -1 == 0)
      {
        return n;
      }
      n *= GetFactorialRecursive(n-1);
      return n;
    }

    public static int GetFactorialItterative(int n)
    {
      for(int i = n -1; i > 0; i--)
      {
        n *= i;
      }
      return n;
    }
  }
}
