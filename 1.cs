using static System.Console;
Clear();

WriteLine("Введите длинны сторон треугольника(через пробел): ");

int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

WriteLine(Triangle(array) ? "С такими сторонами может существовать треугольник" : "С такими сторонами НЕ может существовать треугольник");

bool Triangle(int[] arra)
{
    return (arra[0] + arra[1] > arra[2] && arra[1] + arra[2] > arra[0] && arra[0] + arra[2] > arra[1]);

}