using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface IUsersProcessor
    {
        string GenerateAccessCode();
        List<Users> GetUsers();
        string SaveUser(IUsers user);
        string UpdateUser(IUsers user);
    }
}