using System;

namespace CarChallenge
{
    class Program
    {

        class Car
        {
            string mark;
            string model;
            string color;
            string regNumber;
            int fueltank;
            int odo;

            public Car(string _mark, string _model, string _color, string _regNumber)
            {
                mark = _mark;
                model = _model;
                color = _color;

                if(_regNumber.Length != 6)
                {
                    regNumber = "undefined";
                }else
                {
                    regNumber = _regNumber;
                }

                fueltank = 60;
                odo = 0;
            }

            public string Model
            {
                get { return model; }
            }

            public int FuelTank
            {
                get { return fueltank; }
            }
            public int Odo
            {
               get { return odo; }
            }
            public void Drive()
            {
                odo += 100;
                fueltank -= 5;
            }
            public void ShowCarDetails()
            {
                Console.WriteLine($"Model: {model}\n Mark: {mark}\n Color: {color}\n regNumber: {regNumber}\n Fuel: {fueltank}\n Odo: {odo}");
            }

        }
        static void Main(string[] args)
        {
            Car newCar = new Car("nissan", "skyline", "blue", "1234ABC");

            while(newCar.FuelTank != 0)
            {
                newCar.Drive();
            }

            Console.WriteLine("the ride is over");
            newCar.ShowCarDetails();
        }
    }
}
