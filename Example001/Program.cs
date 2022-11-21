/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
вторую цифру этого числа.*/

Console.Write("Enter For Number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string SecondNumber = Convert.ToString(Number);
Console.WriteLine("The second digit of this number: "+SecondNumber[1]);
