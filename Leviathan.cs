using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Leviathan : Flying
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public Leviathan() : base()
        {
            this.name = "Marcus";
            this.x = 4;
            this.y = 10;
            this.speed = 7;
            this.HP = 55;
            this.facing = Direction.NORTHWEST;
            this.Strength = 13;
            this.Dexterity = 15;
            this.Constitution = 13;
            this.Intelligence = 9;
            this.Wisdom = 6;
            this.Charisma = 8;
            this.ArmorClass = 6;           

      
        }
 public string Bite(Creature def)
        {
            int toHit = Dice.Roll(13, 6);
            if (toHit > def.ArmorClass || toHit == 13)
            {
                int damage = Dice.Roll(2,8);
                def.HP -= damage;
                return "Leviathan bites " + def.GetType().Name +
                        " and deals " + damage + " damage!";
            }
            else
            {
                return "Leviathan tries to bite " + def.GetType().Name + " and misses!";
            }
        }


        public string WaterBeam(Creature def)
        {
            int toHit = Dice.Roll(8, 6);
            if (toHit > def.ArmorClass || toHit == 8)
            {
                int damage = Dice.Roll(4, 6);
                def.HP -= damage;
                return "Leviathan launches a beam of water at " + def.GetType().Name +
                        " and deals " + damage + " damage!";
            }
            else
            {
                return "Leviathan launches a beam of water at " + def.GetType().Name + " and misses!";
            }
        }
        /* Methods */
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Bite\n  Water beam";
        }
        public override string Attack(Creature def)
        {
            if (Dice.Roll(2) == 1)
            {
                return Bite(def);
            }
            else
            {
                return WaterBeam(def);
            }
            
        }
          public override string Use(IUsable used){
          return "Leviathan uses " + used.GetType().Name;
        }
     
        public override string Rest(){
          return "Leviathan rests this turn";
        }

        public override string Defend(){
        return "Leviathan Defends itself";
        }

        public override string DefendAgainst(Creature attacker){
          return "Leviathan defends itself against " + attacker.GetType().Name;
        }

    }