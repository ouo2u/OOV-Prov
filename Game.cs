using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace OOV_Prov
{
    public class Game
    {
        public static void Meny() //start för spelet
        {
            Console.WriteLine("Play:P");
            Console.WriteLine("Quit:Q");
        
            var input=Console.ReadKey();
            Console.Clear();

       switch (input.Key)
       {
        case ConsoleKey.P:
        Play();
         break;

        case ConsoleKey.Q:
        break;

        default:
        Console.WriteLine("write single key");
        Meny();
        break;

       }
       

      


    }
    public static void Play()
    {
        Player player=new Player();
        Knight knight=new Knight();
        Archer archer=new Archer();

        bool PlayerWon;

        Random rnd= new Random();

        while(true) //En loop tills matchen är slut
        {
            int turn= rnd.Next(1,7);

            if(turn==1 ||turn==2||turn==3||turn==4)
            {
                player.Attack();
                if(knight.Hp<archer.Hp)
                {

                }

            }



        }

    }
       
}
}