// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Ввод числа
int InputInt(string promt)  
{
    System.Console.WriteLine($"{promt} ->"); // Вывод приглашения на экран
    return Convert.ToInt32(Console.ReadLine());  // Ввод с консоли с экрана
}
// Проверят введеное число что оно больше 0
bool ValidatePositive(int value)
{
    if(value <=0) // Сама проверка
    {
        System.Console.WriteLine("Введите положительное число"); // Выводит ошибку
        return false; // признак неправильного ввода
    }
    return true; //  Можно работать дальше
}

int SumNubers(int value) // Подсчет суммы до параметка value
{
    int sum = 0; // Будем здесь накапливать сумму
    for(int i =1; i<=value; i++) //Цикл выччесления суммы
    {
        sum +=i;        // Накапливаем сумму
    }
    return sum;

}

// Подсчет суммы Гауссом
int SumGaussNumbers(int value)
{
    return(1+value)* value/2;
}

int value = InputInt("Введите число"); // Вызов функции(ввод числа)
if(ValidatePositive(value))     // проверка на положительное число
{
    int sum = SumNubers(value);
    System.Console.WriteLine($"Сумма чисел от 1 до {value} = {sum}");
    System.Console.WriteLine($"Сумма чисел по Гауссу от 1 до {value} = {SumGaussNumbers(value)}");
}
