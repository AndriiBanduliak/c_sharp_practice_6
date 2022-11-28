using static System.Console;
Clear();

string Doubled(int X)
{
    string result = string.Empty;
    while (X != 0)
    {
        int temp = X % 2;
        X = X / 2;
        result = temp + result;
    }
    return result;
}

Write("Введите число в 10 системе: ");
int X = Convert.ToInt32(ReadLine());
string Result = Doubled(X);
WriteLine($"В двоичной системе это будет: " + Result);
