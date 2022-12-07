//Написать программу, которая задаёт массив из 8ми элементов и выводит его на экран

//Тело программы

OutArray(InputArray());


//Методы

int InputInt()
{
    bool isParse = int.TryParse(Console.ReadLine(), out int number);

    if (isParse)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение!");
        return -1;
    }
}

int[] InputArray()
{
    int[] array = new int [8];

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = InputInt();
    }

    return array;
}

void OutArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}