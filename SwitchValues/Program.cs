﻿int num;
Console.WriteLine("Enter num [0;9]:");
num = int.Parse(Console.ReadLine());
switch (num)
{
    case 0: { Console.WriteLine("Zero"); break; }
    case 1: Console.WriteLine("One"); break;
    case 2: Console.WriteLine("Two"); break;
    case 3: Console.WriteLine("There"); break;
    case 4: Console.WriteLine("Four"); break;
    case 5: Console.WriteLine("Five"); break;       
    case 6: Console.WriteLine("Six"); break;
    case 7: Console.WriteLine("Seven"); break;
    case 8: Console.WriteLine("Eight"); break;
    case 9: Console.WriteLine("Nine"); break;
    default: Console.WriteLine("You enter uncorrect number!"); break;
}