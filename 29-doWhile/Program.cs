//CICLO DO WHILE
Console.WriteLine("Ciclo doWhile");
int i = 0;
do
{
    Console.WriteLine("i = {0}", i);
    i++;

} while (i < 5);
//ROMPER CICLO DO WHILE CON BREAK
Console.WriteLine("doWhile con break para romper el ciclo");
i = 0;
do
{
    Console.WriteLine("i = {0}", i);
    i++;
    
    if (i > 5)
        break;

} while (i < 10);

//do While anidados
Console.WriteLine("Ciclos doWhile anidados");
i = 0;
do
{
    Console.WriteLine("El valor de i: {0}", i);
    int j = i;
    i++;            
    do
    {
        Console.WriteLine("El valor de j: {0}", j);
        j++;
    } while (j < 2);
} while (i < 2);