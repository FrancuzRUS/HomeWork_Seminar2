// Task №1:
// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

// Так как в недели 7 дней, то вероятные значения чисел от 1 до 7 включительно. 

Console.WriteLine("Введие число от 1 до 7 включительно");
int A = int.Parse(Console.ReadLine());

 // if (A == 1) Console.WriteLine("Это будний день "); 
 // if (A == 2) Console.WriteLine("Это будний день "); 
 // if (A == 3) Console.WriteLine("Это будний день "); 
 // if (A == 4) Console.WriteLine("Это будний день "); 
 // if (A == 5) Console.WriteLine("Это будний день "); 


if (A == 6) Console.WriteLine("Это ВЫХОДНОЙ!!! "); 
else if (A == 7) Console.WriteLine("Это ВЫХОДНОЙ!!! "); 

else if (A < 1) Console.WriteLine("Вы ввели число меньше 1, пожалуйста введите число от 1 до 7");
else if (A > 7) Console.WriteLine("Вы ввели число больше 7, пожалуйста введите число от 1 до 7");

else Console.WriteLine("Это будний день");
