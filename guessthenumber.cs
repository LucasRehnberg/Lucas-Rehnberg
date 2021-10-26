using System;

class Program {
  public static void Main (string[] args) {
    Random rnd = new Random();
    //Targeted Number
    int n = rnd.Next(1,101);
    // Guessed Number
    int g = 0;
    // Times Guessed
    int t = 0;

    Console.WriteLine("Guess the number between 1 and 100: ");

    while(g!=n){
      g = int.Parse(Console.ReadLine());
      if(g==n){
        t++;
        break;
      } else if(g>n){
        Console.WriteLine("Try Lower");
        t++;
      } else if(g<n){
        Console.WriteLine("Try Higher");
        t++;
      }
    }
    Console.WriteLine($"You guessed it correctly! \nIt took you {t} tries.");
    Console.ReadKey();
  }
}
