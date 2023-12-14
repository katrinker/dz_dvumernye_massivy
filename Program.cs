﻿//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.


int [,] array = new int[5,3];

void CreateArray()
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i,j] = new Random().Next(1,10);
}
}
}

void PrintArray()
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
System.Console.Write(array[i,j] +" ");
}
System.Console.WriteLine();
}
System.Console.WriteLine();
}

int FindEl()
{
Console.WriteLine("Введите позицию столбца: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию строки: ");
int j = Convert.ToInt32(Console.ReadLine());

if(i<=array.GetLength(0) && j<=array.GetLength(1))
{
    Console.WriteLine(array[i,j]);
}
else 
{
    Console.WriteLine("Элемент не существует");
}
return i;
}

CreateArray();
PrintArray();
FindEl();