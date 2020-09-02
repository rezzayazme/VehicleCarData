//Yasser Meza
//ITCS 3112-051
//Feb 22, 2019
//CarClassMain

using System;

namespace CarClass
{
    public class Car
    {
        //class variables
        int year_model = 0;
        string model = "";
        double speed;

        //Main constructor, requires year and model
        public Car(int yModel, string cModel)
            {
                year_model = yModel;
                model = cModel;
                speed = 0.0;
            }
         
        //Accelrator method, adds 5 to speed
        //returns double for speed
        public double Accelerator()
            {
                speed = speed + 5;
                return speed;
            }

        //Brake method, subtracts 5 from speed
        //return double for speed
        public double Brake()
            {
                speed = speed - 5;
                return speed;
            }

        //currentSpeed method, 
        //returns the value in speed
        public double currentSpeed()
            {
                return speed;
            }

        //returns model instantiated from Main
        public string GetModel()
        {
            return model;
        }

        //returns year instantiated from Main
        public int GetYear()
        {
            return year_model;
        }

    }
}