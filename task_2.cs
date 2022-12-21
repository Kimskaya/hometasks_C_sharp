// task_2. Program that takes 2 numbers and shows the biggest
Console.WriteLine("Input number");
int numberX = int.Parse  (Console.ReadLine()!);

Console.WriteLine("Input number");
int numberY = int.Parse (Console.ReadLine()!);
if (numberX>numberY)

Console.WriteLine(numberX+ " is max");
else
Console.WriteLine(numberY+" is max");

//task_4. Program takes 3 numbers and outputs the biggest
Console.WriteLine("Input number");
int number1 = int.Parse  (Console.ReadLine()!);

Console.WriteLine("Input number");
int number2 = int.Parse (Console.ReadLine()!);

Console.WriteLine("input number");
int number3 = int.Parse(Console.ReadLine()!);
if (number1>number2)

Console.WriteLine(number1+ " is max");
else if (number2 > number3)
Console.WriteLine(number2+" is max");
else 
Console.WriteLine(number3+" is max");

// task_6 program takes a number and outputs 
//if the number is ordinary

Console.WriteLine("Input number");
int numberA = int.Parse  (Console.ReadLine()!);
if (numberA%2==0)
Console.WriteLine(numberA+" is an ordinary number");
else 
Console.WriteLine(numberA+ " is an odd number");
//task_8 program takes a number 
//and shows all the ordinary numbers from 1 to number

Console.WriteLine("Input number");
int numberOrd = int.Parse (Console.ReadLine()!);

while(numberOrd>=1)

if (numberOrd%2==0)
    Console.WriteLine(numberOrd);
    numberOrd = numberOrd-2;
    else 
numberOrd = numberOrd-1;
Console.WriteLine("NumberOrd");
