
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
void Digit(int num)
{
    int des = (num /10 /10 % 10);
    
        if (num > 99 && num < 1000)
        {
        Console.WriteLine($"Вторая цифра числа {num} "); 
        }   
        else
        {
        Console.WriteLine("Число не трехзначное! ");
        }
}

Console.WriteLine("Введите трехзначное число: ");
int user_num = Convert.ToInt32(Console.ReadLine()); 

Digit(user_num);
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 


/*
Console.WriteLine("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int num = (user_num /10 /10 % 10);

if (user_num<=99)
{ 
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    Console.WriteLine (num);
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


/*
void Weekend(int num)
{
    if (num > 5 && num < 8)
    {
        Console.WriteLine($"Ура, {num} день - выходной день");
    }
    else
    {
    Console.WriteLine($"Увы, {num} день - не является выходным днём");
    }           
}
    Console.WriteLine("Введите число обозначающую день недели от 1 до 7: ");
    int user_num = Convert.ToInt32(Console.ReadLine());

    Weekend(user_num);
    */