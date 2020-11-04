using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class Door
    {
       private Boolean locked = false;

        public void doorLocked()
        {
            this.locked = true;
        }

        public void doorUnlocked()
        {
            this.locked = false;
        }

        public Boolean isLocked()
        {
            return this.locked;
        }
        
    }
}
