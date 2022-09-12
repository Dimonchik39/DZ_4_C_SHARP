// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число A: ");
int digitA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int digitB = Convert.ToInt32(Console.ReadLine());

int Degree (int digA, int digB)
{
    int deg = 1;
    for (int i = 0; i < digB; i++)
    {
        deg = deg * digA;
    }
    return deg;
}

int degree = Degree(digitA, digitB);
Console.WriteLine($"{digitA} в {digitB}-й степени = {degree}");