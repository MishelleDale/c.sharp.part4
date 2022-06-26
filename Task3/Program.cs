Console.WriteLine("Введите число элементов массива");
int Number = Convert.ToInt32(Console.ReadLine());

double [] Quantity = new double[Number];

double [] FillArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101); // give the bounders to check the results easier
    }
    return array;
}

void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void DifferenceMinMax (double [] array)
{
    double min = array [0]; // take the min elevent that is the fisrt in a raw
    double max = array [0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min) min = array[i];
        if (array [i] > max) max = array[i];
        diff = max - min;
    }
    Console.WriteLine(diff);
}

double [] arr = FillArray(Quantity);
PrintArray(arr);
Console.WriteLine();
DifferenceMinMax(arr);
