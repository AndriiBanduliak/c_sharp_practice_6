using static System.Console;
Clear();

WriteLine("Укажите количество чисел последовательности Фиббоначчи, которые нужно вывести: ");
int number = Convert.ToInt32(ReadLine());
int[] result = Fibonacci(number);
WriteLine($"[{String.Join(", ", result)}]");

int[] Fibonacci (int n)
{
    int[] arr = new int[n];
    arr[0] = 0;
    arr[1] = 1;
    for(int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}