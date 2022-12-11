/*  **Задача 29**
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

int[] array = new int[8];
char[] arrayUTF8 = new char[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine($"");
for (int j = 0; j < arrayUTF8.Length; j++)
{
    int b;
    b = new Random().Next(33,127);
    char cb = Convert.ToChar(b);
    arrayUTF8[j] = cb;
    Console.Write($"{arrayUTF8[j]} ");
}