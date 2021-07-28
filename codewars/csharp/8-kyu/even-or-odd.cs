
using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      // if the number modulus 2 is equal to 0 then
      if (number % 2 == 0)
      {
        // the answer is "Even"
        return "Even";
      }
      else
      {
        // else the answer is "Odd"
        return "Odd";
      }
    }
  }
}