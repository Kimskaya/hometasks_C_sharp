// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int GetUserNumber (string message)
{
    Console.WriteLine(message);
    int Coodrdinates = int.Parse(Console.ReadLine()!);
    return Coodrdinates;
}
int a1 = GetUserNumber("Input a1: ");
int b1 = GetUserNumber("Input b1: ");
int c1 = GetUserNumber("Input c1: ");
int a2 = GetUserNumber("Input a2: ");
int b2 = GetUserNumber("Input b2: ");
int c2 = GetUserNumber("Input c2: ");

double sqrt = Math.Sqrt((a2-a1)*(a2-a1)+(b2-b1)*(b2-b1)+(c2-c1)*(c2-c1));
Console.WriteLine($" the length is {sqrt}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int GetUserNumber (string message)
{
    Console.WriteLine(message);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}
void CubeNumber (int Number)
{
    for (int N = 1; N < Number+1; N=N+1)
    {
        int Cube = N*N*N;
        if (N<Number)
        {
            Console.Write($"  {Cube}, ");
        }
        else 
        {
            Console.Write($"  {Cube}");
        }
    }
}
int N = GetUserNumber("Input number");
CubeNumber(N);


// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет   12821 -> да   23432 -> да

int Get5DigitNumber (string message)
{
    Console.WriteLine(message);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}
int Number = Get5DigitNumber("Input 5 digit number");
int FirstHalf = Number/1000;
int SecondHalf = Number%100;
int First = FirstHalf/10;
int Second = FirstHalf%10;
int Fifth = SecondHalf%10;
int Forth = SecondHalf/10;

if (First == Fifth && Second == Forth)
{
    Console.WriteLine($" Number {Number} is a palindrome");
}
else 
{
    Console.WriteLine($" Number {Number} is not a palindrome");
}
