namespace BooksModel;

public class User
{
    
    // public string UserId {get; set;}

    public string Username {get;set;}

    public string Email {get; set;} 

    public string Password {get; set;}

    public bool IsAdmin {get; set;} = false;

}

//running json server
//--> json-server data.json --watch