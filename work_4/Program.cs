// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

for (i = 1; i <= N; i++)
{
    int number = i * i * i;
    if (number % 2 == 0)
    {
        Console.WriteLine($" {i} ^ 3 = {number} ");
    }
}