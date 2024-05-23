namespace OOV_Prov
{
    public class Knight : Entity
    {

        public Knight() : base("Knight",75,5) //stats för min knight
        {

        }

    


     public override void TakeDamange(int amount) //ändrade att han tar halften skada. 
     {

        hp -=amount/2;
        hp=(int)MathF.Max(hp,0);
        Console.WriteLine(name +" has "+ hp+ "HP" );
        Console.WriteLine("");
        

     
     }
    }
}