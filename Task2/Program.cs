Console.WriteLine("Введите число элементов в массиве");
int Number = Convert.ToInt32(Console.ReadLine());

int[] Quantity = new int[Number];

int [] FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101); // Create the bounders of elements in array
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SumOfElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 ! == 1)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine(sum);
}

int[] arr = FillArray(Quantity);
PrintArray(arr);
Console.WriteLine();
SumOfElements(arr);