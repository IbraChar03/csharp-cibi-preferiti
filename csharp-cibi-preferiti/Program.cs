// See https://aka.ms/new-console-template for more information
string[] cibiPreferiti = { "pizza","kebab", "pasta al ragù","lasagna", "pasta al pesto" ,"carbonara"};

Console.WriteLine($"La classifica è formata da {cibiPreferiti.Length} cibi");
Console.WriteLine($"Classifica:");
var n = 0;

foreach (var item in cibiPreferiti)
{
    Console.WriteLine($" {n + 1} posto : {item}");
    n++;
}

Console.WriteLine($" Il cibo in primo posto è : {cibiPreferiti.AsQueryable().First()}");
Console.WriteLine($" Il cibo all`ultimo posto  è : {cibiPreferiti.AsQueryable().Last()}");
if (cibiPreferiti.Length % 2 == 0)

    Console.WriteLine($" I cibi di mezza classifica  sono : {cibiPreferiti[cibiPreferiti.Length / 2 - 1]} e {cibiPreferiti[cibiPreferiti.Length / 2]}");
else
Console.WriteLine($" Il cibo di mezza classifica  è : {cibiPreferiti[cibiPreferiti.Length / 2]}");

