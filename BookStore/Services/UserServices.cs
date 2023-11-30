using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using System.Threading.Tasks;
using BooksModel;
using BookStore.Services.Iservices;
using System.Text;
// using System.Text.Json;

namespace BookStore.Services
{
    public class UserServices : Iuser
    {
        private readonly HttpClient _http;
        private readonly string URL=" http://localhost:3000/users";

        public UserServices()
        {
            _http=new HttpClient();
            
        }

       

        public async Task<string> RegisterUser(User newUser)
        {

            var content= JsonConvert.SerializeObject(newUser);;
            
            
            var body=new StringContent(content,Encoding.UTF8,"application/json");
            // Console.WriteLine(content);
            var response= await _http.PostAsync(URL,body);

            return response.IsSuccessStatusCode ? "Registration successful" : "Registration Failed";


        }
    }
}