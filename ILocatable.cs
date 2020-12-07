using System;

interface ILocatable {

  /* world coordinates */
  int x { get; set; }
  int y { get; set; }

  Direction facing { get; set; }


}