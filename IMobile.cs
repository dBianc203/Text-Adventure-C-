using System;

interface IMobile : ILocatable {

  int speed {get; set;}

  void MoveNorth();
  void MoveWest();
  void MoveEast();
  void MoveSouth();
  void GoTo(int x, int y);
  void MoveFoward();
  void Face(Direction dir);

  void turn(int degrees);

}