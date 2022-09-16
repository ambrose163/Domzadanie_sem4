//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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
    Console.WriteLine($"Какое число будем возводить в степень?");
    int numA = NumChecker();

    Console.WriteLine($"И в какую же степень мне возвести {numA}");
    int numB = NumChecker();

    double result = numA;//= Math.Pow(numA, numB)

    for (int i = 0; i < numB - 1; i++)
    {
        result *= result;
    }

    Console.Write($"Отлично! {numA} в степень {numB} равно {result}");

    //Зацикливание программы
    Console.WriteLine();
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
}