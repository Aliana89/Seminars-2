 //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    //Даны два неотрицательных числа m и n.
  //  m = 2, n = 3 -> A(m,n) = 9
   // m = 3, n = 2 -> A(m,n) = 29

int InputIntNumber(string message)
{
    int number = 0;
    Console.Write(message);
    number = Convert.ToInt32(Console.ReadLine());

    while (number < 0)
    {
        System.Console.WriteLine("Некорректный ввод, число отрицательное!");
        Console.Write(message);
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

int AckermannFunc(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0 && num1 > 0) return AckermannFunc(num1 - 1, 1);
    else return (AckermannFunc(num1 - 1, AckermannFunc(num1, num2 - 1)));
}

int numberOne = InputIntNumber("Введите 1-е число: ");
int numberTwo = InputIntNumber("Введите 2-е число: ");
int ackermannNumber = AckermannFunc(numberOne, numberTwo);
Console.WriteLine(ackermannNumber);