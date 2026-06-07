#include <iostream>
using namespace std;

void PrintPattern(int n)
{
    char ch {'A'};
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            cout << ch << " ";
        }
        cout << endl;
        ch += 1;
    }
}

int main()
{
    int n = 5;
    PrintPattern(n);

    return 0;
}