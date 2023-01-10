using System.Collections.Generic;
using Student;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

List<Stud> li =new List<Stud>();
Stud s1=new Stud(1,"Atharva",80.0,true);
Stud s2=new Stud(2,"Rohit",80.0,true);
Stud s3=new Stud(3,"Akshay",80.0,true);

li.Add(s1);
li.Add(s2);
li.Add(s3);


foreach (Stud s in li)
{
    Console.WriteLine(s);
}


//serialization code
//  var option =new JsonSerializerOptions{IncludeFields=true};
// var LoginJson=JsonSerializer.Serialize<List<Stud>>(li,option);
string fileName=@"E:\Atharva and Raju\DOT NET\Practice\Assignment\login.json";
// // Console.WriteLine(LoginJson);
// File.WriteAllText(fileName,LoginJson);

//deserialization
string Sjson=File.ReadAllText(fileName);
var LogoutJson=JsonSerializer.Deserialize<List<Stud>>(Sjson);

foreach (Stud s in LogoutJson)
{
    Console.WriteLine(s);
}

