using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. 
         * Your class should be named Solution */
        int input = Int32.Parse(Console.ReadLine());
        int output = Factorial(input);
        Console.WriteLine(output);
    }
    static int Factorial(int i)
    {
        int factorial;
        if (i <= 1)
        {
            factorial = 1;
        }
        else
        {
            factorial = i * Factorial(i - 1);
        }
        return factorial;

    }
}