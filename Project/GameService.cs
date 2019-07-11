using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;
using System;

namespace CastleGrimtol.Project
{
  public class GameService : IGameService
  {
    public Room CurrentRoom { get; set; }
    //this gets and sets the current room
    public Player CurrentPlayer { get; set; }
    //this gets and sets current player

    public void GetUserInput()
    {
      //this will have write methods for options for player see planets lines 62-77
      CurrentRoom.Print();
      CurrentRoom.PrintOptions();
      string input = Console.ReadLine().ToLower();
      Console.Clear();
      string[] inputs = input.Split(' ');
      string command = inputs[0];
      //command at that point should be what the user types
      //example command should be 'n' north direction
      string option = "";
      if (inputs.Length > 1)
      {
        option = inputs[1];
        //sets option to input direction 
      }
      switch (command)
      {
        case "go south":
          CurrentRoom = (Room)CurrentRoom.GoToRoom(option);
          break;
        case "go north":
          CurrentRoom = (Room)CurrentRoom.GoToRoom(option);

          break;
        case "go east":
          CurrentRoom = (Room)CurrentRoom.GoToRoom(option);
          break;
        case "go west":
          CurrentRoom = (Room)CurrentRoom.GoToRoom(option);
          break;

      }


    }
    public void Go(string direction)
    {


      CurrentRoom = (Room)CurrentRoom.GoToRoom(direction);

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
      //this sets running to false 
      throw new System.NotImplementedException();
    }

    public void Reset()
    {
      //this reset running from false to true
      throw new System.NotImplementedException();
    }

    public void Setup()
    {

      Room Room1 = new Room("StarterRoom", "Room user starts in");
      Room Room2 = new Room("SecondRoom", "Room next to starter room");
      Room Room3 = new Room("ThirdRoom", "Room next to final room");
      Room Room4 = new Room("FinalRoom", "Last Room");



      //build rooms

      //build relationships of rooms to each other

      //buiding relationships with rooms and exits
      Room1.Exits.Add("east", Room2);
      Room2.Exits.Add("west", Room1);
      Room2.Exits.Add("north", Room3);
      Room3.Exits.Add("south", Room2);
      Room1.Exits.Add("west", Room4);

      //                                                     [room 3-final wrong room]north of room 2
      // [room 4 final right room] --west[room 1] -go east   [room 2] south of room 3



    }

    public void StartGame()
    {
      throw new System.NotImplementedException();

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

    public GameService()
    {
      //may also add name of player here 
      Setup();
    }


  }
}