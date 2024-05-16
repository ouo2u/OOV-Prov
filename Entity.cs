using System.Xml;

namespace OOV_Prov
{
    
    public class Entity //
    {
        private string name;
        private int hp;

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

         public Entity(string name,int hp,int dmg)
    {
        this.name=name;
        this.hp=hp;
        this.dmg=dmg;
    }

    public void Attack()
    {
        Console.WriteLine(name+"Attacking!");

    }
     public virtual void TakeDamange(int amount)
     {

        hp -=amount;
        hp=(int)MathF.Max(hp,0);

     }
    }
    
   
}