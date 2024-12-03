using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            //TODO

            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var carOne = new Car();
            carOne.Make = "Mazda";
            carOne.Model = "Miata";
            carOne.Year = 1998;
            carOne. IsDriveable = true;
            
            carOne. MakeEngineNoise("AHH");
            carOne. MakeHonkNoise("meep");

            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car() 
            {
                Make = "Toyota", 
                Model = "Supra", 
                Year = 2005, 
                IsDriveable = true  
            };
            
            carTwo.MakeEngineNoise("WEE");
            carTwo.MakeHonkNoise("boop");
            
            carLotOne.ParkingLot.Add(carTwo);

            var carThree = new Car("Datsun", "500", 1970, true);
            
            carThree.MakeEngineNoise("Vrum");
            carThree.MakeHonkNoise("beep");
            
            carLotOne.ParkingLot.Add(carThree);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLotOne.CheckCars();
            Console.WriteLine($"Number of cars created: {CarLot.NumberOfCars}");
        }
    }
}
