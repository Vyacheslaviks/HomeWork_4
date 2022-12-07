//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Тело программы

Console.WriteLine("Введите число: ");
int number = InputInt();



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

int SumNum(int num)
{
    int[] array = new int[]
}