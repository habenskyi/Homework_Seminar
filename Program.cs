﻿// Задача №2 Напишите программу, которая на вход принимает два числа и выдает какое чтсло больше а какое меньшее

Console.WriteLine("Введите первое число: ");
int number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_B = Convert.ToInt32(Console.ReadLine());
if (number_A > number_B)
{
    Console.WriteLine("Первое число " + number_A + " больше чем второе " + number_B);
}
else
{
    Console.WriteLine("Второе число " + number_B + " больше чем первое " + number_A);
}