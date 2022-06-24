
using MyDictionary;

Dictionary<int, string> aDictionary = new Dictionary<int, string>();
aDictionary.Add(1, "one");
Console.WriteLine(aDictionary.Count);


MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
myDictionary.Add(1, "one");
myDictionary.Add(2, "two");
myDictionary.Add(3, "three");
Console.WriteLine(myDictionary.Count); 

