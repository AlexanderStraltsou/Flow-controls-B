// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type in a random number!");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in a random amount!");
int y = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < y; i++)
{
    Console.WriteLine("-------");
    Console.WriteLine();
    Console.WriteLine(x);
}