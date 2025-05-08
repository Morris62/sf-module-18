using PrototypeRealExample;

var location = new Point(10.323, 23.332);
var clonedLocation = location.Clone();

location.GetInfo();
clonedLocation.GetInfo();

Console.WriteLine();

var address = new Place("Маршала Баграмяна 1");
var clonedAddress = address.Clone();

address.GetInfo();
clonedAddress.GetInfo();
