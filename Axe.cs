using System;

class Axe : Weapon {

public Axe() : base ("Axe Weapon"){
  
}
 public override bool used() {

bool used = base.used();
if(used) {
  this.recipient.HP +=10;
  this.recipient.ArmorClass +=10;
}

  return used;
  }
}