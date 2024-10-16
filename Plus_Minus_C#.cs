Q: Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

Input Format

The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe arr[n].

Output Format
Print the following  lines, each to 6 decimals:
-proportion of positive values
-proportion of negative values
-proportion of zeros

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {

    /* Input: 
    *   - n = the size of the array - **I need to declare this/extract it from the input
    *   - space seperated integers that make up the array
    *
    *  Output: (each on seperate line, 6 digits after decimal)
    *   1. ratio of positive values 
    *   2. ratio of negative values
    *   3. ratio of zero values 
    *
    *  Constraints:
    *   - n is greater than 0, less than or equal to 100
    *   - the integers in the array are equal to/between -100 and +100
    */
    
            
    //- can use if statements to check whether the integer is negative, positive, or 0
    //- need to add these together - need variables to hold each value (count)
    int positiveCount = 0;
    int negativeCount = 0;
    int zeroCount = 0;
    //- then divide by n
        int n  = 0;
    // need a looping structure, for each? to iterate through the array 
    
    // also need error handling, so will put eveyrything inside a try-catch block:
  
    try{
    foreach (int integer in arr){
         //n is just the length of the array
        n++;
        
        //negative
        if (integer >=-100 && integer <0)
        {
            //negativeCount += integer; this is wrong because I am adding the value of the integer which is not necessary, I need to add the count
            negativeCount++; //this just increments the count by 1, which is what you want 
        } 
        // zero
        else if (integer == 0)
        {
            //zeroCount += integer;
            zeroCount++;
        }
        //check that integer is not greater than 100 or less than -100
        else if (integer > 100 || integer < -100 )
        {
            throw new IndexOutOfRangeException("Integers cannot be greater than 100 or less than -100");
        }
        // positive
        else 
        {
            //positiveCount += integer;
            positiveCount++;
        }
      }
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot calculate ratios for an array with 0 integers. Please try again,");
    }
    catch (Exception e)
    {
        Console.WriteLine("Error. Please try again.");
    }
 
    
    // now calculate the ratios:
     float positive = (float)positiveCount/n;
    float negative = (float)negativeCount/n;
    float zero = (float)zeroCount/n;
   
    
    //print the values in 3 seperate lines:
    //Console.WriteLine(String.Format("{0:N6}", negative));
     Console.WriteLine(positive.ToString("N6"));
    Console.WriteLine(negative.ToString("N6"));
    Console.WriteLine(zero.ToString("N6"));
   
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}