using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;
using System.Threading;
using System;

namespace CastleGrimtol.Project
{

  #region Map
  public static class CastleMap
  {

    //                                                             [room 2-final wrong room]north 
    // [room 3 final right room] --west[room 0 starter] -go east   [room 1 locked] south of room 3
    public static List<MapItem> ListItems()
    {
      var rooms = new List<MapItem>();
      var room = new MapItem();
      room.Init("starterRoom", "You start here", 0, new Dictionary<int, string> { { 3, "west" }, { 1, "east" } });
      rooms.Add(room);
      room.Init("lockedRoom", "You start here", 1, new Dictionary<int, string> { { 0, "east" }, { 2, "north" } });
      rooms.Add(room);
      room.Init("NorthDeathTrap", "You start here", 2, new Dictionary<int, string> { { 1, "south" }, { 3, "west" } });
      rooms.Add(room);
      room.Init("WestFinalRoom", "You start here", 3, new Dictionary<int, string> { { 0, "east" }, { 3, "east" } });
      rooms.Add(room);
      return rooms;
    }
  }


  public struct MapItem
  {
    public string RoomName { get; set; }
    public string RoomDescription { get; set; }

    public int Key { get; set; }
    public Dictionary<int, string> Exits { get; set; }

    public void Init(string roomName, string roomDescription, int key, Dictionary<int, string> exits)
    {
      RoomName = RoomName;
      RoomDescription = RoomDescription;
      Key = key;
      Exits = Exits;
    }
  }

  #endregion
  public class GameService : IGameService
  {
    private bool running = true;

    public Room CurrentRoom { get; set; }
    //what if mutilple players - this should be tracked by player model
    //this gets and sets the current room
    //set this up in setup
    public Player CurrentPlayer { get; set; }
    //this gets and sets current player
    //set this up in setup 

    #region methods

    public void GetUserInput()
    {


      CurrentRoom.PrintOptions();
      string input = Console.ReadLine().ToLower();
      #region PastCode
      // Console.WriteLine("checking input");

      //string[] inputs = input.Split(' ');
      //example input "go north"
      //string array for input is equal to spitting the input at go and at north
      //go is index 0 and north is index 1


      //string option = "";
      //here we check to make sure input string length is greater than one
      //if (inputs.Length > 1)
      //{
      //   Console.WriteLine("input string length is greater than one");
      // option = inputs[1];
      //   //input at index 1 is the direction entered
      //   //option now becomes direction
      //   Console.WriteLine("this is the direction chosen: " + option);

      //}
      // Console.WriteLine("should be entering switch");
      // Console.WriteLine("checking value of input: " + input);
      // Console.WriteLine("");
      #endregion

      MapItem occupiedRoom;
      #region inputSwitch
      switch (input)
      {
        case "go south":
          Console.WriteLine("going south");
          Go();
          break;
        case "go north":
          Console.WriteLine("going north");
          Go();

          break;
        case "go east":
          Console.WriteLine("going east");
          Go();
          break;
        case "go west":
          Console.WriteLine("going west");
          Go();
          break;
        case "default":
          Console.Write("please choose valid option");
          break;

      }
      #endregion

    }
    public void Go(int key)
    {



      MapItem occupiedRoom;

      if (occupiedRoom.Exits.ContainsKey(key))
      {

      }

      #region pastCode
      //CurrentRoom = (Room)CurrentRoom.GoToRoom(direction);

      //if (Exits.ContainsKey(dir))
      // {
      //   Console.WriteLine("exits should contain direction used  " + dir);
      //   Console.WriteLine(Exits[dir]);
      //   return Exits[dir];
      // }
      // Console.WriteLine("Invalid direction");
      // return this;



      //call look
      //print some thing

      #endregion


      //Validate CurrentRoom.Exits contains the desired direction
      //if it does change the CurrentRoom

    }

    public void Help()
    {
      //this tells the user hints 
      throw new System.NotImplementedException();
    }

    public void Inventory()
    {
      //this addes item to inventory of user
      throw new System.NotImplementedException();
    }

    public void Look()
    {
      //this allows player to look for items in rooms 
      //this will also tell user what exits are available
      throw new System.NotImplementedException();
    }

    public void Quit()
    {
      running = false;
    }

    public void Reset()
    {
      //this reset running from false to true
      throw new System.NotImplementedException();
    }

    public void PrintWelcome()
    {
      Console.WriteLine($"Welcome to ");
      //Name is the name of the room
      //this print should be accessed in gameservice
      // to define what is printed in each different room
    }



    public void Setup()
    {
      var rooms = new List<Room>();
      foreach (MapItem roomMI in CastleMap.ListItems())
      {
        Room roomInstance = new Room(roomMI.RoomName, roomMI.RoomDescription, roomMI.Key);
        rooms.Add(roomInstance);
      }




      //build rooms

    }

    public void StartGame()
    {
      while (running)
      {
        Console.WriteLine("Welcome to Castle Grimstol.  What is your name?");
        string name = Console.ReadLine();

        Console.Clear();

        Console.WriteLine($"Rise and shine {name}");
        Thread.Sleep(500);
        Console.WriteLine("I want to play a game, the rules are simple.  ");
        Console.WriteLine("You are probably wondering where you are.  I'll tell you where you might be. You might be in the room that you die in. The choice is yours. As you may tell, you are in a Castle. You are playing the character of Codemonkey. Codemonkey and the love of his life is in the balance. ");
        Console.WriteLine("To continue yes/no the choice is yours");
        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
          Console.Clear();
          GetUserInput();
        }
        else if (response == "no")
        {
          Console.Write("Don't forget the rules...");
          System.Console.Write("Processing");
          for (int i = 0; i < 5; i++)
          {
            Thread.Sleep(500);
            Console.Write('.');
          }

          Quit();
        }
        else
        {
          Console.WriteLine("Your responce is invalid.  Don't forget the rules.");
          Thread.Sleep(500);
          Console.Clear();


        }







        //should print name of the room










      }
      //while goes here
      //current location in while print
      //call GetUserInput();
      //will also call the quit game here 
    }

    public void TakeItem(string itemName)
    {
      //this allows player to take item
      throw new System.NotImplementedException();
    }

    public void UseItem(string itemName)
    {
      //this lets player to use item
      throw new System.NotImplementedException();
    }

    #endregion

    public GameService(Player currentPlayer, Room currentRoom)
    {
      currentPlayer = CurrentPlayer;
      currentRoom = CurrentRoom;

      Setup();
    }


  }
}