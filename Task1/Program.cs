Console.WriteLine("Введите количество элементов массива");
int Quantaty = Convert.ToInt32(Console.ReadLine());
int[] Quantity = new int[Quantaty]; // Create new array with a given number of elements

int[] FillArray (int[] array)
{
    int length = Quantaty;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000); // Numbers with 3 digits
    }
    return array;
    
}
void PrintArray (int [] array)
{   
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void NumberOfEven (int [] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) 
        {
        number = number + 1;
        }
    }
    Console.Write(number); // Command should be out of "for"
}


int[] arr = FillArray(Quantity); // The name of new array in line 3

PrintArray(arr);
Console.WriteLine(); // Make a line between array and the sum
NumberOfEven(arr);