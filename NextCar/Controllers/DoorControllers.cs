using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class DoorControllers
    {
        private Door door;

        public DoorControllers()
        {
            this.door = new Door();
        }

        public Boolean doorIsUnlocked()
        {
            return this.door.isLocked();
        }

        public void locked()
        {
            this.door.doorLocked();
        }

        public void unlocked()
        {
            this.door.doorUnlocked();
        }


    }
}
