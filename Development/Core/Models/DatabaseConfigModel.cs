using Models.Enums;
using Utils.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    /// <summary>
    /// Database config object model
    /// </summary>
    [Serializable]
    public class DatabaseConfigModel
    {
        #region PROPERTIES

        [EnumDataType(typeof(DatabaseTypeEnum))]
        public DatabaseTypeEnum DatabaseType { get; set; }

        private string fSqlLitePath;
        [Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.SQLLITE)]
        public string SQlLitePath
        {
            get => fSqlLitePath.Decrypt();
            set => fSqlLitePath = value.Encrypt();
        }
          
        private string fSQlLitePassword; 
        [Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.SQLLITE)]
        public string SqlLitePassword
        {
            get => fSQlLitePassword.Decrypt();
            set => fSQlLitePassword = value.Encrypt();
        }

        private string fSqlAddress;
        [Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlAddress
        {
            get => fSqlAddress.Decrypt();
            set => fSqlAddress = value.Encrypt();
        }

        private string fSqlUsername;
        [Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlUsername
        {
            get => fSqlUsername.Decrypt();
            set => fSqlUsername = value.Encrypt();
        }

        private string fSqlPassword;
        [Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlPassword
        {
            get => fSqlPassword.Decrypt();
            set => fSqlPassword = value.Encrypt();
        }

        private string fSqlDatabase;
        [Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlDatabase
        {
            get => fSqlDatabase.Decrypt();
            set => fSqlDatabase = value.Encrypt();
        }

        #endregion
    }
}
