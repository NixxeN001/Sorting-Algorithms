// See https://aka.ms/new-console-template for more information
using Sorting_AlgorithmsNew.Class;
using System;
using System.Collections.Generic;
using System.Text.Json;
//Console.WriteLine("Hello, World!");
var Invetory = new List<Item>()
{
    new Item{price=4,damage = 10f, name = "A"},
    new Item{price=2,damage = 12f, name = "Q"},
    new Item{price=5,damage = 1.2f, name = "D"},
    new Item{price=1,damage = 1.3f, name = "S"},
    new Item{price=17,damage = 0.4f, name = "R"},
};

Console.WriteLine("unsorted");
for (int i = 0; i < Invetory.Count; i++)
{
    Console.WriteLine(Invetory[i].price + ":" + Invetory[i].damage + ":" + Invetory[i].name);
}

Sorter.SortbyFloat(ref Invetory, "price");

Console.WriteLine("Sorted");
for (int i = 0; i < Invetory.Count; i++)
{
    Console.WriteLine(Invetory[i].price + ":" + Invetory[i].damage + ":" + Invetory[i].name);
}
//testClasses.ForEach(testClass => Console.WriteLine(testClass.Name));
//Console.WriteLine("Unsorted List");
//string filepath = "JSON_Test.json";

#region old code
//sorting secion of the code 
/*testClasses.Sort();
var namecol = new TestClass[testClasses.Count];
testClasses.CopyTo(namecol, 0);

testClasses.Sort(new PriceComaperer());
var pricecol = new TestClass[testClasses.Count];
testClasses.CopyTo(pricecol, 0);
pricecol = namecol.Concat(pricecol).ToArray();

testClasses.Sort(new DamageComparer());
var damcol = new TestClass[testClasses.Count];
testClasses.CopyTo(damcol, 0);
damcol= damcol.Concat(pricecol).ToArray();


testClasses.Sort(new RangeComparer());
var finalcol = new TestClass[testClasses.Count];
testClasses.CopyTo(finalcol, 0);
finalcol = finalcol.Concat(damcol).ToArray();


//JSON serialize to the bin file
string JsonSerial = JsonSerializer.Serialize(finalcol);
//Console.WriteLine(Jsonstring);

Console.WriteLine(JsonSerial);
File.WriteAllText(filepath, JsonSerial);

Console.WriteLine("\n");
testClasses.Sort(new PriceComaperer());
Console.WriteLine("Sorted by Price");
testClasses.ForEach(Console.WriteLine);

Console.WriteLine("\n");
testClasses.Sort(new DamageComparer());
Console.WriteLine("Sorted by Damage");
testClasses.ForEach(Console.WriteLine);

Console.WriteLine("\n");
testClasses.Sort(new RangeComparer());
Console.WriteLine("Sorted by Range");
testClasses.ForEach(Console.WriteLine);*/
#endregion

