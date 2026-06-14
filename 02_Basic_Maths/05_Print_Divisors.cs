int number = Convert.ToInt32(Console.ReadLine());
Divisor divisor = printDivisorsBetter;
divisor(number);

void printDivisors(int number)
{ // my solution
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
            Console.WriteLine(i);
    }
}

void printDivisorsBetter(int number)
{ // striver's solution
    List<int> ls  = new List<int>();
    for (int i = 1; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            ls.Add(i);
            if ((number/i) != i)
                ls.Add(number/i);
        }
    }
    ls.Sort();
    foreach(int divisor in ls)
    {
        Console.WriteLine(divisor);
    }
}

delegate void Divisor(int number);