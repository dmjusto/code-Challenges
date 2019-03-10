using System;
using System.Collections.Generic;

namespace CommonElements
{
  class Program
  {
    //given two sorted integer arrays, return an array with the common elements
    //[1,3,4,6,7,9] and [1,2,4,5,9,10] should return [1,4,9]
    static void Main(string[] args)
    {
      List<int> arrayA = new List<int>{ 1, 3, 4, 6, 7, 9 };
      List<int> arrayB = new List<int>{ 1, 2, 4, 5, 9, 10 };

      foreach(var item in GetCommonElements(arrayA, arrayB))
      {
        Console.WriteLine(item);
      }
    }

    static List<int> GetCommonElements(List<int> array1, List<int> array2)
    {
      Dictionary<int, bool> haveSeen = new Dictionary<int, bool>();
      List<int> commonElements = new List<int>();

      //populate dictionary with elements from array 1
      for(int i = 0; i < array1.Count; i++)
      {
        haveSeen.Add(array1[i] , true);
      }

      //check elements of array 2 against the dictionary
      for(int i = 0; i < array2.Count; i++)
      {
        if (haveSeen.ContainsKey(array2[i]))
        {
          commonElements.Add(array2[i]);
        }
      }
      return commonElements;

    }
  }
}
