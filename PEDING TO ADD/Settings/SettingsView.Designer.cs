namespace Life_Log.Views.Settings
{
    partial class SettingsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationPaneEx = new Life_Log.Components.NavigationPaneEx();
            this.npGeralSettings = new Life_Log.Components.NavigationPageEx();
            this.geralSettingsView = new Life_Log.Views.Settings.GeralSettingsView();
            this.npDbSettings = new Life_Log.Components.NavigationPageEx();
            this.databaseSettingsView = new Life_Log.Views.Settings.DatabaseSettingsView();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneEx)).BeginInit();
            this.navigationPaneEx.SuspendLayout();
            this.npGeralSettings.SuspendLayout();
            this.npDbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPaneEx
            // 
            this.navigationPaneEx.Controls.Add(this.npGeralSettings);
            this.navigationPaneEx.Controls.Add(this.npDbSettings);
            this.navigationPaneEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPaneEx.Location = new System.Drawing.Point(0, 0);
            this.navigationPaneEx.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPaneEx.Name = "navigationPaneEx";
            this.navigationPaneEx.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navigationPaneEx.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npGeralSettings,
            this.npDbSettings});
            this.navigationPaneEx.RegularSize = new System.Drawing.Size(902, 495);
            this.navigationPaneEx.SelectedPage = null;
            this.navigationPaneEx.Size = new System.Drawing.Size(922, 515);
            this.navigationPaneEx.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
            this.navigationPaneEx.TabIndex = 4;
            this.navigationPaneEx.Text = "Settigns";
            this.navigationPaneEx.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationPaneEx_SelectedPageChanged);
            // 
            // npGeralSettings
            // 
            this.npGeralSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.npGeralSettings.Caption = "Geral";
            this.npGeralSettings.Controls.Add(this.geralSettingsView);
            this.npGeralSettings.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.yaxissettings;
            this.npGeralSettings.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.npGeralSettings.Name = "npGeralSettings";
            this.npGeralSettings.Size = new System.Drawing.Size(796, 515);
            // 
            // geralSettingsView
            // 
            this.geralSettingsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geralSettingsView.Location = new System.Drawing.Point(0, 0);
            this.geralSettingsView.Margin = new System.Windows.Forms.Padding(0);
            this.geralSettingsView.Name = "geralSettingsView";
            this.geralSettingsView.Size = new System.Drawing.Size(796, 515);
            this.geralSettingsView.TabIndex = 0;
            // 
            // npDbSettings
            // 
            this.npDbSettings.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.npDbSettings.Caption = "Database";
            this.npDbSettings.Controls.Add(this.databaseSettingsView);
            this.npDbSettings.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.sql_reporting;
            this.npDbSettings.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.npDbSettings.Name = "npDbSettings";
            this.npDbSettings.Size = new System.Drawing.Size(796, 515);
            // 
            // databaseSettingsView
            // 
            this.databaseSettingsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseSettingsView.Location = new System.Drawing.Point(0, 0);
            this.databaseSettingsView.Margin = new System.Windows.Forms.Padding(0);
            this.databaseSettingsView.Name = "databaseSettingsView";
            this.databaseSettingsView.Size = new System.Drawing.Size(796, 515);
            this.databaseSettingsView.TabIndex = 1;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationPaneEx);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(922, 515);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneEx)).EndInit();
            this.navigationPaneEx.ResumeLayout(false);
            this.npGeralSettings.ResumeLayout(false);
            this.npDbSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Components.NavigationPaneEx navigationPaneEx;
        private Components.NavigationPageEx npGeralSettings;
        private Components.NavigationPageEx npDbSettings;
        private DatabaseSettingsView databaseSettingsView;
        private GeralSettingsView geralSettingsView;
    }
}
