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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string period = s.Substring(s.Length - 2);
        string hour = s.Substring(0,2);
        string remaining = s.Substring(2, 6);
        
        int hourInt = int.Parse(hour);
        
        if(period == "PM" && hourInt != 12){
            hourInt += 12;
        }
        else if(period == "AM" && hourInt == 12){
            hourInt = 0;
        }
        
        hour = hourInt.ToString("D2");
        
        return hour + remaining;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
