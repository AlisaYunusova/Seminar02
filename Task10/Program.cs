int[] array = new int[3];
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i >= 0; i--)
{
    array[i] = number % 10;
    number /= 10;
}
Console.WriteLine(array[array.Length - 2]);

