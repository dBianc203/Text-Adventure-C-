using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Ghost : Undead
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public Ghost() : base()
        {
            this.name = "Casper";
            this.x = 1;
            this.y = 3;
            this.speed = 3;
            this.HP = 15;
            this.facing = Direction.SOUTH;
            this.Strength = 7;
            this.Dexterity = 13;
            this.Constitution = 10;
            this.Intelligence = 10;
            this.Wisdom = 12;
            this.Charisma = 17;
            this.ArmorClass = 7;

      
        }
        public string WitheringTouch(Creature def)
        {
            int toHit = Dice.Roll(20, 5);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(4, 6, 3);
                def.HP -= damage;
                return "Ghost uses Withering Touch against " + def.GetType().Name +
                        " for " + damage + " necrotic damage!";
            }
            else
            {
                return "Ghost fails to touch " + def.GetType().Name + "!";
            }
        }
        /* Methods */
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Withering Touch";
        }
        public override string Attack(Creature def){
            return WitheringTouch(def);
        }
          public override string Use(IUsable used){
          return "Ghost uses " + used.GetType().Name;
        }
     
        public override string Rest(){
          return "Ghost rests this turn";
        }

        public override string Defend(){
        return "Ghost Defends itself";
        }

        public override string DefendAgainst(Creature attacker){
          return "Ghost defends itself against " + attacker.GetType().Name;
        }
    }