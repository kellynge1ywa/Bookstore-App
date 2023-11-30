using BooksModel;
using BookStore.Services;

namespace BookStore;

public class UserController
{
    UserServices userServices= new UserServices();
    public async Task Init()
    {
        Console.WriteLine("Select an option: \n 1. Register \n 2. Login \n 3. Exit ");
        var userOption=Console.ReadLine();

        bool selectedOption= int.TryParse(userOption, out int selected);

        await PageRedirect(selected);


    }

   

    public async Task PageRedirect(int selected){
        switch(selected){
            case 1:
            Console.WriteLine($"Welcome to register page");
            await SignUpUi();
            break;
             case 2:
            Console.WriteLine($"Welcome to login page");
            break;
             case 3:
            Console.WriteLine($"B");
            await Init();
            break;
            
        }

    }

    public async Task SignUpUi(){
        Console.WriteLine("Enter username: ");
        var Username=Console.ReadLine();
        Console.WriteLine("Enter email: ");
        var Email=Console.ReadLine();

        Console.WriteLine("Enter password: ");
        var Password=Console.ReadLine();
        
        if(Username =="" && Email =="" && Password ==""){
            Console.WriteLine("Please fill all the details");
            
        };

#pragma warning disable CS8601 // Possible null reference assignment.
        User newUser= new User(){Username=Username, Email=Email, Password=Password};
#pragma warning restore CS8601 // Possible null reference assignment.

        await SignUpRequest(newUser);

    }

    public async Task SignUpRequest(User newUser){
        var response= await userServices.RegisterUser(newUser);
        Console.WriteLine(response);
        await Init();
    
    }

}
