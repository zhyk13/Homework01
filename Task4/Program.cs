//На вход принимает число (number), а на выходе выводит все чётные
//числа от 1 до number (включительно), разделеные знаком табуляции.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= number)
{
    if (index % 2 == 0)
    {
        Console.Write(index);
        Console.Write("\t");
    }
    index++;    
}