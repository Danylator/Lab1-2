using Newtonsoft.Json;
using System;
using System.Text.Json;
public class Program
{
    public static void Main()
    {
        Person[] p = new Person[6];
        p[0] = new Person("Tom");
        p[1] = new Person("Jenn");
        p[2] = new Person("Ronny");
        p[3] = new Person("Tom");
        p[4] = new Person("Tolik");
        p[5] = new Person("Jenn");


        List<Person> s = new List<Person>();
        bool flag = true;
        for (int i = 0; i < p.Length; i++)
        {
            flag = true;
            foreach (var item in s)
            {
                if (item.Name == p[i].Name)
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