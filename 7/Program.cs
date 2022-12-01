using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weapons = new Dictionary<string, IWeapon>();
            var weaponFactory = new WeaponFactory();
            var gemFactory = new GemFactory();
            while (true)
            {
                string[] str = Console.ReadLine().Split(';');
                if (str[0] == "Create")
                {
                    string[] weaponData = str[1].Split();
                    IWeapon weapon = weaponFactory.CreateWeapon(weaponData[1], weaponData[0]);
                    weapons.Add(str[2], weapon);
                }
                else if (str[0] == "Add")
                {
                    string[] gemData = str[3].Split();
                    IGem gem = gemFactory.CreateGem(gemData[1], gemData[0]);
                    weapons[str[1]].AddGem(gem, int.Parse(str[2]));
                }
                else if (str[0] == "Remove")
                {
                    weapons[str[1]].RemoveGem(int.Parse(str[2]));
                }
                else if (str[0] == "Print")
                {
                    Console.WriteLine($"{str[1]}: {weapons[str[1]]}");
                }
                else { break; }
            }
        }
    }
}