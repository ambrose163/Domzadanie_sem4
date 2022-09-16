//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int num)
{
    int[] array = new int[num];
    Console.WriteLine($"Наш массив из {num} случайных чисел:");
    return array;
}

void FillArray(int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0, 10001);
    }
}

void PrintArray(int[] array)
{

    foreach (int elem in array)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}

void FindSome(int[] array)
{
    int count1 = 0;
    int count2 = 0;
    foreach (int elem in array)
    {
        if (elem % 2 == 0)
        {
            count1++;
        }
        else count2++;
    }
    Console.WriteLine();
    Console.WriteLine($"В массиве {count1} четных и {count2} нечетных чисел");
}

void FindAvg(int[] array)
{
    double avg = 0;
    foreach (int elem in array)
    {
        avg += elem;
    }
    avg /= array.Length;

    Console.WriteLine($"Среднее арифметическое -> {avg}");
}

void FindMax(int[] array)
{
    double max = array[0];
    foreach (int elem in array)
    {
        if (max < elem)
        { max = elem; }
    }

    Console.WriteLine($"Самый большой элемент -> {max}");
}

void CheckArray(int[] array)
{
    string msg = "";
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            msg = "Числа не по возрастанию(";
            Console.WriteLine($"{msg}");
            return;
        }
        else
        {
            msg = "Числа по порядку!";
        }

    }

    Console.WriteLine($"{msg}");
}

while (true)
{
    Console.Write("Введите размер массива. ");

    bool numBool = false;
    int num = 0;

    while (!numBool)
    {
        Console.WriteLine("Число должно быть целым.");
        numBool = int.TryParse(Console.ReadLine()!, out num);
    }


    int[] array = CreateArray(num);
    FillArray(array);
    PrintArray(array);
    FindSome(array);
    FindAvg(array);
    FindMax(array);
    CheckArray(array);


    Console.WriteLine();
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
    Console.Clear();
}