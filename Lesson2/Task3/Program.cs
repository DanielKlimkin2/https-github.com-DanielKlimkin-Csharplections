﻿// Создать целочисленный массив на 10 элементов и заполнить его произвольными числами. 
// Вывести на экран чётные элементы массива.

// Пример 1

// Массив: [1 5 4 6 9 3 2 5 4 1]
// Чётные: 4 6 2 4

// Пример 2

// Массив: [9 5 1 7 15 36 3 1 1 7]
// Чётные: 36

// Этапы решения:

// 1. Создание массива из 10 чисел
// 2. Проход по элементам
// 3. Проверка каждого элемента на четность
// 4. Вывод подходящего элемента

// int n = 10;
int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}