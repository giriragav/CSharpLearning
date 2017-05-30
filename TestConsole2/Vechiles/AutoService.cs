using System;
namespace Vechiles
{
    public class AutoService
    {
        public delegate void ArrangeServices(MotorCar car);
        public void DoService(MotorCar car, Action<MotorCar> services)
        {
            //var repair = new AutoRepair();
            //repair.OilChange(car);
            //repair.TyreChange(car);

            //var wash = new AutoWash();
            //wash.ScartchRemoval(car);
            //wash.WaterSpray(car);
            //wash.ApplySoap(car);
            //wash.WaterSpray(car);
            services(car);

        }
    }
}

