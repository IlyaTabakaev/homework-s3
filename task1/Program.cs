Console.WriteLine("input 5-digit number");
int x = int.Parse(Console.ReadLine());
int temp = x;
int r = 0;
int y = 0;

while (x > 0)
{
r = x % 10;
y = (y * 10) + r;
x = x / 10;
}


if (temp == y) 
{
Console.WriteLine("it's a Palindrome");
}

else
{
    Console.WriteLine("it's not a palindrome");
}