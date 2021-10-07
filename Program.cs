using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    // Lambda expressions are nothing more than a concise way to author anonymous
    // methods and ultimately simplify how you work with the.NET Core delegate type.

    // A lambda expression is written by first defining a parameter list, followed by the => token,
    // followed by a set of statements(or a single statement) that will process these arguments.
    // From a high level, a lambda expression can be understood as follows:
    // ArgumentsToProcess => StatementsToProcessThem

    class Program
    {
        static void Main()
        {
            TraditionalDelegateSyntax();
            AnonymousMethodSyntax();

            LambdaExpressionSyntax();
            LambdaExpressionSyntax2();

            Console.ReadLine();
        }

        static void TraditionalDelegateSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Call FindAll() using traditional delegate syntax.
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("\nHere are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        // Target for the Predicate<> delegate.
        static bool IsEvenNumber(int i)
        {
            // Is it an even number?
            return (i % 2) == 0;
        }

        static void AnonymousMethodSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Now, use an anonymous method.
            List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });
            
            Console.WriteLine("\nHere are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        static void LambdaExpressionSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Now, use a C# lambda expression.
            List<int> evenNumbers = list.FindAll((i) => (i % 2) == 0);

            Console.WriteLine("\nHere are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        static void LambdaExpressionSyntax2()
        {
            Console.WriteLine();

           // Make a list of integers.
           List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Now process each argument within a group of code statements.
            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("value of i is currently: {0}", i);
                bool isEven = (i % 2) == 0;
                return isEven;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }
    }
}