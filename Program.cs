// See https://aka.ms/new-console-template for more information
using References_Lumpkin_Dalton;


Challenger car = new Challenger(60.00);
IAutomobile car2 = car;
Challenger car3 = new Challenger(60.00);

car.SpeedUp();

//Prints the speed of the two cars to the console and then compares them, it comes out true because they both refrence the same object
Console.WriteLine("Speed of First car..." + car.Speed);
Console.WriteLine("Speed of Second car..." + car2.Speed);
Console.WriteLine($"the first and second car have the same reference... {car == car2}");

//Prints the speed of the 3rd car 
Console.WriteLine("Speed of Third car..." + car3.Speed);

//calls the SpeedUp() method on car3 
car3.SpeedUp();

//Prints the speed of the 3rd car 
Console.WriteLine("Speed of Third car is" + car3.Speed);

//prints a comparison of car and car 3 to the console, although the values are the same, its still prints out false because 
//the refrences are to two different objects
Console.WriteLine($"car1 and car3 have the same reference... {car == car3}");


//Creates a Truck object that refrences a new Truck()
Truck truck = new Truck(60.00, 600, "trucklol");

//create a new IAutomobile Array containing references to the 4 vehichles
IAutomobile[] vehicles = new IAutomobile[] { car, car2, car3, truck};

// a foreach loop calling each object in vehichles Stringify() method
foreach (IAutomobile vehicle in vehicles) { vehicle.Stringify(); }