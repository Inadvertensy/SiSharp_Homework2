// Задача 10: Напишите программу, которая принимает на 
//вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Please enter three digit number");
int number=Convert.ToInt32(Console.ReadLine());

//if (ThrowResult >= 5 && ThrowResult <= 9)

if (number>99 && number<1000){

int firstDigit=number/100;
int lastDigit=number%10;
int result=(number-lastDigit-firstDigit*100)/10;
    Console.WriteLine($"Second digit in the number is {result}");

    //System.Console.WriteLine($"Number{number1} Max {max}");
}
else
{
    Console.WriteLine("Number is not three-digit");
}
