using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secim degistirilsin mi?(0/1)");
            string switchCfg = Console.ReadLine();
            for (int i = 0; i < 1000; i++)
            {
                MontyHallGame mhg = new MontyHallGame(1000);
                mhg.pick = 1;
                if (switchCfg == "1")
                    mhg.isSwitch = true;
                else
                    mhg.isSwitch = false;
                Console.WriteLine(mhg.Play());
            }
            Console.ReadLine();
        }

    }

    

    

    


    
}

