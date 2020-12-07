using System; 

abstract class Weapon : Item {

public Creature recipient{get; set;}
public string SuccessMessage = "You successfully used this Weapon ";
public string FailureMessage = "You failed to use this Weapon ";
public Weapon(string Name) : base(Name, 1) {

}



}