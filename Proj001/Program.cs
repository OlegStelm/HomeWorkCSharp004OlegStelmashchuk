/*  **Задача 25**
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

double a;
double b;

Console.WriteLine("Enter a number A: ");
double.TryParse(Console.ReadLine()!, out a);
Console.WriteLine("Enter a number B: ");
double.TryParse(Console.ReadLine()!, out b);

int i;
double exp;

if (b==0)
{
     if (a==0)
     {
          Console.WriteLine($"1 or 0, I'm not a PhD!");
     }
     else
     {
          exp=1;
          Console.WriteLine($"Answer: {exp} ");
     }
}
if (b<0)
{
     if (a==0)
     {
          exp=0;
     }
     else
     {
          exp=1/a;
          for (i=1; i<b*-1; i++)
          {
               exp =exp*(1/a);
          }
     }
     Console.WriteLine($"Answer: {exp} ");
}
if (b>0)
{
     exp=a;
     for (i=1; i<b; i++)
     {
          exp=exp*a;
     }
     Console.WriteLine($"Answer: {exp} ");
}