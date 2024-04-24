using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Methods
{
    public Methods(){}

    public string ReturnText(string text)
    {
        return text;
    }

    public void GetEnvironmentDetails(){
        foreach(var drive in Environment.GetLogicalDrives())
            Console.WriteLine("Drive: {0}", drive);
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Procs: {0}", Environment.ProcessorCount);
        Console.WriteLine(".NET Version: {0}", Environment.Version);     
    }    

    public void CreateUserFromConsole()
    {
        Console.WriteLine("Enter User Name:");
        var userName = Console.ReadLine();
        Console.WriteLine("Enter User Username");
        var userUserName = Console.ReadLine();

        var user = new User()
        {
            Name = userName,
            Username = userUserName
        };

        Console.WriteLine("User created: Name: {0}, Username: {1}", user.Name, user.Username);
    }    
}




public class User
{
    public string Name {get; set;}
    public string Username {get; set;}
}