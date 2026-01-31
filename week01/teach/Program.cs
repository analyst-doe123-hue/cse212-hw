using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n======================");
        Console.WriteLine("Divisors");
        Console.WriteLine("======================");
        Divisors.Run();

        Console.WriteLine("\n======================");
        Console.WriteLine("Array Selector");
        Console.WriteLine("======================");
        ArraySelector.Run();

        // Uncomment when you are ready to run Algorithms
       
        Console.WriteLine("\n======================");
        Console.WriteLine("Algorithms");
        Console.WriteLine("======================");
        Algorithms.Run();
        

        // Uncomment to compare with provided solutions
        
        Console.WriteLine("\n======================");
        Console.WriteLine("Divisors Solution");
        Console.WriteLine("======================");
        DivisorsSolution.Run();

        Console.WriteLine("\n======================");
        Console.WriteLine("Array Selector Solution");
        Console.WriteLine("======================");
        ArraySelectorSolution.Run();
        
    }
}
