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
            ammo = new int[3]; //initialization (telling the compiler the size)
            ammo[0] = 6; //pistol
            ammo[1] = 2; //shotgun
            ammo[2] = 10; //bfg
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Weapon System");
            Weapon();
            Console.ReadKey(true);
        }
    }
}
