double a, b, c, d, x1,x2;
Console.WriteLine("Enter a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter c:");
c = double.Parse(Console.ReadLine());
d = b * b - 4 * a * c;
if (d > 0) {
    x1 = (-b - Math.Sqrt(d)) / (2 * a);
    x2 = (-b + Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("x1 = {0}\n x2 = {1}", x1, x2);
} else if (d == 0) {
    x1 = (-b) / (2 * a);
    Console.WriteLine("x = {0}", x1);
} else {
    Console.WriteLine("No roots");
}
