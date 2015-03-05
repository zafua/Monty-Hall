using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MontyHall
{
    class Door
    {
        public bool status { get; set; }
        public int order { get; set; }

        public Door(bool status, int order)
        {
            this.status = status;
            this.order = order;
        }
    }
}
