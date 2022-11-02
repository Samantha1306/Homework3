// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Сколько измерений в пространстве? Введите натуральное число.");
int space = Convert.ToInt32(Console.ReadLine());
int i = 1;
double d = 0;
while (i <= space)
{
    Console.Write($"Введите координату {i} точки 1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату {i} точки 2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    d = Math.Sqrt(Math.Pow(d, 2) + (Math.Pow(x2 - x1, 2)));
    i = i + 1;
}
Console.WriteLine($"Расстояние между двумя точками в {space}D пространстве равно {d}.");
