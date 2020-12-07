using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IUsable {

  string SuccessMessage { get;}
  string FailureMessage { get;}  
  int UsesLeft {get; set;}
  float UseChance {get; set;}
  bool used();

}