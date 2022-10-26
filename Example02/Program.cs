// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)
string FindCoord(int number)
{
    string diap = "";
    if (number == 1)
    {
        diap = "X > 0, Y > 0";
    }
    if (number == 2)
    {
        diap = "X < 0, Y > 0";
    }
    if (number == 3)
    {
       diap = "X < 0, Y < 0";
    }
    if (number == 4)
    {
       diap =  "X > 0, Y < 0";
    }
    if (number == 0)
    {
        diap =  "X = 0, Y = 0";
    }
     
    return diap; 

}
Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0 || number > 4) Console.WriteLine("Такой четверти в системе координат нет");
string diap = FindCoord(number);
Console.WriteLine(diap);
