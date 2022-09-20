/*
 Напишите программу, которая на вход принимает число и 
 выдаёт, является ли оно чётным (делится ли оно на два без остатка).
*/

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0 )  Console.WriteLine($"Число {Number} - чётное");
else Console.WriteLine($"Число {Number} - нечётное");