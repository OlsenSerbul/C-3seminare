// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
string FindPol(int number1, int number2, int number4, int number5)
{
    string answer = "";
    if (number1 == number5 && number2 == number4)
    {
       answer = "TRUE";
    }
    else
    {
       answer = "FALSE";
    }
    return answer;
}
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
   Console.WriteLine("FALSE");
}
if (number >= 10000 && number < 100000)
    {
      int number1 = number % 10;
      int number2 = (number /10) % 10;
      int number3 = (number /100) % 10;
      int number4 = (number /1000) % 10;
      int number5 = number /10000;
      string answer = FindPol(number1,number2,number4,number5);
      Console.WriteLine(answer);
    }
else  
    Console.WriteLine("Вы ввели не пятизначное число");