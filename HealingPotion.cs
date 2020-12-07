using System;

class HealingPotion : Potion {

  public HealingPotion() : base("Potion of Healing") {

  }

  public override bool used() {
    
    bool used = base.used();
    if (used) {
      this.recipient.HP += 25;
    } 

    return used;

  }

  

}