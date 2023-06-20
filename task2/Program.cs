// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int CountDigits(int num)
{
    int lengthNum =0;
    while (num > 0)
    {
        num/=10;

    }
}

int number = Prompt("Введите число: ");

/* int lengthnumber(int arg)     // Определяет длинну числа
{
    int temporarynunber = arg;
    int lengthnunber = 0;
    while(temporarynunber > 0)
    {
        temporarynunber /= 10;
        lengthnunber += 1;
    }
    return lengthnunber;
}

int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int number2 = Convert.ToInt32(number);
    return number2;
}

int number2 = redin($"Введите число");
int c = lengthnumber(number2);



Console.WriteLine(c); */