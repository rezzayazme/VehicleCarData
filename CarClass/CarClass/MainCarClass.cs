//Yasser Meza
//ITCS 3112-051
//Feb 22, 2019
//CarClassMain

using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initializing all main variable
            string carModel;
            int carYear;
            double carSpeed;
            string carYearS;

            //Starting input and output 
            //Asking for car demographics
            //Model
            Console.WriteLine("What is the Car Model?");
            carModel = Console.ReadLine();

            //Year
            Console.WriteLine("What is the Car Year?");
            carYearS = Console.ReadLine();
            carYear = Convert.ToInt32(carYearS);

            //Creating Car.cs instance
            Car car = new Car(carYear, carModel);


            //Letting user know that Accelerating method in
            // Car class is being used
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("ACCELERATING");
            Console.WriteLine("-----------------");
            Console.WriteLine("");


            //Starting loop for Accelerating loop
            //increment 5 to speed evertime it is called
            //looping 5 times
            int a = 5;
            while (a >= 0)
            {
                //outputting current speed each time accelerating 
                //method is used.. starting speed should be 0
                carSpeed = car.currentSpeed();
                Console.WriteLine("Current Car Speed: " + carSpeed);

                //calling method from Car class
                car.Accelerator();

                //decrement to stop loop from accelrating
                a--;
            }

            //outputting top speed once accelerating stops
            carSpeed = car.currentSpeed();
            Console.WriteLine("Current Car Speed: " + carSpeed);

            //Letting user know that Brake method in
            // Car class is being used
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("BRAKING");
            Console.WriteLine("-----------------");
            Console.WriteLine("");


            //Starting loop for Brake loop
            //decrement 5 to speed everytime it is called
            //looping 5 times
            int b = 5;
            while (b >= 0)
            {
                //outputting current speed each time accelerating 
                //method is used.. speed should be top speed from 
                //accelerating method loop
                carSpeed = car.currentSpeed();
                Console.WriteLine("Current Car Speed: " + carSpeed);

                //calling method from Car class to brake the car
                car.Brake();

                //decrement from b to stop braking loop
                b--;
            }

            //Final output after Car has Accelerated and Braked 5 times each 
            //in succession
            //Outputs the model and year from the Car class
            Console.WriteLine("");
            carSpeed = car.currentSpeed();
            Console.WriteLine("Current Car Speed: " + carSpeed);
            Console.WriteLine("Car Model: " + car.GetModel());
            Console.WriteLine("Car Year: " + car.GetYear());
        
        }//end main
    }//end main class program 
}//end MainCarClass