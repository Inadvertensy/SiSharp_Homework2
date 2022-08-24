// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
Console.WriteLine("Please enter weekday number");
int number=Convert.ToInt32(Console.ReadLine());
if(number>8 || number<1) Console.WriteLine("this number is not a weekday number!");
else{
if (number==6 && number==7) {
    Console.WriteLine("Weekend!");
    }
else {Console.WriteLine("Not Weekend! ===");}
}