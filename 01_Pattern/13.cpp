#include <iostream>
using namespace std;

void PrintPattern(int n)
{
    int start = 1;
    for(int i = 0; i<n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            cout << start << " " ;
            start += 1;
        }
        cout << endl;
    }
}

int main()
{
    int n = 5;
    PrintPattern(n);

    return 0;
}