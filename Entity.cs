using System.Xml;

namespace OOV_Prov
{
    
    public class Entity 
    {
        protected string name; //jag har den på protected eftersom jag ändra på det i knight
        protected int hp; //jag har den på protected eftersom jag ändra på det i knight

        private int dmg;

     public string Name
    {
        get {return name;}
        set {name=value;}
    }
    public int Hp
    {
        get {return hp;}
        set {hp=value;}
    }

    public int Dmg
    {
        get {return dmg;}
        set {dmg=value;}
    }

         public Entity(string name,int hp,int dmg) //sätta de för att använda på andra klasser. 
    {
        this.name=name;
        this.hp=hp;
        this.dmg=dmg;
    }

    public void Attack() //en metod för visa att jag attackerar
    {
        Console.WriteLine(name+" Attacking!");
        Console.WriteLine("");
        Console.WriteLine("");

    }
     public virtual void TakeDamange(int amount) //detta är för alla fiende som kan skapas senare
     {

        hp -=amount;
        hp=(int)MathF.Max(hp,0);
        Console.WriteLine(name +" has "+ hp +"HP");
        Console.WriteLine("");

     }
    }
    
   
}