using Delegate301;

Console.WriteLine("Delegates - Covariance Example");
Console.WriteLine("the return type of the delegete is 'less derived' than the actual types being returned");
Console.WriteLine();

CarFactoryDlgt carFactoryDlgt = CarFactory.ReturnCarICE;

Car iceCar = carFactoryDlgt(1, "Audi R8");
Console.WriteLine($"    Object Type: {iceCar.GetType()}");
Console.WriteLine($"    Car Details:  {iceCar.GetCarDetails()}");

carFactoryDlgt = CarFactory.ReturnCarEV;

Car evCar = carFactoryDlgt(2, "Tesla Model-3");
Console.WriteLine($"    Object Type: {evCar.GetType()}");
Console.WriteLine($"    Car Details:  {evCar.GetCarDetails()}");

Console.WriteLine("Delegates - Contravariance Example");
Console.WriteLine("the parameters being passed in are 'more derived' than the delegates parameter definition");
Console.WriteLine();

LogICECarDetails logICECarDetails = CarFactory.LogCarDetails;
LogEVCarDetails logEVCarDetails = CarFactory.LogCarDetails;

logICECarDetails(iceCar as CarICE);
logEVCarDetails(evCar as CarEV);


