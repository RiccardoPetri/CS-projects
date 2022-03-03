using System;
using System.IO;

namespace NullOperators         //if i want to use this, i have to tap "Set as startupProject"!!!!! and bolding the NullPointer console app
{
    class Program       //Null-conditional operators
    {
        static void Main(string[] args)
        {

            //________________________________________________________________________________________________________________

            //The Null-Conditional Operator
            //Console.Write(myObject?.Items?[0].ToString());


            //The Conditional Operator
            //return isTrue ? "Valid" : "Lie";


            //The Null Coalescing Operator
            //return myObject ?? yourObject;    A ?? (B ?? C)


            //Nullable Value Types Nullable<T>   ->         i can use x.hasValue (it is bool) also  x.getValueOrDefault(-1) if is null x = -1
            //int? universalAnswer = 42;


            //Nullable Reference Types
            //string? value = "bob";


            //Nullable array of nullable reference objects
            //public static Delegate? Combine(Delegate?[]? delegates)

            //Since each parameter is of the type Delegate? and you return an index of the Delegate?[]? array, then it makes sense that the return
            //type is Delegate? otherwise the compiler would return an error as if you were returing and int from a method that returns a string.

            //params Delegate?[] delegates(...)     It is an array of nullable Delegate
            //params Delegate?[]? delegates         The entire array can be nullable
            //________________________________________________________________________________________________________________


            string str =null;

            //if(str == null)
            //{
            //    str = "ciao";
            //}

            str ??= "ciao"; //if str is null, then set it as "ciao"

            Console.WriteLine(str);


            int? a = null;      //int? is a shortcut for Nullable<int> (if the left hand is null!!!
            a ??= (-1 + 80);    // ??= for assignment  and  ?? to return (the right-hand element if the left-element is null)
            int b = a ?? (-1+80);    //if a is null then set it as -1+80 (but i did the assignment at line 24, so will not change a again!!
            Console.WriteLine(b);  // output: -1


            //var a = model?.Value;
            //var a = model == null ? null : model.Value;


            //________________________________________________________________________________________________________________

            //Creating a method inside another method is called local functions in C#.
            //Using a method inside another method makes code easier to read. Local functions is just like lamda expressions.
            //Local function is a private method.
            int GetSumOfFirstTwoOrDefault(int[] numbers)
            {
                //If numbers evaluates to null, the result of numbers?.x or numbers?[x] is null and it doesnt evaluate .x , so that i can use ?? with numbers as null
                if((numbers?.Length ?? 0) < 2)  //if i dont use ??  ->     numbers?.Length  < 2   evaluate as false when numb is null
                {
                    return 0;
                }
                return numbers[0] + numbers[1];
            }

            Console.WriteLine(GetSumOfFirstTwoOrDefault(null));  // output: 0
            Console.WriteLine(GetSumOfFirstTwoOrDefault(new int[0]));  // output: 0
            Console.WriteLine(GetSumOfFirstTwoOrDefault(new[] { 3, 4, 5 }));  // output: 7



            //________________________________________________________________________________________________________________

            string manyLines = @"This is line one
                                This is line two
                                Here is line three
                                The penultimate line is line four
                                This is the final, fifth line.";

            using var reader = new StringReader(manyLines);
            string item;
            do
            {
                item = reader.ReadLine();
                Console.WriteLine(item);
            } while(item != null);
        }
    }
}
