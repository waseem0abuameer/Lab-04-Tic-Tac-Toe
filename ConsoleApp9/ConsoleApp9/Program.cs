using Lab04_TicTacToe.Classes;
using System;

 namespace Lab04_TicTacToe

{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }
        static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("TIC_TAC_TOE GAME");
            Console.WriteLine("");
            Player p1=new Player();
            Player p2 = new Player();
            Console.WriteLine("Enter the name of the player 1");
            p1.Name =Console.ReadLine();
            p1.Marker = "X";
            Console.WriteLine("Enter the name of the player 1");
            p2.Name = Console.ReadLine();
            p2.Marker = "O";
            Console.WriteLine("");
            Game newG=new Game(p1,p2);
            newG.Play();
            Console.WriteLine("");




        }
    }
}
