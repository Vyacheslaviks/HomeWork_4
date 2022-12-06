//Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()

//Тело программы

Console.WriteLine("Введите первое число:");
int A = InputInt();
Console.WriteLine("Введите второе число: ");
int B = InputInt();

double result = MyPow(A, B);

Console.WriteLine($"Результат: {result}");

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

double MyPow(int A, int B)
{
    double result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }

    return result;
}