Console.Clear();

﻿int Número1, Número2, Número3;





Console.WriteLine("--- MAIOR DE TRÊS---");

Console.WriteLine("Olá, digite 3 números e falaremos qual é o maior.");

Console.Write("digite um n° INTEIRO: ");

Número1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite outro n° INTEIRO: ");

Número3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite mais um n° INTEIRO: ");

Número2 = Convert.ToInt32(Console.ReadLine());

if (Número1 >= Número2 && Número1 >= Número3)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"o maior número é: {Número1}");


}

else if (Número2 >= Número1 && Número2 >= Número3)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"o maior número é: {Número2}");


}
else if (Número3 >= Número1 && Número3 >= Número2)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"o maior número é: {Número3}");


}
Console.ResetColor();