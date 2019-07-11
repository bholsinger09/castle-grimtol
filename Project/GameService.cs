using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;

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
      //this will have write methods for options for player

      throw new System.NotImplementedException();
    }

    public void Go(string direction)
    {
      // this will implement the directions user enters
      // this is where we move between rooms 
      throw new System.NotImplementedException();
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


      //build rooms

      //build relationships of rooms to each other

      //possible add relationships of rooms to player



    }

    public void StartGame()
    {
      throw new System.NotImplementedException();

      //while goes here
      //current location in while print
      //readline also goes here
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