using System.Collections.Generic;
using System;
using CastleGrimtol.Project.Interfaces;

namespace CastleGrimtol.Project.Models
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }






    public void Print()
    {
      Console.WriteLine($"Welcome to {Name}");
      //Name is the name of the room
      //this print should be accessed in gameservice
      // to define what is printed in each different room
    }

    public void PrintOptions()
    {
      Console.Write("type 'go next' to go to door , 'go previous' to go back to previous room, or 'find key' to find key to door that maybe locked");

    }


    public IRoom GoToRoom(string dir)
    {
      if (Exits.ContainsKey(dir))
      {
        return Exits[dir];
      }
      Console.WriteLine("Invalid direction");
      return this;
    }


    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Exits = new Dictionary<string, IRoom>();
      Items = new List<Item>();

    }




  }
}