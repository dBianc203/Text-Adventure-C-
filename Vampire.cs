using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    abstract class Vampire : Creature
    {
        /* Fields */
        /* Properties */
        /* Constructors */

        public Vampire() : base()
        {      
            this.Darkvision = true;
            this.Resistances += "Death ";
        }
        /* Methods */
    }