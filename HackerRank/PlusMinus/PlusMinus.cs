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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        double pos = 0;
        double neg = 0;
        double zero = 0;

        foreach(int num in arr) {
            if(num > 0) {
                pos++;
            }
            else if(num < 0) {
                neg++;
            }
            else {
                zero++;
            }
        }

        Console.WriteLine(pos / arr.Length);
        Console.WriteLine(neg / arr.Length);
        Console.WriteLine(zero / arr.Length);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
