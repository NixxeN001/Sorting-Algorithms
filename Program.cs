// See https://aka.ms/new-console-template for more information
using Sorting_AlgorithmsNew;
using System;
using System.Collections.Generic;
using System.Text.Json;
//Console.WriteLine("Hello, World!");
List<TestClass> testClasses = new List<TestClass>();

testClasses.Add(new TestClass());
testClasses.Add(new TestClass("Sword", 5, 2, 0.4f));
testClasses.Add(new TestClass("Axe", 100, 3, 4f));
testClasses.Add(new TestClass("Spear", 45, 20, 3.5f));

//testClasses.ForEach(testClass => Console.WriteLine(testClass.Name));
Console.WriteLine("Unsorted List");
string filepath = "JSON_Test.json";

testClasses.Sort();
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

//JSON serialize
string JsonSerial = JsonSerializer.Serialize(finalcol);
//Console.WriteLine(Jsonstring);

Console.WriteLine(JsonSerial);
File.WriteAllText(filepath, JsonSerial);




/*
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


