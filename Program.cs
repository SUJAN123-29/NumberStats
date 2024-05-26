using System.Linq;
using System.Collections.Generic;
using System;

namespace NumberStats
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            
            while(restart)
            {
                List<int> numbers = new List<int>();
                string input;
                Console.Write("One integer only! To finish press enter without writing anything. You might need to press enter twice ");

                do
                {
                    input = Console.ReadLine();

                    if(!string.IsNullOrEmpty(input))
                    {
                        if (int.TryParse(input, out int number))
                        {
                            numbers.Add(number);
                        }
                        else
                        {
                            Console.WriteLine("Ensure that it is but an integer.");
                        }
                    }
                    else
                    {
                        break;
                    }
                    }while (!string.IsNullOrEmpty(input));

                    if(numbers.Count == 0)
                    {
                        Console.WriteLine("You forgot to write integer.!");
                    }
                    else
                    {
                        var oddnumbers = numbers.Where(n => n % 2 != 0).ToList();
                        var evennumbers = numbers.Where(n =>n % 2 == 0).ToList();
                        int maximum = numbers.Max();
                        int minimum = numbers.Min();
                        int oddsum = oddnumbers.Sum();
                        int evensum = evennumbers.Sum();
                        int evencount = evennumbers.Count();
                        int oddcount = oddnumbers.Count();
                        double evenaverage = evencount > 0 ? evennumbers.Average() : 0;
                        double oddaverage = oddcount > 0 ? oddnumbers.Average() : 0;
                        Console.WriteLine($"maximum value: {maximum}");
                        Console.WriteLine($"minimum value: {minimum}");
                        Console.WriteLine($"total of odd integers: {oddcount}");
                        Console.WriteLine($"sum of odd integers: {oddsum}");
                        Console.WriteLine($"The avg of odd integers: {oddaverage:F2}");
                        Console.WriteLine($"total of even integers: {evencount}");
                        Console.WriteLine($"sum of even integers: {evensum}");
                        Console.WriteLine($"The avg. value of even integers: {evenaverage:F2}"); 
                    }
                    Console.WriteLine("Once More (Y/y)?");
                    string response = Console.ReadLine();
                    restart = response.Equals("Y", StringComparison.OrdinalIgnoreCase);
                }
            }
        }
    }