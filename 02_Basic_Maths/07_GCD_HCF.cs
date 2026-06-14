int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

while(n1 > 0 && n2 > 0)
{
    if (n1>n2)
        n1 = n1 % n2;
    else
        n2 = n2 % n1;
}

if (n1 == 0)
    Console.WriteLine($"GCD is {n2}.");
else if (n2 == 0)
    Console.WriteLine($"GCD is {n1}.");