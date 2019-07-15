using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using System;

namespace CastleGrimtol.Project.Models
{
  public class Player : IPlayer, IRoom
  {
    public string PlayerName { get; set; }
    public List<Item> Inventory { get; set; }

    #region Room
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }

    #endregion

    // public MovePlayer(string direction)
    // {
    //   Room OccupiedRoom = new Room("occupied", "setting occupied room");
    //   if (OccupiedRoom.Name == direction){
    //     return OccupiedRoom.Description;
    //   }


    // }

    public Player(string playerName)
    {
      PlayerName = playerName;
      Inventory = new List<Item>();
    }
  }
}