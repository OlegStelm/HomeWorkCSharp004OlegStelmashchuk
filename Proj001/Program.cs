/*  **Задача 25**
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

int a;
int b;

Console.WriteLine("Enter a number A: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine("Enter a number B: ");
int.TryParse(Console.ReadLine()!, out b);

int i;
int b=1;

for (i=1; i<=a; i++)
{
    b = i*i*i;
    Console.WriteLine($"{b} ");
}