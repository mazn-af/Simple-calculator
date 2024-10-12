using System;
using System.Runtime.CompilerServices;
public class m
{
   static void Main(string[]args)
   {

string str1;// First Number
string str2;// 2st Number

Console.WriteLine("Enter first num:");
    str1 = Console.ReadLine();
Console.WriteLine("Enter sec num:");
    str2= Console.ReadLine();
Console.WriteLine("Enter The operation:");
   
    
    int num1=int.Parse(str1); //string to int
    int num2=int.Parse(str2); //string to int
Console.WriteLine($"{num1}+{num2}="+(num1+num2));// result: num1+num2=??
Console.WriteLine($"{num1}-{num2}="+(num1-num2));// result: num1-num2=??    
Console.WriteLine($"{num1}/{num2}="+(num1/num2));// result: num1/num2=??    
Console.WriteLine($"{num1}*{num2}="+(num1*num2));// result: num1*num2=??    


    
   }
}