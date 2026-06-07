#include <iostream>
using namespace std;

void PrintPattern(int n)
{
    char ch = 'A';
    int start = static_cast<int>(ch);
    for(int i = 0; i < n; i++)
    {
        for (int j = start; j <= start + (n - i - 1) ; j++)
        {
            cout << static_cast<char>(j) << " " ;

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