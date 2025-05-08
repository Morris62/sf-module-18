using Prototype;

var classOne = new ClassOne(1);
var cloneClassOne = classOne.Clone();

Console.WriteLine(ReferenceEquals(classOne, cloneClassOne));
