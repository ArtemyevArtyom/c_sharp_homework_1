/*
 Напишите программу, которая на вход принимает два числа и  
 выдаёт, какое большее, а какое меньшее.
*/
Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
if (NumberA > NumberB) Console.WriteLine($"Число {NumberA} больше, чем число {NumberB}");
else if (NumberA < NumberB) Console.WriteLine($"Число {NumberB} больше, чем число {NumberA}");
else if (NumberA == NumberB) Console.WriteLine($"Числа равны");