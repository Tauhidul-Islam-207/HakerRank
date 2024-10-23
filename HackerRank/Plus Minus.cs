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
        int pos = 0;
        int neg = 0;
        int zero = 0;
        
        for (int i=0;i<arr.Count;i++){
            
            if (arr[i]>0){
                pos++;
            }
            else if(arr[i]<0){
                neg++;
            }
            else{
                zero++;
            }
        }
        
        double posRatio = (double)pos / arr.Count;
        double negRatio = (double)neg / arr.Count;
        double zeroRatio = (double)zero / arr.Count;
        
        // Print results with 6 decimal places
        Console.WriteLine("{0:F6}", posRatio);
        Console.WriteLine("{0:F6}", negRatio);
        Console.WriteLine("{0:F6}", zeroRatio);
        
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
