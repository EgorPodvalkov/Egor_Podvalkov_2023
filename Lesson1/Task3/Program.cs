int listLength = 10;

var list = new List<int>();

for (int i = 0; i < listLength; i++)
{
    Console.Write($"Enter {i + 1} number: ");
    var num = Int32.Parse(Console.ReadLine());
    list.Add(num);
}

Console.Write("\nEnter number to dublicate: ");
var dublNum = Int32.Parse(Console.ReadLine());

var dublList = new List<int>();

Console.WriteLine("\nYour list: ");

foreach (int num in list)
{
    dublList.Add(num);
    if (num == dublNum)
        dublList.Add(num);

    Console.Write($"{num}, ");
}

Console.WriteLine("\nList with dublicates: ");
foreach (int num in dublList)
{
    Console.Write($"{num}, ");
}