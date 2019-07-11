using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using System;

namespace CastleGrimtol.Project.Models
{
  public class Player : IPlayer
  {
    public string PlayerName { get; set; }
    public List<Item> Inventory { get; set; }

    public virtual void MovePlayer()
    {
      throw new NotImplementedException("Must provide Go method");
      //this will be overrided in gameservice 
    }

    public Player(string playerName)
    {
      PlayerName = playerName;
      Inventory = new List<Item>();
    }
  }
}