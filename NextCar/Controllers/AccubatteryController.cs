﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class AccubatteryController
    {
        private Accubattery accubattery;
        public AccubatteryController()
        {
            this.accubattery = new Accubattery(12);
        }

        public Boolean accubatterryIsOn()
        {
            return this.accubattery.isOn();
        }

        public void turnOn()
        {
            this.accubattery.turnOn();
        }

        public void turnOff()
        {
            this.accubattery.turnOff();
        }

    }
}
