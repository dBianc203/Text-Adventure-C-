using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PlayerCharacter : Creature
    {
     
      public Item[] inventory {get; set;}
      public int[] dice = new int[4];

      public void RollStats(){
        for (int die = 0; die < dice.Length; die++)
            {
                  dice[die] = Dice.Roll(6);
            }
      }
      
        public PlayerCharacter(string n,int s) : base()
        {

            this.name = n;
           // this.x = x;
           // this.y = y;
            this.speed = s;
            
            RollStats();
            System.Console.WriteLine("Here is your strength stat, do you want to keep it?(You can only re-Roll 2 times) [Yes or No] ");
            System.Console.WriteLine(dice.Sum()-dice.Min());
            string StrPick = System.Console.ReadLine().ToLower();
            
            if(StrPick == "yes"){
              this.Strength = dice.Sum() - dice.Min();
            }
            else if (StrPick == "no"){
              RollStats();
              System.Console.WriteLine("Keep this stat? [Yes or No] ");
              System.Console.WriteLine(dice.Sum() - dice.Min());
              string StrPick2 = System.Console.ReadLine().ToLower();
              if (StrPick2 == "yes"){
              this.Strength = dice.Sum() - dice.Min();
              }
              else if(StrPick2 == "no"){
                RollStats();
                System.Console.WriteLine("Here is your Strength stat ");
                System.Console.WriteLine(dice.Sum() - dice.Min());
                this.Strength = dice.Sum() - dice.Min();
              }
            }

            RollStats();
            System.Console.WriteLine("Here is your Dexterity stat, do you want to keep it?(You can only re-roll 2 times)[Yes or No] ");
            System.Console.WriteLine(dice.Sum()-dice.Min());
            string DexPick = System.Console.ReadLine().ToLower();
            
            if(DexPick == "yes"){
              this.Dexterity = dice.Sum() - dice.Min();
            }
            else if (DexPick == "no"){
              RollStats();
              System.Console.WriteLine("Keep this stat?[Yes or No] ");
              System.Console.WriteLine(dice.Sum() - dice.Min());
              string DexPick2 = System.Console.ReadLine().ToLower();
              if (DexPick2 == "yes"){
              this.Dexterity = dice.Sum() - dice.Min();
              }
              else if(DexPick2 == "no"){
                RollStats();
                System.Console.WriteLine("Here is your Dexterity stat ");
                System.Console.WriteLine(dice.Sum() - dice.Min());
                this.Dexterity = dice.Sum() - dice.Min();
              }
            }

            RollStats();
            System.Console.WriteLine("Here is your Constitution stat, do you want to keep it?(You can only re-roll 2 times)[Yes or No] ");
            System.Console.WriteLine(dice.Sum()-dice.Min());
            string ConPick = System.Console.ReadLine().ToLower();
            
            if(ConPick == "yes"){
              this.Constitution = dice.Sum() - dice.Min();
            }
            else if (ConPick == "no"){
              RollStats();
              System.Console.WriteLine("Keep this stat?[Yes or No] ");
              System.Console.WriteLine(dice.Sum() - dice.Min());
              string ConnPick2 = System.Console.ReadLine().ToLower();
              if (ConnPick2 == "yes"){
              this.Constitution = dice.Sum() - dice.Min();
              }
              else if(ConnPick2 == "no"){
                RollStats();
                System.Console.WriteLine("Here is your Constitution stat ");
                System.Console.WriteLine(dice.Sum() - dice.Min());
                this.Constitution = dice.Sum() - dice.Min();
              }
            }

            RollStats();
            System.Console.WriteLine("Here is your Intelligence stat, do you want to keep it?(You can only re-roll 2 times)[Yes or No] ");
            System.Console.WriteLine(dice.Sum()-dice.Min());
            string IntelPick = System.Console.ReadLine().ToLower();
            
            if(IntelPick == "yes"){
              this.Intelligence = dice.Sum() - dice.Min();
            }
            else if (IntelPick == "no"){
              RollStats();
              System.Console.WriteLine("Keep this stat?[Yes or No] ");
              System.Console.WriteLine(dice.Sum() - dice.Min());
              string IntelPick2 = System.Console.ReadLine().ToLower();
              if (IntelPick2 == "yes"){
              this.Intelligence = dice.Sum() - dice.Min();
              }
              else if(IntelPick2 == "no"){
                RollStats();
                System.Console.WriteLine("Here is your Intelligence stat ");
                System.Console.WriteLine(dice.Sum() - dice.Min());
                this.Intelligence = dice.Sum() - dice.Min();
              }
            }

            RollStats();
            System.Console.WriteLine("Here is your Wisdom stat, do you want to keep it?(You can only re-roll 2 times)[Yes or No] ");
            System.Console.WriteLine(dice.Sum()-dice.Min());
            string WisPick = System.Console.ReadLine().ToLower();
            
            if(WisPick == "yes"){
              this.Wisdom = dice.Sum() - dice.Min();
            }
            else if (WisPick == "no"){
              RollStats();
              System.Console.WriteLine("Keep this stat?[Yes or No] ");
              System.Console.WriteLine(dice.Sum() - dice.Min());
              string WisPick2 = System.Console.ReadLine().ToLower();
              if (WisPick2 == "yes"){
              this.Wisdom = dice.Sum() - dice.Min();
              }
              else if(WisPick2 == "no"){
                RollStats();
                System.Console.WriteLine("Here is your Wisdom stat ");
                System.Console.WriteLine(dice.Sum() - dice.Min());
                this.Wisdom = dice.Sum() - dice.Min();
              }
            }

            RollStats();
            System.Console.WriteLine("Here is your Charisma stat, do you want to keep it?(You can only re-roll 2 times)[Yes or No] ");
            System.Console.WriteLine(dice.Sum()-dice.Min());
            string CharPick = System.Console.ReadLine().ToLower();
            
            if(CharPick == "yes"){
              this.Charisma = dice.Sum() - dice.Min();
            }
            else if (CharPick == "no"){
              RollStats();
              System.Console.WriteLine("Keep this stat?[Yes or No] ");
              System.Console.WriteLine(dice.Sum() - dice.Min());
              string CharPick2 = System.Console.ReadLine().ToLower();
              if (CharPick2 == "yes"){
              this.Charisma = dice.Sum() - dice.Min();
              }
              else if(CharPick2 == "no"){
                RollStats();
                System.Console.WriteLine("Here is your Charisma stat ");
                System.Console.WriteLine(dice.Sum() - dice.Min());
                this.Charisma = dice.Sum() - dice.Min();
              }
            }
            
            this.HP = 65 + (this.Constitution - 3) / 2;

            this.ArmorClass = 10 + (this.Dexterity - 10) / 2;
            this.x = 0;
            this.y = 0;

            this.inventory = new Item[4];
        }


public bool addToInventory(Item i) {
    
    for (int index = 0; index < inventory.Length; index++) {
      
      if (inventory[index] == null) {
        inventory[index] = i;
        return true;
      }
    }
    
    return false;
  }

  public Item removeFromInventory(int slot) {

    Item retrieved = inventory[slot-1];
    inventory[slot-1] = null;
    return retrieved;
  }

  public string showInventory() {
    string output = 
      "\n========================\n" +
      "        Inventory" +
      "\n========================\n";
    for (int index = 0; index < inventory.Length; index++) {
      if (inventory[index] == null) {
        output = output + (index+1) + ": ... \n";
      } else {
        output = output + (index+1) + ": " + inventory[index].name + "\n";
      }

    }
    output = output + "========================\n";
    return output;

  }
        public string Punch(Creature def)
        {
            int toHit = Dice.Roll(5, 5);
            if (toHit > def.ArmorClass || toHit == 25)
            {
                int damage = Dice.Roll(6, 6);
                def.HP -= damage;
                return "Player swings its fists at " + def.GetType().Name +
                        " and deals " + damage + " damage!";
            }
            else
            {
                return "Player misses its swings at " + def.GetType().Name + " and misses!";
            }
        }
          public string Kick(Creature def)
        {
            int toHit = Dice.Roll(5, 8);
            if (toHit > def.ArmorClass || toHit == 25)
            {
                int damage = Dice.Roll(5, 7);
                def.HP -= damage;
                return "Player kicks its feet at " + def.GetType().Name +
                        " and deals " + damage + " damage!";
            }
            else
            {
                return "Player kicks its feet at " + def.GetType().Name + " and misses!";
            }
        }

        /*
        public override string SuccessMessage(){
          return 
        }
        */
        public override string Attack(Creature def){
               if (Dice.Roll(2) == 1)
            {
                return Punch(def);
            }
            else
            {
                return Kick(def);
            }
        }
          public override string Use(IUsable used){
          return "Player uses " + used.GetType().Name;
        }
     
        public override string Rest(){
          return "Player rests this turn";
        }

        public override string Defend(){
        return "Player Defends itself";
        }

        public override string DefendAgainst(Creature attacker){
          return "Player defends itself against " + attacker.GetType().Name;
        }


        }
    