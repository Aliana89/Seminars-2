 //Задача 66: Задайте значения M и N. 
   // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    //M = 1; N = 15 -> 120
   // M = 4; N = 8. -> 30


int InputIntNumber(string message)
{
    int number = 0;
    Console.Write(message);
    number = Convert.ToInt32(Console.ReadLine());

    while (number < 1)
    {
        System.Console.WriteLine("Некорректный ввод!");
        Console.Write(message);
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

int  SumOfElements(int num1, int num2)
{
    int result = num1;
    if (num1 == num2)
        return 1;
    if (num1 > num2)
    {
        num2++;
        result = num2 +  SumOfElements(num2, num1);
        return result;
    }
    else
    {
        num1++;
        result = num1 + SumOfElements(num1, num2);
        return result;
    }
}

int numberOne = InputIntNumber("Введите 1-е число: ");
int numberTwo = InputIntNumber("Введите 2-е число: ");
int sumNumbers = SumOfElements(numberOne, numberTwo);
Console.WriteLine($"Сумма чисел от {numberOne} до {numberTwo} = {sumNumbers}");