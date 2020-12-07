using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Dracula : Vampire
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public Dracula() : base()
        {
            this.name = "Bob";
            this.x = 4;
            this.y = 4;
            this.speed = 11;
            this.HP = 35;
            this.facing = Direction.NORTH;
            this.Strength = 18;
            this.Dexterity = 15;
            this.Constitution = 10;
            this.Intelligence = 13;
            this.Wisdom = 3;
            this.Charisma = 4;
            this.ArmorClass = 10;
      
        }
public string BloodSuck(Creature def)
        {
            int toHit = Dice.Roll(15, 4);
            if (toHit > def.ArmorClass || toHit == 10)
            {
                int damage = Dice.Roll(2,8);
                def.HP -= damage;
                return "Dracula sucks the blood from " + def.GetType().Name +
                        " and deals " + damage + " damage!";
            }
            else
            {
                return "Dracula tries to suck the blood from " + def.GetType().Name + " and fails!";
            }
        }


        public string Decapitation(Creature def)
        {
            int toHit = Dice.Roll(5, 3);
            if (toHit > def.ArmorClass || toHit == 25)
            {
                int damage = Dice.Roll(10, 6);
                def.HP -= damage;
                return "Dracula attempts to decapitate " + def.GetType().Name +
                        " and deals " + damage + " damage!";
            }
            else
            {
                return "Dracula attempts to decapitate " + def.GetType().Name + " and misses completely!";
            }
        }

 

        

        /* Methods */
        public override string ToString()
        {
            return base.ToString()

                + "\nAttacks:\n  Decapitate\n  BloodSuck";
        }
       public override string Attack(Creature def)
        {
            if (Dice.Roll(2) == 1)
            {
                return BloodSuck(def);
            }
            else
            {
                return Decapitation(def);
            }
            
        }
          public override string Use(IUsable used){
          return "Dracula uses " + used.GetType().Name;
        }
     
        public override string Rest(){
          return "Dracula rests this turn";
        }

        public override string Defend(){
        return "Dracula Defends itself";
        }

        public override string DefendAgainst(Creature attacker){
          return "Dracula defends itself against " + attacker.GetType().Name;
        }
    }