//Задача *: Напишите программу, которая из массива случайных чисел. Ищет разницу между максимумом и минимумом 
//[1, 3, 5, 6, 6, 4] -> 5

int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);

    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}


(in, int) MinMax(int[]numbers)
{
for (int i=0; i < numbers.Length; i++)
{
  if (min> numbers[i])
  {
    min = numbers[i];
  }
  if (max<numbers[i])
  {
    max = numbers[i];
  }
}
return(min,max);
}
(int min,int max) = MinMax(numbers);
int min = numbers[0];
int max = numbers[0];

int[] numbers = GenerateArray(6, 0, 10);
PrintArray(numbers);

System.Console.WriteLine($"\n{min} - минимальный элемент массива, {max} - максимальный элемент массива. Разница = {max-min}");

/*   кому  Все
//Задача *: Напишите программу, которая из массива случайных чисел. Ищет разницу между максимумом и минимумом 
//[1, 3, 5, 6, 6, 4] -> 5

int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArrey(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
}

int[] number = GenerateArray(6, 0, 10);
PrintArrey(number);

int min = number[0];
int max = number[0];

for(int index = 0; index < number.Length; index++)
{
    if(min > number[index])
    {
        min = number[index];
    }
    if(max < number[index])
    {
        max = number[index];
    }
}

int Difference = max - min;

System.Console.WriteLine($"\n{min} - минимальный элемент массива, {max} - максимальный элемент массива. Разница = {max-min}");

Дмитрий 23:38
//Задача *: Напишите программу, которая из массива случайных чисел. Ищет разницу между максимумом и минимумом 
//[1, 3, 5, 6, 6, 4] -> 5

int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArrey(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

(int, int) MinMax(int[] number)
{
    int min = number[0];
    int max = number[0];

    for (int index = 0; index < number.Length; index++)
    {
        if (min > number[index])
        {
            min = number[index];
        }
        if (max < number[index])
        {
            max = number[index];
        }
    }
    return (max, min);
}

int[] number = GenerateArray(6, 0, 10);
PrintArrey(number);

(int max, int min) = MinMax(number);


int Difference = max - min;

System.Console.WriteLine($"\n{min} - минимальный элемент массива, {max} - максимальный элемент массива. Разница = {max - min}"); */