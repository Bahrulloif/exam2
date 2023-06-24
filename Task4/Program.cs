List<Person> users = new List<Person>();

for (int i = 1; i <= 5; i++)
{
    Person user = new Person();
    System.Console.WriteLine("FirstName");
    Console.ReadLine();
    System.Console.WriteLine("LastName");
    Console.ReadLine();
    System.Console.WriteLine("UserName");
    Console.ReadLine();
    System.Console.WriteLine("Password");
    Console.ReadLine();
    users.Add(user);
}
foreach (var user in users)
{
    System.Console.WriteLine(user.Login());
    System.Console.WriteLine(user.GetInfo());
}
