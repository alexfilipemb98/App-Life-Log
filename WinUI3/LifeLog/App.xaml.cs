using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Helpers;
using Microsoft.UI.Xaml;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LifeLog
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        public Window? m_window;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App() => InitializeComponent();

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();


#if DEBUG
            string dbPath = "C:\\Users\\alexfilipemb98\\Documents\\GitHub\\App-Life-Log\\WinUI3\\lifelog_database.db";
#else
            string dbPath = Path.Combine(AppContext.BaseDirectory, "lifelog_database.db");
#endif


            string dbPassword = "yV7GqK5Yvgd0CWsJnfFRHjp7EtF0EJ";
            DatabaseTypeEnum dbType = DatabaseTypeEnum.SQLLITE;


            AppHelper.DataEngine = new LifeLog.Data.Engine(dbPath, dbPassword, dbType);
        }

        
    }
}
