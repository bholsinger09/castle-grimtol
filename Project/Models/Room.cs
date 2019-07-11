using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;

namespace CastleGrimtol.Project.Models
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }

    //we should add a virtural method for room go 

    //we should add print method to welcome user to room


    public Room(string name, string description)
    {
      Name = name;
      Description = description;
    }




  }
}