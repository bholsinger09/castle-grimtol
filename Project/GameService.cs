using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;
using System.Threading;
using System;

namespace CastleGrimtol.Project
{
  
  public static class CastleMap
  {

        //                                                             [room 2-final wrong room]north 
        // [room 3 final right room] --west[room 0 starter] -go east   [room 1 locked] south of room 3
        public static List<MapItem> ListItems()
      {
            var rooms = new List<MapItem>();
            var room = new MapItem();
            room.Init("starterRoom", "You start here", 0, new Dictionary<int, string> { { 3, "west"}, {1, "east" }});
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

    public class GameService : IGameService
  {
    private bool running = true;

    public Room CurrentRoom { get; set; }
    //this gets and sets the current room
    //set this up in setup
    public Player CurrentPlayer { get; set; }
    //this gets and sets current player
    //set this up in setup 

    public void GetUserInput()
    {

      //CurrentRoom.Print();
      //CurrentRoom.PrintOptions();
      //string input = Console.ReadLine().ToLower();
     // Console.WriteLine("checking input");

      //string[] inputs = input.Split(' ');
      //example input "go north"
      //string array for input is equal to spitting the input at go and at north
      //go is index 0 and north is index 1


     // string option = "";
      //here we check to make sure input string length is greater than one
      // if (inputs.Length > 1)
      // {
      //   Console.WriteLine("input string length is greater than one");
      //   option = inputs[1];
      //   //input at index 1 is the direction entered
      //   //option now becomes direction
      //   Console.WriteLine("this is the direction chosen: " + option);

      // }
      // Console.WriteLine("should be entering switch");
      // Console.WriteLine("checking value of input: " + input);
      // Console.WriteLine("");
      // switch (input)
      // {
      //   case "go south":
      //     Console.WriteLine("going south");
      //     Go(option);
      //     break;
      //   case "go north":
      //     Console.WriteLine("going north");
      //     Go(option);

      //     break;
      //   case "go east":
      //     Console.WriteLine("going east");
      //     Go(option);
      //     break;
      //   case "go west":
      //     Console.WriteLine("going west");
      //     Go(option);
      //     break;
      //   case "default":
      //     Console.Write("please choose valid option");
      //     break;

      // }


    }
    public void Go(string direction)
    {

      Console.WriteLine("going to:  " + direction);
      //CurrentRoom = (Room)CurrentRoom.GoToRoom(direction);



      //call look
      //print some thing


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

    public void Setup()
    {
            var roomMapListing = CastleMap.ListItems();
            var rooms = new List<Room>();
            for (var i = 1; i < roomMapListing.Count; i++)
            {
                var roomML = roomMapListing[i];
                Room roomInstance = new Room(roomML.RoomName, roomML.RoomDescription, i);
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

    public GameService(Player currentPlayer, Room currentRoom)
    {
      currentPlayer = CurrentPlayer;
      currentRoom = CurrentRoom;

      Setup();
    }


  }
}