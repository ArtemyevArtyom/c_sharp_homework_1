/*
 Напишите программу, которая на вход принимает три числа и  
 выдаёт максимальное из этих чисел.
*/

Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int NumberC = Convert.ToInt32(Console.ReadLine());
if (NumberA > NumberB)
    {
        if (NumberA > NumberC)  Console.WriteLine($"Число {NumberA} - максимальное");
        else  Console.WriteLine($"Число {NumberC} - максимальное");
    }

else if (NumberB > NumberA) 
    {
        if (NumberB > NumberC)  Console.WriteLine($"Число {NumberB} - максимальное");
        else  Console.WriteLine($"Число {NumberC} - максимальное");
    }
