using System;

abstract class Item : IUsable {

  public string name {get; set;}
  public int UsesLeft{get; set;}
  public string SuccessMessage { get;}
  public string FailureMessage { get;} 
  public float UseChance {get; set;}
 
  

  public virtual bool used() {

    if (UsesLeft > 0) {
      UsesLeft = UsesLeft - 1;
      return true;
    
    } else {
      return false;
    }
  }

  public Item(string n, int initc) {
    this.name = n;
    this.UsesLeft = initc;

  }

  public override string ToString() {
    return this.name + ", " + this.UsesLeft + " use(s) left.";
   
    
  }

}

