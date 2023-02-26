int[] array = {1, 22, 333, 43, 544, 644, 74, 84, 91};
int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Наше число на позиции: {index}");
    }
    index += 1;
}