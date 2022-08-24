// Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 
// 7 и 23. 
// 14 -> нет 
// 46 -> нет 
// 161 -> да
Console.WriteLine("Please enter the number");
int number=Convert.ToInt32(Console.ReadLine());
int multiple7=number%7;
int multiple23=number%23;
if (multiple23==0 && multiple7==0) {
    Console.WriteLine($"Number {number} is multiple of 7 and 23");
}
else
{
    {Console.WriteLine($"Number {number} is NOT multiple of 7 and 23");}
}
