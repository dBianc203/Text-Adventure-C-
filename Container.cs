using System;

class Container<T> where T : class {
private bool locked;
private T[] Entries;


public Container(int Size) {
Entries = new T[16];
locked = false;
}

public int Size() {
  return Entries.Length;
}

public bool isEmpty() {
  bool empty = true;
    for (int index = 0; index < this.Size(); index++) {
      if (Entries[index] != null) {
        empty = false;
      }
    }
    return empty;
  }

public bool isFull() {
  bool full = true;
    for (int index = 0; index < this.Size(); index++) {
      if (Entries[index] == null) {
        full = false;
        }
     }
      return full;
  }

  public void empty() {
    for (int index = 0; index < this.Size(); index++) {
      Entries[index] = null; 
    }
  }

    public string listContents() {
    string contents = "";
    for (int index = 0; index < this.Size(); index++) {  
      contents = contents + (index+1) + ": " + Entries[index] + "\n";
    } 
    return contents;
  }

    public bool Add(T Entry) {
    if (this.isFull()) {
      return false;
    } else {
     
      for (int index = 0; index < this.Size(); index++) {
        if (Entries[index] == null) {
          Entries[index] = Entry;
          return true;
        }
      }
    }  
    return false; 
  }
    public bool Remove(T Entry) {
    if (isLocked()) {
      return false; 
    } else {
       for (int index = 0; index < this.Size(); index++) {  
         if (Entry.Equals(Entries[index])) {
           Entries[index] = null;
           return true;
         }
       }
       return false;
    }
  }
    public bool Remove(int slot) {
    if (Entries[slot-1] == null || isLocked()) {
      return false; 
    } else {
      Entries[slot-1] = null;
      return true;
    }
  }
    public T get(T Entry) {
    if (!isLocked()) {
       for (int index = 0; index < this.Size(); index++) { 
          if (Entry.Equals(Entries[index])) {
            return Entries[index];
          }
       }
       
       return null;
    } else {
      return null;
    }
  }
    public T get(int slot) {
    if (!isLocked()) {
      return Entries[slot-1];
    } else {
      return null;
    }
  }

    public bool isLocked() {
    return locked;
  }
  
  public void Lock() {
    this.locked = true;
  }

  public void Unlock() {
    this.locked = false;
  }
  public override string ToString(){
    string output = "Inventory \n" + listContents();

    return output; 
  }
}