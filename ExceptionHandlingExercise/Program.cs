﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------

            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'A', 'B', 'C' };
            var numbers = new List<int>();
            var str = "";
            
            
            //TODO START HERE:

            // Done - 1) Create an char[], it must contain 6 numbers and 3 letters - name it arr
            
            // Done - 2) Create a list called numbers that will hold integers
        
            // Done - 3) Create an string variable with an empty string initializer - name it str
            
            // 4) Make a foreach loop to iterate through your character array            

            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
            }
            
            
                // Done - 5) Create a try-catch inide of your foreach loop
                    // Done- 6) Inside the try block: 
                        // 7) Set your string variable to each array element in your char[] to .ToString()
                        // 8) Now, using int.Parse, parse your string variable and store in an int variable
                        // 9) Then add each int to your list
                
                   // Done - 10) Inside the catch block:
                       // Done - 11) In the scope of your catch you can use the following code:                  
                       // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                
            
            // Uncomment the code below to see the numbers you successfully added to the numbers list: 
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
