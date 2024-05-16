namespace OOV_Prov
{
    public class Knight : Entity
    {

        public Knight() : base("Knight",75,5) 
        {

        }

    


     public override void TakeDamange(int amount) //ändrade att han tar mindre skada. 
     {

        Hp -=amount/2;

     
     }
    }
}