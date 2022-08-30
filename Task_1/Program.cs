/*
Задача 1:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать 
функцию Math.Pow()
3, 5 -> 243
2, 4 -> 16
*/
Console.Clear();

// конвертация string в int
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int number = ReadInt("Введите число: ");
int power = ReadInt("Введите степень числа: ");
int result = 1; // сюда помещаем результат умножения

for (int i = 0; i < power; i++) 
    {
        result = result * number;
    }

Console.WriteLine("Результат возведения числа " + number + " в степень " + power + " равен: " + result);

