using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Type a limit for the program to calculate to: " );
    int x = Convert.ToInt32(Console.ReadLine());
    x++;
    Console.WriteLine("\n");

    Console.WriteLine("Type an interval for the program to break at: " );
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    int c = 0;
    for (int k = 1; k < x; k++){

      //variable declarations
      int flag = 0;
      int m = k / 2;

      //prints 0 if composite
      for(int i = 2; i <= m; i++) {
        if (k % i == 0) {
          Console.Write("0 ");
          flag = 1;
          break;
        }
      }

      //excludes 0 and 1 from primes 
      if (k == 0 || k == 1) {
        Console.Write("0 ");
        flag = 1;
      }

      //prints 1 if prime
      if (flag == 0) {
        Console.Write("1 ");
        //Console.WriteLine();
      }

      //allows for break in console
      c++;
      if (c == z) {
        Console.WriteLine();
        c = 0;
      }

      //tests to see if working right
      //Console.WriteLine(" the value of k is " + k);
    }
  }
}