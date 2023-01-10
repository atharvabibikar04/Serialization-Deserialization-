namespace Student;
// using System.Text.Json;
// using System.Text.Json.Serialization;
 [Serializable]
public class Stud
{
public int Id{get;set;}
public  string Name{get;set;}

public double Marks{get;set;}

public bool Pass{get;set;}


//default constructor
public Stud(){
    this.Id=1;
    this.Name="NA";
    this.Marks=0.0;
    this.Pass=true;
}

public Stud(int Id,string Name,double Marks,bool Pass){
    this.Id=Id;
    this.Name=Name;
    this.Marks=Marks;
    this.Pass=Pass;
}

    public override string ToString()
    {
        return ("Id- "+Id+" Name- "+Name+" Marks- "+Marks+ " Pass- "+Pass);
    }
}
