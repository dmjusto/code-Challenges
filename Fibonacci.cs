using System;
using System.Collections.Generic;

namespace Fibonacci
{
  class Program
  {
    static void Main(string[] args)
    {
      int result = FibonacciRecursive(7);
      Console.WriteLine(result);

    }


    public static int FibonacciRecursive(int n)
    {
      if(n < 2)
      {
        return n;
      }
      int next = FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
      return next;
      //each number is the sum of the two before it
      //n =(n-1) + (n-2)
    }

    public static int FibonacciItterative(int index)
    {
      int current = 1;
      int previous = 0;
      int temp;

      for (int i = 1; i < index; i++)
      {
        Console.WriteLine(current);
        temp = current;
        current += previous;
        previous = temp;
      }

      return current;
    }
    
  }
}


//[0,1,1,2,3,5,8,13]
