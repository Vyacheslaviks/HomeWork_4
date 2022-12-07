//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Тело программы

Console.WriteLine("Введите число: ");
int number = InputInt();

Console.WriteLine($"Суммы цифр: {SumNum(number)}");

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
    int count = 0;
    int reserve_num = num;
    int sum = 0;

    while(num != 0)
    {
        num = num / 10;
        count++;
    }

    int[] array = new int[count];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = reserve_num % 10;
        reserve_num /= 10;
    }

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}