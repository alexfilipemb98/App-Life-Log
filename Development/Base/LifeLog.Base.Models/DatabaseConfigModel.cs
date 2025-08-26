using LifeLog.Base.Utils;
using LifeLog.Base.Infrastructure.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Base.Models
{
	/// <summary>
	/// Database config object model
	/// </summary>
	[Serializable]
	public class DatabaseConfigModel
	{
		#region PROPERTIES

		#region SQL LITE

		[EnumDataType(typeof(DatabaseTypeEnum))]
		public DatabaseTypeEnum DatabaseType { get; set; }

		[Infrastructure.Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.SQLLITE)]
		public string SQlLitePath { get; set; }

		public bool SqlLiteBackup { get; set; }

		[Infrastructure.Attributes.RequiredIf(nameof(SqlLiteBackup), OperatorsEnum.Equal, true)]
		public string SqlLiteBackupFolder { get; set; }

		#endregion

		#region REMOTE SQL

		[Infrastructure.Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.SQLLITE)]
		public string SqlLitePassword { get; set; }

		[Infrastructure.Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
		public string SqlAddress { get; set; }

		[Infrastructure.Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
		public string SqlUsername { get; set; }

		[Infrastructure.Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
		public string SqlPassword { get; set; }

		[Infrastructure.Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
		public string SqlDatabase { get; set; }

		#endregion

		#endregion
	}
}
