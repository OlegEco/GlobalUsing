global using System.Collections.Generic;
global using System.Linq;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0);
Console.WriteLine("Even Numbers:");
foreach (var number in evenNumbers)
{
    Console.WriteLine(Convert.ToString(number));
}
