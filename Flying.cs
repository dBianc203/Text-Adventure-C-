using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    abstract class Flying : Creature
    {
        /* Fields */
        /* Properties */
        /* Constructors */

        public Flying() : base()
        {      
            this.Darkvision = false;
            this.Resistances += "Fire ";
        }
        /* Methods */
    }
