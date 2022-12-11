/*  **Задача 27**

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */

int a;
Console.WriteLine("Enter a number: ");
int.TryParse(Console.ReadLine()!, out a);
if (a<0)
{
    a=-a;
}
int i;
int sum=0;
for (i=0; i>=0; i=a-1)
{
    sum=sum + a % 10;
    a=a/10;
}
Console.WriteLine($"Answer: {sum} ");