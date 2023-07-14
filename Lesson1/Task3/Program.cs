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

Console.WriteLine("\nYour list: ");

foreach (int num in list)
{
    Console.Write($"{num}, ");
}

for (int i = 0; i < list.Count; i++)
{
    if (list[i] == dublNum)
    {
        list.Insert(i, dublNum);
        i++;
    }
}

Console.WriteLine("\nList with dublicates: ");
foreach (int num in list)
{
    Console.Write($"{num}, ");
}