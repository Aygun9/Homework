Console.Write("Insert number");
int number = int.Parse(Console.ReadLine());
int count = 2;
while (count<=number)
{
    Console.WriteLine($"{count}, ");
    count=count+2;
}