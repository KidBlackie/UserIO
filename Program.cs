// See https://aka.ms/new-console-template for more information

using System;
using UserIO;

Console.WriteLine("Hello, World!");

Input.TryReadInputAsDouble(out double test1);
Input.TryReadInputAsBool(out bool test2);

Console.WriteLine(test1);
Console.WriteLine(test2);
