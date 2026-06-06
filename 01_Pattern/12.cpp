#include <iostream>
using namespace std;

void PrintPattern(int n)
{
    int space = 2 * (n - 1);
    for(int i = 1; i <= n; i++)
    {
        // number
        for(int num = 1; num <= i; num++)
        {
            cout << num;
        }

        // space
        for(int j = 1; j <= space; j++)
        {
           cout << " " ;
        }
        
        // number
        for(int num = i; num >= 1; num--)
        {
            cout << num;
        }

        cout << endl;
        space -= 2;
    }
}

int main()
{
    int n = 4;
    PrintPattern(n);

    return 0;
}