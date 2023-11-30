using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksModel;

namespace BookStore.Services.Iservices
{
    public interface Iuser
    {
        Task <string> RegisterUser(User newUser);
    }
}