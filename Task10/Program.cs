// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int[] array = new int[3];
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i >= 0; i--)
{
    array[i] = number % 10;
    number /= 10;
}
Console.WriteLine(array[array.Length - 2]);

//Через массив не соответсвует ТЗ. Потому что надо работать с числом. Правильно:
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int lenghtNumber = 0;
int copyNumber = number;

while (copyNumber > 0)
{
    copyNumber /= 10;
    lenghtNumber ++;
}
Console.WriteLine(lenghtNumber);

int power = 1;
while (lenghtNumber>3)
{
    power *=10;
    lenghtNumber --;
}
Console.WriteLine(number/power % 10);
