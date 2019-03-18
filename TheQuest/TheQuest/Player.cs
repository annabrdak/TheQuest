using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Player : Mover
    {
        private const int NearWeaponDistance = 25;
        private Weapon equippedWeapon;

        public int HitPoints { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();

        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public Player(Game game, Point location)
            : base(game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }
        
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            switch (game.WeaponInRoom)
            {
                case null:
                    break;
                default:
                    if (!game.WeaponInRoom.PickedUp)
                    {
                        // see if the weapon is nearby - within a single unit of distance????, and possibly pick it up
                        if (Nearby(game.WeaponInRoom.Location, NearWeaponDistance))
                        {
                            inventory.Add(game.WeaponInRoom);
                            game.WeaponInRoom.PickUpWeapon();
                            if (inventory.Count == 1)
                            {
                                Equip(game.WeaponInRoom.Name);
                                //equippedWeapon = game.WeaponInRoom;
                            }
                        }
                    }
                    break;
            }
            
        }

        public void Attack(Direction direction, Random random)
        {
            // Your code goes here

            if (equippedWeapon != null)
            {
                if (equippedWeapon is IPotion)
                {                   
                    equippedWeapon.Attack(direction, random);                    
                    inventory.Remove(equippedWeapon);
                }
                else
                 equippedWeapon.Attack(direction, random);
            }
        }
    }
}
