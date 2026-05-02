using LifeLog.Core.Models;
using System.Threading.Tasks;

namespace LifeLog.Core.Interfaces;

public interface IUserRepo : IBaseRepo<Entities.User>
{
    #region AUTH
    
    /// <summary>
    /// Register user
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task<(bool registered, string message)> Register(RegisterModel model);

    /// <summary>
    /// Login user
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task<(bool logged, LoggedUserModel? user, string message)> Login(LoginModel model); 

    #endregion
}
