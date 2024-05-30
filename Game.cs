using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace OOV_Prov
{
    public class Game
    {
        public void Meny() //start meny för spelet
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
        public void Play() 
        {
            Player player=new Player();
            Knight knight=new Knight();
            Archer archer=new Archer();

            List<Entity> enemies=new List<Entity>(); //lista för fiender 
            enemies.Add(knight);
            enemies.Add(archer);

            Random rnd= new Random();

            while(true) //En loop tills spelet är slut
            {
                int turn= rnd.Next(1, 4);

                if(turn == 1) //player tur
                {
                    player.Attack();
                    if(knight.Hp < archer.Hp)
                    {
                        archer.TakeDamange(player.Dmg);
                    }
                    else
                    {
                        knight.TakeDamange(player.Dmg);
                    }

                }
                else if(turn == 2 && archer.Hp > 0) //archer tur
                {
                    archer.Attack();
                    player.TakeDamange(archer.Dmg);
                }

                else if(turn == 3 && knight.Hp > 0) // knight tur
                {
                    knight.Attack();
                    player.TakeDamange(knight.Dmg);
                }

                if(player.Hp <= 0) //detta för visa ifall jag förlura
                {
                    break;
                }
                else if (knight.Hp <= 0 && archer.Hp <= 0) //detta för visa att jag vann
                {
                    break;
                }
                Thread.Sleep(550);
            }
            
            StreamWriter sw= new StreamWriter("Textfil.txt", true); //skapa filen 
            sw.WriteLine(player.Hp); //spara hp
            sw.Close(); //stänger filen 
            
            if(player.Hp <= 0) //om förlura det blir detta
            {

                Console.WriteLine("");
                Console.WriteLine("du förlorade");

            }
            else //om vinner blir detta
            {

                Console.WriteLine("");
                Console.WriteLine("du vann");

            }
            Meny();
        }  
    }
}