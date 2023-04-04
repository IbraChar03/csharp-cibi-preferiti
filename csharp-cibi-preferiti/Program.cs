// See https://aka.ms/new-console-template for more information
string[] cibiPreferiti = { "pizza","kebab", "pasta al ragù","lasagna", "pasta al pesto" };

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


