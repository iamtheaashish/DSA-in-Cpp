#include <iostream>
using namespace std;

void PrintPattern(int n)
{
    char ch = 'A';
    int start = static_cast<int>(ch);
    for(int i = 0; i < 5; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            cout << static_cast<char>(start + j) << " " ;
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