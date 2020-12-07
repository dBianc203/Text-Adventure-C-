using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Hydra : Flying
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public Hydra() : base()
        {
            this.name = "Squirtle";
            this.x = 3;
            this.y = 8;
            this.speed = 5;
            this.HP = 50;
            this.facing = Direction.NORTHEAST;
            this.Strength = 16;
            this.Dexterity = 16;
            this.Constitution = 12;
            this.Intelligence = 5;
            this.Wisdom = 3;
            this.Charisma = 10;
            this.ArmorClass = 3;          

      
        }
        public string HeadSmash(Creature def)
        {
            int toHit = Dice.Roll(20, 5);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(2,10);
                def.HP -= damage;
                return "Hydra smahses its heads against " + def.GetType().Name +
                        " and hits for " + damage + " damage!";
            }
            else
            {
                return "Hydra smahses its heads against " + def.GetType().Name + " and misses!";
            }
        }


        public string HighPitchScream(Creature def)
        {
            int toHit = Dice.Roll(6, 5);
            if (toHit > def.ArmorClass || toHit == 6)
            {
                int damage = Dice.Roll(3, 6);
                def.HP -= damage;
                return "Hydra screams in the ears of the " + def.GetType().Name +
                        " and deals " + damage + " damage!";
            }
            else
            {
                return "Hydra screams in the ears of the " + def.GetType().Name + " and does nothing!";
            }
        }
        /* Methods */
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Head Smash\n  Scream";
        }
        public override string Attack(Creature def)
        {
            if (Dice.Roll(2) == 1)
            {
                return HeadSmash(def);
            }
            else
            {
                return HighPitchScream(def);
            }
            
        }
          public override string Use(IUsable used){
          return "Hydra uses " + used.GetType().Name;
        }
     
        public override string Rest(){
          return "Hydra rests this turn";
        }

        public override string Defend(){
        return "Hydra Defends itself";
        }

        public override string DefendAgainst(Creature attacker){
          return "Hydra defends itself against " + attacker.GetType().Name;
        }
    }