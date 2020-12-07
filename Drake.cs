using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Drake : Flying
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public Drake() : base()
        {
            this.name = "Toothless";
            this.x = 3;
            this.y = 8;
            this.speed = 5;
            this.HP = 50;
            this.facing = Direction.NORTHEAST;       
            this.Strength = 15;
            this.Dexterity = 10;
            this.Constitution = 13;
            this.Intelligence = 3;
            this.Wisdom = 4;
            this.Charisma = 15;
            this.ArmorClass = 5;
            
        }
 public string FireBreath(Creature def)
        {
            int toHit = Dice.Roll(15, 5);
            if (toHit > def.ArmorClass || toHit == 15)
            {
                int damage = Dice.Roll(1,10);
                def.HP -= damage;
                return "Drake unleashes his monsterous flames at " + def.GetType().Name +
                        " and hits for " + damage + " fire damage!";
            }
            else
            {
                return "Drake unleashes his monsterous flames at " + def.GetType().Name + " and misses!";
            }
        }


        public string TailWhip(Creature def)
        {
            int toHit = Dice.Roll(10, 3);
            if (toHit > def.ArmorClass || toHit == 10)
            {
                int damage = Dice.Roll(2, 6);
                def.HP -= damage;
                return "Dragon whips his tail at " + def.GetType().Name +
                        " and hits for " + damage + " damage!";
            }
            else
            {
                return "Dragon whips his tail at " + def.GetType().Name + " and misses!";
            }
        }
        /* Methods */
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  FireBreath\n  TailWhip";
        }


        public override string Attack(Creature def){
                  {
            if (Dice.Roll(2) == 1)
            {
                return FireBreath(def);
            }
            else
            {
                return TailWhip(def);
            }
            
        }
        }
          public override string Use(IUsable used){
          return "Drake uses " + used.GetType().Name;
        }
     
        public override string Rest(){
          return "Drake rests this turn";
        }

        public override string Defend(){
        return "Drake Defends itself";
        }

        public override string DefendAgainst(Creature attacker){
          return "Drake defends itself against " + attacker.GetType().Name;
        }

    }
    