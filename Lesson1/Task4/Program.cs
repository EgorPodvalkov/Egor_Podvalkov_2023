// Getting first string
Console.Write("Enter 1 string: ");
var str1 = Console.ReadLine();

// Getting second string
Console.Write("Enter 2 string: ");
var str2 = Console.ReadLine();

// If first longer
if (str1.Length > str2.Length)
    Console.WriteLine($"Result: {str1 + str2}");
// If second longer
else if (str1.Length < str2.Length)
{
    // Splitting
    var splitter = str1.Length > 0 ? str1[0] : ' ';
    var result = str2.Split(splitter);
    Console.WriteLine("Result: ");

    // Returning result
    foreach (var str in result)
    {
        Console.WriteLine(str);
    }
}
// If equal length
else
    Console.WriteLine("Result: ");
