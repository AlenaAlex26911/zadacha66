// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

void Summa(int first, int second, int sum)
{
    if (first > second)
    {
        Console.WriteLine($"Сумма чисел от {number} до {secondNumber} равна {sum}");
        return;
    }
    sum = sum + (first++);
    Summa(first, second, sum);
}

Summa(number, secondNumber, 0);