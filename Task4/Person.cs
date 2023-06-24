public class Person
{
    public string? FirsName { get; set; }
    public string? LastName { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }

  

   public string Login()
    {       
            if (UserName == "Admin" && Password=="12345")
            {
                return $"Login successful! Welcome mr {FirsName} , {LastName}";
            } else{
                return "Login Failed";
            }
        
        
    }

   public string GetInfo(){
        return $"{FirsName}   {LastName}   {UserName}   {Password}";
    }
}