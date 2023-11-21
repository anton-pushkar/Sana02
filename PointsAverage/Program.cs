double n1, n2, n3, n4, n5, avr;
Console.WriteLine("Enter n1:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter n2:");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter n3:");
n3  = double.Parse(Console.ReadLine());
Console.WriteLine("Enter n4:");
n4  = double.Parse(Console.ReadLine());
Console.WriteLine("Enter n5:");
n5  = double.Parse(Console.ReadLine());
avr = (n1 + n2+ n3 + n4+n5 ) / 5;
if(avr < 50)
{
    Console.WriteLine("You don`t pass the exam");
} else
{
    Console.WriteLine("You pass the exam");
}