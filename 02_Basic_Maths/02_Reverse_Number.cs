int originalNumber = Convert.ToInt32(Console.ReadLine());
int n = originalNumber;
int revNumber = 0;

while(n > 0)
{
    int lastDigit = n % 10;
    revNumber = (revNumber * 10) + lastDigit;
    n = n / 10;
}

Console.WriteLine(revNumber);