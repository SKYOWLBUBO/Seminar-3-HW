// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.WriteLine(message); // выводит сообщение в консоли 
    return int.Parse(Console.ReadLine()); // считывает текст с консоли и преобразует в целочисленное значение
}

int N = Prompt("Введите натуральное число: ");
int count = 1; // счетчик
while (count <= N ) // условие
{
    System.Console.WriteLine(count * count); // возведение в квадрат 
    count++; // увеличение счетчика 
}

for (int i = 1; i <=N; i++)
{
    System.Console.WriteLine(Math.Pow(i,2)); // возведение во вторую степень 
}