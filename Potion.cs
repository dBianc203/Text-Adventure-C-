using System;

abstract class Potion : Item {

  public Creature recipient {get; set;}
  public string SuccessMessage = "You successfully used this potion ";
  public string FailureMessage = "You failed to use this potion ";
  public Potion(String n) : base(n, 1) {
    
  }

}