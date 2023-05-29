
using ca1;

var t = new Tucan() { Name = "Pico Iris" };
t.Fly();
t.Sing();
t.WhoAreYou();

var f = new Falcon() { Name = "Gavilan" };
f.WhoAreYou();

// Principles applied here ..

// Encapsulate what varies
// Use composition rather than inheritance
// Program to an interface, not an implementation

// -> The Strategy Pattern

var t2 = new ca1.Alternativa.Tucan() { Name = "Pico Iris 2" };
t2.SingBehavior?.Sing();
t2.WhoAreYou();

var f2 = new ca1.Alternativa.Falcon() { Name = "Gavilan 2" };
f2.SingBehavior?.Sing();
f2.WhoAreYou();

var o1 = new ca1.Alternativa.OrigamiBird() { Name = "Gaviota" };
//o1.SingBehavior?.Sing();
o1.WhoAreYou();

Console.WriteLine("READY!");
