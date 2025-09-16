using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Mappers;
using LifeLog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Mappers
{
	internal static class UserAppConfigsMapper
	{
		/// <summary>
		/// ORM_CommandsModel to CommandsModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static UserAppConfigsModel ToModel(this ORM_UserAppConfigsModel entity)
		{
			if (entity == null) return null;

			return new UserAppConfigsModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				User = entity.User.ToLoggedInModel(),
				FrontModules = entity.FrontModules,
				FrontFormState = entity.FrontFormState,
				FrontFormWidth = entity.FrontFormWidth,
				FrontFormHeight = entity.FrontFormHeight,
			};
		}
	}
}
