int age = 67;
if (age < 13)
{
    Console.WriteLine("Ребёнок");
}
else if (age < 18)
{
    Console.WriteLine("Подросток");
}
else if (age > 60)
{
    Console.WriteLine("Пенсионер");
}
else
{

    Console.WriteLine("Взрослый");
}

//4
int baty = 10;
double heigt = 1.0;
bool batyz = true;
if (baty >= 14 && heigt >= 1.4)

{
    Console.WriteLine("Можно кататься");
} else if(heigt < 1.5 && batyz )
{
    Console.WriteLine("можно кататься с сопровождение взрослого");
    
}
else
{
    Console.WriteLine("Пока нельзя");

}

//4
int vas = -3;
if (vas / 2 == 0)
{
    Console.WriteLine("четное положительное");

}
else if (vas / 2 == 1)
{
    Console.WriteLine("нечетное положительное");

}
else if (vas / -2 == 0)
{
    Console.WriteLine("четное не положительное "); }
else
{
    Console.WriteLine("Нечетное не положительное");
}
// Самостоятельные задания A
int t = 2;
if(t%2==0){
    Console.WriteLine("четное");
}else {
    Console.WriteLine("Нечетное");
}
// Самостоятельные задания В
int c = 3;
int d = 4;
int e = 5;
if (c <= e && d <= e)
{
    Console.WriteLine("наибольшее");
}
else
{
    Console.WriteLine("Неверное");
}