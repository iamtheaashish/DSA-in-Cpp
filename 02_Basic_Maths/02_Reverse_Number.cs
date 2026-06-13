Console.WriteLine($"\nCount of digit is equal to {count(7780)}.");

int count(int n)
{
    int cnt = 0;
    while (n > 0)
    {
        int lastDigit = n % 10;
        Console.Write(lastDigit);
        cnt++;
        n /= 10;
    }
    return cnt;
}