using Newtonsoft.Json;
using System;
using System.Text.Json;
public class Program
{
    public static void Main()
    {
        Dictionary<int, string> p = new Dictionary<int, string>();
       // Person[] p = new Person[6];
        p.Add(0,"Tom");
        p.Add(1,"Jenn");
        p.Add(2,"Ronny");
        p.Add(3,"Tom");
        p.Add(4,"Tolik");
        p.Add(5,"Jenn");
 

        
         List<string> s =  new List<string>();
        bool flag = true;
     
        for (int i = 0; i < p.Count; i++)
        {
            flag = true;
            foreach (var item in s)
            {
                if (item.Contains(p[i]))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                s.Add(p[i]);
        }
        string JS = JsonConvert.SerializeObject(s);

        Console.WriteLine(JS);

        //JsonConvert.DeserializeObject(JS)

    }


}
public class Person
{
    public string Name;
    public Person(string name) { Name = name; }

}