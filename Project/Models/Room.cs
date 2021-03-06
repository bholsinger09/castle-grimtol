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
    //public int Key { get; set; }




    public string Print()
    {
      Console.WriteLine($"Welcome to {Name}");
      return "Welcome to {Name}";
      //Name is the name of the room
      //this print should be accessed in gameservice
      // to define what is printed in each different room
    }


    //using printoptions because of exits
    public void PrintOptions()
    {
      Console.WriteLine("There are a total of 4 rooms in this Castle.  Each room has between one or two doors.  The directions you can go are North, South, East and West.  Each room is a two dimention square. Choose wisely.");
      Console.Write("type 'go north', 'go south', 'to west', or 'go east' to go east.  ");
      foreach (var exit in Exits)
      {
        Console.Write("Current exits: " + exit.Key + " : ");
      }

    }


    public IRoom GoToRoom(string dir)
    {


      Console.WriteLine("using method. going to : " + dir);
      if (Exits.ContainsKey(dir))
      {
        Console.WriteLine("exits should contain direction used  " + dir);
        //Console.WriteLine(Exits[dir]);
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
      // Key = key;
    }




  }
}