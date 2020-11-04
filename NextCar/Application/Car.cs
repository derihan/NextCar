using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class Car
    {
        AccubatteryController accubatteryController;
        DoorControllers doorControllers;
        public void setAccubatteryController(AccubatteryController accubatteryController) 
        {
            this.accubatteryController = accubatteryController;
           
        }

        public void setDoorController(DoorControllers doorControllers)
        {
            this.doorControllers = doorControllers;
        }

        public void turnOnPower()
        {
            this.accubatteryController.turnOn();
        }

        public void turnOfPower()
        {
            this.accubatteryController.turnOff();
        }

        public Boolean powerIsReady()
        {
            return this.accubatteryController.accubatterryIsOn();
        }

        public void doorIsLocked()
        {
            this.doorControllers.locked();
        }

        public void doorIsUnlock()
        {
            this.doorControllers.unlocked();
        }

        public Boolean doorIsOpen()
        {
            return this.doorControllers.doorIsUnlocked();
        }

    }
}
