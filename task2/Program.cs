Console.WriteLine("input x-coordinate A");
int xA = int.Parse(Console.ReadLine());

Console.WriteLine("input y-coordinate A");
int yA = int.Parse(Console.ReadLine());

Console.WriteLine("input z-coordinate A");
int zA = int.Parse(Console.ReadLine());

Console.WriteLine("input x-coordinate B");
int xB = int.Parse(Console.ReadLine());

Console.WriteLine("input y-coordinate B");
int yB = int.Parse(Console.ReadLine());

Console.WriteLine("input z-coordinate B");
int zB = int.Parse(Console.ReadLine());

double distance = 0;

//√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine(Math.Round(distance, 3));
