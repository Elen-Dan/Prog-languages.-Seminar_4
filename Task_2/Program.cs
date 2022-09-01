/*
Задача 2: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
(для получения цифр числа операцию приведения числа к строке не использовать)
*/

Console.Clear();

// конвертация string в int
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Number = ReadInt("Введите число: ");
int tempNum = Number;
int Sum = 0; //сумма требуемых цифр в числе
int Ostatok = 0; // остаток введенного Числа (number) от деления на 10

while (tempNum != 0) {
Ostatok = tempNum % 10;
if(Ostatok == 0)
   Console.WriteLine("Как еще бороться с делением на ноль в 24-й строке???");          
else if(tempNum % Ostatok == 0) 
   {
   Sum = Sum + Ostatok;         
   }
tempNum = tempNum / 10;

}         
Console.WriteLine("Сумма цифр делителей числа: " + Sum);
Console.WriteLine(2 % 2);
