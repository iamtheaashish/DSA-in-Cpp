int originalNumber = Convert.ToInt32(Console.ReadLine());
int n = originalNumber;

int armstrongNumber = 0;

while(n > 0)
{
    int lastDigit = n % 10;
    armstrongNumber += lastDigit * lastDigit * lastDigit;
    n /= 10;
}

Console.WriteLine($"Is the originalNumber armstrong? {isArmstrong(armstrongNumber, originalNumber)}");

bool isArmstrong(int armstrongNumber, int originalNumber)
{
    return armstrongNumber == originalNumber;
}