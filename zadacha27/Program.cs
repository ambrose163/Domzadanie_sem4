//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumChecker() //метод проверки на ввод числа
{
    while (true)
    {
        Console.WriteLine("Введите число для подолжения, или *q* чтоб выйти");
        string num = Console.ReadLine()!;

        if (num == "q")
        {
            Console.WriteLine($"Вы не ввели число");
            System.Environment.Exit(0); //завершение программы на любом этапе
            return -1;
        }
        else if (int.TryParse(num, out int isItNum))
            return isItNum;
    }
}

while (true) // Зацикливание программы
{
    Console.WriteLine("Какое число будем раскладывать? ");

    string num = NumChecker().ToString();
    int sum = 0;

    Console.Write($"Сумма цифр в {num} -> ");

    foreach (char a in num)
    {
        sum += a - '0';
    }

    for (int i = 0; i < num.Length; i++) // не понял как бы можно было тут использовать String.Join, пришлось напистаь такой цикл
    {
        if (i < num.Length - 1)
        {
            Console.Write($"{num[i]} + ");
        }
        else
        {
            Console.Write($"{num[i]} = ");
        }
    }

    Console.WriteLine($"{sum}");

    //Зацикливание программы
    Console.WriteLine();
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
}