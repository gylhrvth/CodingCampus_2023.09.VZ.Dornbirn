using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Vehicle
{
    internal class VehicleMain
    {
        public static void Start()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            Car car = new Car(5, 250.3f, 200.8f, 250.2f);
            vehicleList.Add(car); 

            Plane plane = new Plane(10, 6523.75f, 1000.3f, 1200.1f, true);
            vehicleList.Add(plane);
            
            MotorCycle motorCycle = new MotorCycle(0, 80.5f, 145.78f, 280.5f);
            vehicleList.Add(motorCycle);

            Helicopter heli = new Helicopter(4, 234.14f, 300.33f, 380f, true);
            vehicleList.Add(heli);

            Console.WriteLine("Welches Fahrzeug möchtest du fahren?");
            var userImput = Console.ReadLine();

            foreach(Vehicle vehicle in vehicleList)
            {
                if(vehicle.GetType().Name == userImput)
                {
                    Console.WriteLine("Fahrzeug gefunden: " + userImput);
                    vehicle.LogInformation();

                    if(userImput == nameof(Car))
                    {
                        Car selectedVar = vehicle as Car;
                        car.Move();
                    }
                    else if(userImput == nameof(Plane))
                    {
                        Plane selectedPlane = vehicle as Plane;
                        plane.Move();
                        plane.Landing();

                    }
                    else if(userImput == nameof(MotorCycle))
                    {
                        MotorCycle selectedCycle = vehicle as MotorCycle;
                        motorCycle.Move();
                    }
                    else if(userImput == nameof(Helicopter))
                    {
                        Helicopter selectedHeli = vehicle as Helicopter;
                        heli.Move();
                        heli.Landing();
                    }
                    else
                    {
                        Console.WriteLine("Dieses Fahrzeug steht nicht bereit.");
                    }
                    break;
                }
            }

        }

    }
}
