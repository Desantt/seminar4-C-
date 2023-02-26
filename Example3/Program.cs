// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
//Ввод числа

int InputInt(string promt)
{
    System.Console.WriteLine($"{promt} ->"); // Вывод приглашения на экран
    return Convert.ToInt32(Console.ReadLine());  // Ввод с консоли с экрана
}
int Factorial(int number)   //метод нахождения факториала
{
    int result =1;      // в переменную кладем результат
    for(int i =1; i<= number; i++)  //цикл вычесления будет работать пока i счетчик не будет больше числа
    {
        result = result * i; // вычесление факториала
    }
    return result;  // возврат результаа метода
}
int userNumber = InputInt("Введите число"); // вызов InputInt
System.Console.WriteLine($"Факториал числа {userNumber} = {Factorial(userNumber)}"); // вывод информации пользователю о факториале числа