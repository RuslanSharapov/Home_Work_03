// Найти кубы чисел от 1 до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
for (i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} ^ 3 = " + i * i * i);
}