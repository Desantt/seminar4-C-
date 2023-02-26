// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length ; i++)
    {
        array[rnd.Next(0, array.Length)] = 1;
    }
}

void PrintArray(int[] array)
{

    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);

    }
}

int InputSizeArray(string msg) // ввод числа
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());

}

int SizeArray = InputSizeArray("Введите число");
int[] Massiv = new int[SizeArray];
FillArray(Massiv);
PrintArray(Massiv);