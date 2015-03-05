using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MontyHall
{
    class Platform
    {
        public List<Door> lstDoor = new List<Door>();
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public Platform()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            int randomNumber = RandomNumber(0, 125123) % 3;

            for (int i = 0; i < 3; i++)
            {

                if (randomNumber == i)
                    lstDoor.Add(new Door(true, i));
                else
                    lstDoor.Add(new Door(false, i));

            }
        }



    }
}
