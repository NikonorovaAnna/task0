//Напишите программу, которая будет выдавать название дня недели по заданному номеру
//3 - среда
//5 - пятница
Console.Clear();
Console.WriteLine("Введите номер дня недели от 1 до 7 ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
Console.Write("Понедельник");
}

if(number == 2)
{
    Console.Write("вторник");
}

if(number == 3)
{
   Console.Write("среда"); 
}

if(number == 4)
{
    Console.Write("четверг");
}

if(number == 5)
{
    Console.Write("пятница");
}

if(number == 6)
{
     Console.Write("суббота");
}

if(number == 7)
{
    Console.Write("воскресенье");
}








