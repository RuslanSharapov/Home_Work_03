// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int number = 1;
for (int i = 1; i <= N; i++) // если N не включено,то i < N
{
    number *= i;
}
 
Console.WriteLine("Произведение: " + number);