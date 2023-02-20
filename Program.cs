//Homework2

//Task1. Напишите программу, 
//которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int GetSecondNum(int threedegreenumber){
  int result = (threedegreenumber/10)%10;
  return result;
}

Console.Write("Input number of three degree: ");
int numbertowork=Convert.ToInt32(Console.ReadLine());
if (numbertowork<100|numbertowork>=1000){Console.WriteLine("It's not number of three degrees");}
else
{
  Console.Write($"We modified your number {numbertowork} into {GetSecondNum(numbertowork)}");
}
*/

//Task2.  Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

void ThirdNumber(int givenNumber)
{
  int result = (givenNumber /100)%10;
  if (result == 0){Console.WriteLine("No such number");}
  else {Console.WriteLine($"The third number is {result}");};
}
Console.Write("Input numbere: ");
int numbertowork=Convert.ToInt32(Console.ReadLine());
ThirdNumber(numbertowork);