int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

// for (int i = 1; i <= number; i++)
// {
//     if (number % i == 0)
//         count++;
// }
// if (count == 2)
// {
//     Console.WriteLine($"{number} is a prime number.");
// }

for(int i = 1; i * i <= number; i++)
{
    if (number%i == 0)
    {
        count++;
        if((number/i) != i) 
            count++;
    }
}
if(count == 2)
    Console.WriteLine("true");
else
    Console.WriteLine("false");