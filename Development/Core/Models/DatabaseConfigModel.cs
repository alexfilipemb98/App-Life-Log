using Core.Enums;
using Core.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    /// <summary>
    /// Database config object model
    /// </summary>
    [Serializable]
    public class DatabaseConfigModel
    {
        #region PROPERTIES

        private DatabaseTypeEnum fdatabaseType;
        [EnumDataType(typeof(DatabaseTypeEnum))]
        public DatabaseTypeEnum DatabaseType
        {
            get => fdatabaseType;
            set => fdatabaseType = value;
        }

        private string fsQlLitePath;
        [DataType(DataType.Text)]
        [Core.Atributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.SQLLITE)]
        public string SQlLitePath
        {
            get => fsQlLitePath.Decrypt();
            set => fsQlLitePath = value.Encrypt();
        }

        private string fsqlAddress;
        [DataType(DataType.Text)]
        [Core.Atributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlAddress
        {
            get => fsqlAddress.Decrypt();
            set => fsqlAddress = value.Encrypt();
        }

        private string fsqlUsername;
        [DataType(DataType.Text)]
        [Core.Atributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlUsername
        {
            get => fsqlUsername.Decrypt();
            set => fsqlUsername = value.Encrypt();
        }

        private string fsqlPassword;
        [DataType(DataType.Text)]
        [Core.Atributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlPassword
        {
            get => fsqlPassword.Decrypt();
            set => fsqlPassword = value.Encrypt();
        }

        private string fSqlDatabase;
        [DataType(DataType.Text)]
        [Core.Atributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
        public string SqlDatabase
        {
            get => fSqlDatabase.Decrypt();
            set => fSqlDatabase = value.Encrypt();
        }

        #endregion
    }
}
