using DevExpress.Xpo;
using LifeLog.Base.Infrastructure.Flags;
using LifeLog.Base.Utils;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Mappers;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Mappers;
using LifeLog.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// User app configs data query
	/// </summary>
	public class UserAppConfigsQuery : DataQueryBase<UserAppConfigsModel>
	{
		#region BASE

		/// <summary>
		/// Get the user app config by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(UserAppConfigsModel, string)> GetByKey(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_UserAppConfigsModel result = await db.GetObjectByKeyAsync<ORM_UserAppConfigsModel>(key);
				UserAppConfigsModel model = result != null ? result.ToModel() : new UserAppConfigsModel();
				string message = result != null ? "User app config retrieved successfully." : "User app config not found.";
				return (model, message);
			}
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets the user app config by user id
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public async Task<(UserAppConfigsModel, string)> GetUserAppConfig(Guid userId)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_UsersModel userDb = await db.GetObjectByKeyAsync<ORM_UsersModel>(userId);
				if (userDb == null)
					throw new ArgumentException("User id is invalid!");

				ORM_UserAppConfigsModel result = await db.Query<ORM_UserAppConfigsModel>()
					.FirstOrDefaultAsync(w => w.User.Id == userId);

				bool isNew = result == null;
				UserAppConfigsModel model = result != null ? result.ToModel() : new UserAppConfigsModel();

				if (isNew)
				{
					model.Id = Guid.NewGuid();
					model.User = userDb.ToLoggedInModel();
					model.FrontModules = FlagsUtil.GetAllFlagsValue<FrontModulesFlag>();
					model.FrontFormHeight = 800;
					model.FrontFormWidth = 1200;
					model.FrontFormState = 1;
				}

				string message = result != null ? "User app config retrieved successfully." : "User app config not found.";
				return (model, message);
			}
		}

		#endregion
	}
}
