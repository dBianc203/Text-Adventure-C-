using System;

abstract class Creature : IMobile, IActionable {

  public string name {get; set;}
  public int x {get; set;}
  public int y {get; set;}
  public int HP {get; set;}
  public int speed {get; set;}
  public Direction facing {get; set;}

  public Race racepick {get; set;}

  public bool Darkvision { get; protected set; } 
  public string Resistances { get; protected set; }
  public int Initiative {get; set;}
  private int[] attributes;
 // public Item[] inventory {get; set;}
  public int ArmorClass { get; set; }
  

  public int Strength
        {
            get
            {
                return attributes[0];
            }

            protected set
            {
                attributes[0] = value;
            }
        }

        public int Dexterity
        {
            get
            {
                return attributes[1];
            }

            protected set
            {
                attributes[1] = value;
            }
        }

        public int Constitution
        {
            get
            {
                return attributes[2];
            }

            protected set
            {
                attributes[2] = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return attributes[3];
            }

            protected set
            {
                attributes[3] = value;
            }
        }

        public int Wisdom
        {
            get
            {
                return attributes[4];
            }

            protected set
            {
                attributes[4] = value;
            }
        }

        public int Charisma
        {
            get
            {
                return attributes[5];
            }

            protected set
            {
                attributes[5] = value;
            }
        }

  

  public Creature() {
    this.name = "";
    this.racepick = Race.Monster;
    this.x = 0;
    this.y = 0;
    this.HP = 0;
    this.speed = 0;
    this.attributes = new int[6];
    this.ArmorClass = 0; 
    this.facing = Direction.NORTH;
    this.Darkvision = false;
    this.Resistances = "";
    
  }

  public void MoveNorth() {
    this.y = this.y + this.speed;
  }

  public void MoveNorthWest() {
    this.y = this.y + this.speed;
    this.x = this.x - this.speed;
  }

  public void MoveNorthEast(){
    this.y = this.y + this.speed;
    this.x = this.x + this.speed;
  }

  public void MoveSouthEast(){
    this.y = this.y - this.speed;
    this.x = this.x + this.speed;
  }

  public void MoveSouthWest(){
    this.y = this.y - this.speed;
    this.x = this.x - this.speed;
  }

  public void MoveWest() {
    this.x = this.x - this.speed;
  }

  public void MoveEast() {
    this.x = this.x + this.speed;
  }

  public void MoveSouth(){
    this.y = this.y - this.speed;
  }

  public void turn(int degrees) {
    this.facing = this.facing + degrees;
  }
  public void ChangeRace(int change) {
    this.racepick = this.racepick + change;
  }

  public void GoTo(int x, int y) {
    this.x = x;
    this.y = y;
  }
// add things for these 
  public void MoveFoward(){
      if (this.facing == Direction.NORTH){
        MoveNorth();
      }
      else if (this.facing == Direction.EAST){
        MoveEast();
      }
      else if (this.facing == Direction.WEST){
        MoveWest();
      }
      else if (this.facing == Direction.SOUTH){
        MoveSouth();
      }
      else if (this.facing == Direction.SOUTHWEST){
        MoveSouthWest();
      }
      else if (this.facing == Direction.SOUTHEAST){
        MoveSouthEast();
      }
      else if (this.facing == Direction.NORTHWEST){
        MoveNorthWest();
      }
      else if (this.facing == Direction.NORTHEAST){
        MoveNorthEast();
      }
  }

  public void Face(Direction dir){
    System.Console.WriteLine("What direction would you like to face? ");
    string DirectionFace = System.Console.ReadLine();
    if(DirectionFace == "NorthWest"){
      this.facing = Direction.NORTHWEST;
      System.Console.WriteLine("You are now facing NorthWest");
    }
    if(DirectionFace == "NorthEast"){
      this.facing = Direction.NORTHEAST;
      System.Console.WriteLine("You are now facing NorthEast");
    }
    if(DirectionFace == "SouthWest"){
      this.facing = Direction.SOUTHWEST;
      System.Console.WriteLine("You are now facing SouthWest");
    }
    if(DirectionFace == "SouthEast"){
      this.facing = Direction.SOUTHEAST;
      System.Console.WriteLine("You are now facing SouthEast");
    }
    if(DirectionFace == "North"){
      this.facing = Direction.NORTH;
      System.Console.WriteLine("You are now facing North");
    }
    if(DirectionFace == "West"){
      this.facing = Direction.WEST;
      System.Console.WriteLine("You are now facing West");
    }
    if(DirectionFace == "South"){
      this.facing = Direction.SOUTH;
      System.Console.WriteLine("You are now facing South");
    }
    if(DirectionFace == "East"){
      this.facing = Direction.EAST;
      System.Console.WriteLine("You are now facing East");
    }

  }


  public override string ToString()
  {
    string output =
        "|====================================|\n" +
        "|" +this.GetType().Name + " " + this.name +
        "\n|Race: " + this.racepick +"                    |" + 
        "\n|HP: " + this.HP + "                              |" +
        "\n|Location: (" + this.x + ", " + this.y + ")                    |" +
        "\n|Speed: " + this.speed +   "                            |" +
        "\n|Facing: " + this.facing + "                       |" + 
        "\n|====================================|\n" +
        "|STR: " + this.Strength +  "                             |"+
            "\n|DEX: " + this.Dexterity +  "                             |"+
            "\n|CON: " + this.Constitution +  "                             |"+
            "\n|INT: " + this.Intelligence +  "                             |"+
            "\n|WIS: " + this.Wisdom +  "                             |"+
            "\n|CHA: " + this.Charisma +  "                             |"+
            "\n|====================================|\n" +
            "|AC: " + this.ArmorClass + "                              |" +
            "\n|Resistances: " + this.Resistances +"                       |"+          
            "\n|Darkvision: " + this.Darkvision + "                   |\n" +
            "|____________________________________|";
            
        
    return output;
  }






  public abstract string Attack(Creature def);

  public abstract string Defend();
  

  public abstract string Use(IUsable used);

  public abstract string DefendAgainst(Creature attacker);

  public abstract string Rest();
}