// Напишите программу, которая принимает на входе число (N) 
// и выдает таблицу квадратов чисел от 1 до N.

void FindSquares( int N )
{
    int squareN = 0;
    for (int i = 1; i <= N ; i++ )
    {
        squareN = i * i;
        Console.WriteLine(squareN);
    }
}

Console.WriteLine("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());


FindSquares( N );
