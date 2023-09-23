Console.WriteLine("Введите количество элементов массива");
int massiveLength = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[massiveLength];


void GetArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine();
    }
}

string[] CutArray(string[] array)
{
    int newMassiveLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        newMassiveLength++;
    }

    string[] array2 = new string[newMassiveLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    Console.WriteLine("[" + string.Join(" ", array) + "]");
}

GetArray(array1);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(CutArray(array1));
