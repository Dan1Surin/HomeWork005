﻿// Урок 6. Одномерные массивы. Продолжение
// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 45: Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.

// Домашняя работа:

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается
// при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Задача 43: Напишите программу, которая найдёт точку пересечения двух
//  прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] RandomArray(int size, int lRange, int rRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(lRange, rRange + 1); //[lR,rR)
    }
    return array;
}

void reverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++) // достанточно пройти массив до середины
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
}

int[] Array = RandomArray(5,0,9);
Console.WriteLine(string.Join("|",Array));
reverseArray(Array);
Console.WriteLine(string.Join("|",Array));
