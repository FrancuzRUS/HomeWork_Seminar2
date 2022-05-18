
// Task №4
// Найти расстояние между точками в пространстве 2D/3D

// Решать задачу будем через формулу нахождения гипотенузы. 

//Задаем координаты для точек
Console.Write("Введите значение Х, для точки № 1:   ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение Y, для точки № 1:   ");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("Введите значение Х, для точки № 2:   ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение Y, для точки № 2:   ");
int Y2 = int.Parse(Console.ReadLine());

//блок ввода необходимых переменных 
double A = 0; 
double B = 0;
double C = 0; 

//Блок условий расчета отрезков
if (X1 > X2) A = X1 - X2; 
else if (X1 < X2) A = X2 - X1;
Console.Write("Значение отрезка А = ");
Console.WriteLine(A);

if (Y1 > Y2) B = Y1 - Y2; 
else if (Y1 < Y2) B = Y2 - Y1; 
Console.Write("Значение отрезка B = ");
Console.WriteLine(B);

if (X1 == X2) C = B;
if (Y1 == Y2) C = A;

else C = Math.Sqrt(A*A+B*B);
Console.Write("Значение отрезка C = ");
Console.WriteLine(C);



