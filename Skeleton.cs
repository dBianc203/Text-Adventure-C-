using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Skeleton : Undead
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public Skeleton() : base()
        {
            this.name = "Skeletor";
            this.x = 1;
            this.y = 1;
            this.speed = 3;
            this.HP = 25;
            this.facing = Direction.SOUTHEAST;
            this.Strength = 10;
            this.Dexterity = 14;
            this.Constitution = 15;
            this.Intelligence = 6;
            this.Wisdom = 8;
            this.Charisma = 5;
            this.ArmorClass = 13;          

      
        }
        public string Shortsword(Creature def)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 6, 2);
                def.HP -= damage;
                return "Skeleton thrusts his shortsword at " + def.GetType().Name +
                        " and hits for " + damage + " piercing damage!";
            }
            else
            {
                return "Skeleton thrusts his shortsword at " + def.GetType().Name + " and misses!";
            }
        }

        /* Longsword:
           Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
           Hit: (1d8) slashing damage.
        */
        public string Longsword(Creature def)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 8);
                def.HP -= damage;
                return "Skeleton swings his longsword at " + def.GetType().Name +
                        " and hits for " + damage + " slashing damage!";
            }
            else
            {
                return "Skeleton swings his longsword at " + def.GetType().Name + " and misses!";
            }
        }
        /* Methods */

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Longsword\n  Shortsword";
        }
public override string Attack(Creature def)
        {
            if (Dice.Roll(2) == 1)
            {
                return Shortsword(def);
            }
            else
            {
                return Longsword(def);
            }
            
        }
          public override string Use(IUsable used){
          return "Skeleton uses " + used.GetType().Name;
        }
     
        public override string Rest(){
          return "Skeleton rests this turn";
        }

        public override string Defend(){
        return "Skeleton Defends itself";
        }

        public override string DefendAgainst(Creature attacker){
          return "Skeleton defends itself against " + attacker.GetType().Name;
        }
    }