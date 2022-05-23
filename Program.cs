//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 - 5
//782 - 8
//918 - 1
int result(int number1)
{
int number2=(number1/10)%10;
return number2;
} 

Console.WriteLine("Введите трехзначное число: ");
string number=Console.ReadLine();
int lenght=number.ToString().Length;

if(int.TryParse(number, out int num))
{
    if(lenght==3)
    {
        int temp=result(num);
        Console.WriteLine("Вторая цифра числа "+num+":"+temp);
    }
    else 
    Console.WriteLine("Вы ввели не трехзначное число!!!");
 }
else
    Console.WriteLine("Вы ввели не число. Для корректной работы программы введите трехзначное число!!!");




