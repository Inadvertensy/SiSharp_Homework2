// Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Please enter number");
int number=Convert.ToInt32(Console.ReadLine());
int numberAbs=Math.Abs(number);
if(numberAbs<100){
Console.WriteLine($"Number {number} does not have the third digit");
}
else{
if(numberAbs<1000){
    int result=numberAbs/100;
    Console.WriteLine($"third digit in number {number} is {result}");
}
else{
  //  Console.WriteLine(number/1000);
    int div=numberAbs/1000;
    int result=(numberAbs-div*1000)/100;
    Console.WriteLine($"third digit in number{number} is {result}");
}
}