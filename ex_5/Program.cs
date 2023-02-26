﻿void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;   
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Какое число вы хотите найти в массиве? ");
int MyChoice = int.Parse(Console.ReadLine());
int pos = Index0f(array, MyChoice);
if (pos == -1)
{
    Console.WriteLine("Sorry, такого числа не найдено. ");
}
else
{
    Console.WriteLine($"Число на позиции: {pos}");
}