using Singleton;

var a = LazySingleton.GetInstance(0);
var b = LazySingleton.GetInstance(1);
var c = LazySingleton.GetInstance(0);

Console.WriteLine($"a: {a.Number}, b: {b.Number}, c: {c.Number}");

var k = NewSingleton.GetInstance();
var l = NewSingleton.GetInstance();
var m = NewSingleton.GetInstance();

Console.WriteLine($"k: {k.Number}, l: {l.Number}, m: {m.Number}");