using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MontyHall
{
    class MontyHallGame
    {
        List<Platform> lstPlatform = new List<Platform>();
        public bool isSwitch { get; set; }
        public int pick { get; set; }

        public MontyHallGame(int platformNumber)
        {
            for (int i = 0; i < platformNumber + 1; i++)
            {
                lstPlatform.Add(new Platform());
            }
        }

        //here we go



        public string Play()
        {
            string str = "Oyun Basladi\n";
            int totalWins = 0;
            int totalLose = 0;
            foreach (Platform item in lstPlatform)
            {
                int trueDoor = 0;
                int openedFalseDoor;
                int newlySelectedDoor = 0; //if existed..

                foreach (Door doorItem in item.lstDoor)
                {
                    if (doorItem.status)
                        trueDoor = doorItem.order;

                }

                openedFalseDoor = OpenDoor(item.lstDoor);

                if (isSwitch)
                {
                    foreach (Door doorItem in item.lstDoor)
                    {
                        if (doorItem.order != openedFalseDoor && doorItem.order != this.pick)
                            newlySelectedDoor = doorItem.order; //if this assignment accured more then once, this must be fatal. 
                    }

                    if (trueDoor == newlySelectedDoor)
                    {
                        //str += "Oyuncu " + this.pick + " kapisindan, " + newlySelectedDoor + " kapisina gecti. Bu secim ona kazandirdi.\n\n";
                        totalWins++;
                    }
                    else
                    {
                        //str += "Oyuncu " + this.pick + " kapisindan, " + newlySelectedDoor + " kapisina gecti. Bu secim ona kaybettirdi.\n\n";
                        totalLose++;
                    }
                }
                else
                {
                    if (trueDoor == this.pick)
                    {
                        //str += "Oyuncu " + this.pick + " kapisinda kalarak kazandi\n";
                        totalWins++;
                    }
                    else
                    {
                        //str += "Oyuncu " + this.pick + " kapisinda kalarak kaybetti\n";
                        totalLose++;
                    }
                }


            }

            str += "\n\n Oyun bitti.\n\n\n" + totalLose + " kez kaybetti.\n" + totalWins + " kez kazandi. Kapiyi degistirme durumu: " +this.isSwitch.ToString();

            return str;
        }



        // just give them true colors
        public int OpenDoor(List<Door> currentDoors)
        {
            foreach (Door item in currentDoors)
            {
                if (!item.status && item.order != this.pick)
                {
                    return item.order;
                }
            }

            return -1;//error
        }

        //is numbers really random?
        public string trueDoors()
        {
            string str = null;

            foreach (Platform item in this.lstPlatform)
            {
                foreach (Door dooritem in item.lstDoor)
                {
                    if (dooritem.status)
                        str += dooritem.order.ToString() + " ";
                }
            }

            return str;
        }
    }
}
