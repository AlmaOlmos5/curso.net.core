Console.WriteLine("Ciclo While");
int i = 0; // initialization

while (i < 10) // condition
{
    Console.WriteLine("i = {0}", i);

    i++; // increment
}
//INTERRUPCIÓN DEL CICLO WHILE CON BREAK O RETURN 
Console.WriteLine("Interrupción de ciclo while con break");
i = 0;

while (true)
{
    Console.WriteLine("i = {0}", i);

    i++;

    if (i > 10)
        break;
}
//BUCLE WHILE ANIDADO
Console.WriteLine("Ciclo While anidado");
 i = 0;
 int j = 1;

while (i < 2)
{
    Console.WriteLine("i = {0}", i);
    i++;

    while (j < 2)
    {
        Console.WriteLine("j = {0}", j);
        j++;
    }
}