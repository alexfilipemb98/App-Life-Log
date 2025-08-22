namespace LifeLog.Base.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface for UserControl
    /// </summary>
    public interface IUserControl<Model>
    {
        /// <summary>
        /// Load data
        /// </summary>
        void LoadData();

        /// <summary>
        /// Save data
        /// </summary>
        /// <returns></returns>
        bool SaveData(out Model data);

        /// <summary>
        /// Reset data
        /// </summary>
        void ResetData();

        /// <summary>
        /// Set data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        void SetData(Model data);

    }
}
