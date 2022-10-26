// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем Х не равно 0 и Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка.
int GetPointArea(int coordX, int coordY)
{
    int numberArea = 0;
    if (coordX > 0 && coordY > 0)
    {
        numberArea = 1;
    }
    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2;
    }
    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;
    }
    if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;
    }
    return numberArea;
}
Console.WriteLine("Введите X:  ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

int numberArea =  GetPointArea(X , Y);
Console.WriteLine(numberArea);