﻿/*Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (99 < a & a <= 999)
{
    Console.WriteLine($"Вторая цифра числа равна  {a/10%10}");
}


/*Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 99)
{
    Console.WriteLine($"Третья цифра числа равна  {b/100}");
    
}
else
{
    Console.WriteLine($"В введенном числе нет третьей цифры, оно меньше 100  {b/10%10}");
}


/*
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
if (0 < c & c < 6 )
{
    Console.WriteLine("Это будний день");
}
if (5 < c & c < 8 )
{
    Console.WriteLine("Это выходной день");
}
if (7 < c | c < 1 )
{
    Console.WriteLine("Такого дня не существует");
}
