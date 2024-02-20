using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many random integers would you like?");
        int count = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            numbers[i] = rand.Next(1, 10); 
        }

        Console.WriteLine("Random integers generated!");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine($"\nTotal sum of the numbers when added: {Add(numbers)}");
        Console.WriteLine($"Total sum of the numbers when multiplied: {Multiply(numbers)}");
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}