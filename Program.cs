using System;
using CastleGrimtol.Project;
using CastleGrimtol.Project.Models;


namespace CastleGrimtol
{
  public class Program
  {
    public static void Main(string[] args)
    {

            Player Ben = new Player("ben");
            Room StartingRoom = new Room("roomStart", "starting in this room");
            GameService GameService = new GameService(Ben,StartingRoom);
          

            GameService.StartGame();
    }
  }
}
