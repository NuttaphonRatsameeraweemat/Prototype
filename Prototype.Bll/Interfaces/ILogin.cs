using Prototype.Bll.Models;

namespace Prototype.Bll.Interfaces
{
    public interface ILogin
    {
        string BuildToken(string aduser);
        bool Authenticate(LoginViewModel login);
    }
}
