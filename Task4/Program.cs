List<Person> users = new List<Person>();

for (int i = 1; i <= 2; i++)
{
    System.Console.WriteLine($"Uer {i}");
    Person user = new Person();
    System.Console.WriteLine("FirstName");
    user.FirsName = Console.ReadLine();
    System.Console.WriteLine("LastName");
    user.LastName = Console.ReadLine();
    System.Console.WriteLine("UserName");
    user.UserName = Console.ReadLine();
    System.Console.WriteLine("Password");
    user.Password = Console.ReadLine();
    users.Add(user);
}
foreach (var user in users)
{

    System.Console.WriteLine(user.Login());
    System.Console.WriteLine(user.GetInfo());
}
