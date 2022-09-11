// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void Enter(int[] array2)
{
    int count = array2.Length;
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array2[i] = rnd.Next(0, 2);
    }
}

void Withdraw(int[] array2)
{
    int count = array2.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == 0) Console.Write("[");
        if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

Enter(array);
Withdraw(array);