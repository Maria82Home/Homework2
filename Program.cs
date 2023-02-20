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
/*
void ThirdNumber(int givenNumber)
{  
  while(givenNumber>=1000){givenNumber=givenNumber/10;};
  if (givenNumber < 100){Console.WriteLine("No such number");}
  else {Console.WriteLine($"The third number is {givenNumber%10}");}
}
Console.Write("Input number: ");
int numbertowork=Convert.ToInt32(Console.ReadLine());
ThirdNumber(numbertowork);
*/

//Task3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

bool WhatWeekDay(int daynumber)
{
 return(daynumber==6|daynumber==7);
}

Console.Write("Input number of the weekday: ");
int dayfromuser=Convert.ToInt32(Console.ReadLine());
//Console.Write(dayfromuser);
if(dayfromuser<1|dayfromuser>7){Console.WriteLine("Number must be from 1 to 7");}
else {if(WhatWeekDay(dayfromuser)){Console.WriteLine("It's a weekend!!!");}
else {Console.WriteLine("It's not a weekend");};
}