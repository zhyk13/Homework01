//Принимает на вход три числа и выдаёт максимальное из этих чисел.
int[] array = new int[3];
Console.Write("Введите первое число: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
array[2] = Convert.ToInt32(Console.ReadLine());
int result = array[0];
int index = 1;
while (index <= 2)
{
    if (array[index] > result)
    {
        result = array[index];
    }
    index++;
}
Console.WriteLine($"Максимальное число {result}");