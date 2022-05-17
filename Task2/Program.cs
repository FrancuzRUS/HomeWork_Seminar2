// Task №2
// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число А "); 
int A = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите число B "); 
int B = int.Parse(Console.ReadLine()); 

if (A == B*B) Console.WriteLine("Число A является квадратом числа B ");
else if (B == A*A) Console.WriteLine("Число B являетя квадратом числа A ");
else Console.WriteLine("Числа А и В не являются квадратами друг для друга");

    




