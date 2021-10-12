using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProjectElle
{
    class Program
    {
        static int health = 100;
        static int weapon;

        static void Weapon()
        {
            int[] ammo;
            ammo = new int[3];
            ammo[0] = 6; //pistol
            ammo[1] = 2; //shotgun
            ammo[2] = 10; //bfg

            string[] weaponName;
            weaponName = new string[3];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shot Gun";
            weaponName[2] = "BFG";

            if (weapon <= 0)
            {
                weapon = 0;
            }
            if (weapon >= 2)
            {
                weapon = 2;
            }

            Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Weapon System");
            Weapon();
            weapon = 1;
            Weapon();
            weapon = 2;
            Weapon();
            weapon = -10;
            Weapon();
            weapon = 10;
            Weapon();
            Console.ReadKey(true);
        }
    }
}
