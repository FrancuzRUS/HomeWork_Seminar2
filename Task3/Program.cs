// Task №3
// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Укажите номер четверти (от 1 до 4) и мы увидим возможный диапозон значений для X и Y ");

int A = int.Parse(Console.ReadLine());

if (A == 1) Console.WriteLine("Для первой четверти Х > 0; Y > 0. ");
else if (A == 2) Console.WriteLine("Для второй четверти X < 0; Y > 0");
else if (A == 3) Console.WriteLine("Для третьей четверти X < 0; Y < 0"); 
else if (A ==4) Console.WriteLine("Для четвертой четверти X > 0; Y < 0");

else if (A > 4) Console.WriteLine("Вы ввели число больше заданого диапозона, повторите попытку. ");
else if (A < 1) Console.WriteLine("Вы ввели число меньше заданного диапозона, повторите попытку"); 


