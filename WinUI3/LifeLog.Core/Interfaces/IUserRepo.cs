using LifeLog.Core.Models;
using System.Threading.Tasks;

namespace LifeLog.Core.Interfaces;

public interface IUserRepo : IBaseRepo<Entities.User>
{
    Task<(bool logged, LoggedUserModel? user, string message)> Login(object value1, object value2);
}
