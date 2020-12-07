using System;

class ArmorPotion : Potion {

public ArmorPotion() : base("Potion of Armor Restoration"){
  
}
public override bool used() {

bool used = base.used();
if(used) {
  this.recipient.ArmorClass +=5;
}

  return used;
  }
}