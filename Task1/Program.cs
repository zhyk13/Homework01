﻿//Задача на вход принимает два числа и выводит, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    {
        Console.WriteLine($"Первое число {number1} больше второго числа {number2}");
    }
else 
    {
        if (number2 > number1)
        {
            Console.WriteLine($"Второе число {number2} больше первого числа {number1}");
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
    }