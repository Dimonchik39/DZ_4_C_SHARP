// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.Write("Введите число: ");
int dig = Convert.ToInt32(Console.ReadLine());

int Summ(int dig1)

{
    int dig2 = 0;
    int summ = 0;
    for (int i = 0;dig1 > 0; i++)
    {
        dig2 = dig1 % 10;
        summ = summ + dig2;
        dig1 = dig1 / 10;
    }
    return summ;
}

int summ = Summ(dig);
Console.WriteLine($"Сумма цифр заданного числа: {summ}");