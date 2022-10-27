// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
void FindCube ( int N )
{
    int cubeN = 0;
    for (int i = 1; i <= N ; i++ )
    {
        cubeN = i * i * i;
        Console.WriteLine(cubeN);
    }
}

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());


FindCube( N );
