using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using Life_Log.Helpers;

namespace Life_Log.Views.Tools.HostsEditor
{
    /// <summary>
    /// Hosts editor view
    /// </summary>
	public partial class HostsEditorView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

        private const string hostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";
        private List<HostEntry> hostEntries = new List<HostEntry>();

        /// <summary>
        /// Constructor for the hosts editor view
        /// </summary>
        public HostsEditorView() => InitializeComponent();

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data
        /// </summary>
        public void LoadData()
        {
          
            string[] lines = File.ReadAllLines(hostsFilePath);

            foreach (var line in lines)
            {
                bool isActive = !line.TrimStart().StartsWith("#");
                string cleanLine = line.TrimStart('#').Trim();
                string[] parts = cleanLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2)
                {
                    int commentIndex = cleanLine.IndexOf('#');
                    string comment = commentIndex >= 0 ? cleanLine.Substring(commentIndex + 1).Trim() : string.Empty;

                    HostEntry entry = new HostEntry
                    {
                        Address = parts[0],
                        Host = parts[1],
                        Comment = comment,
                        IsActive = isActive
                    };

                    hostEntries.Add(entry);
                }
            }

            gridControl.DataSource = hostEntries;
        }


        #endregion

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (var entry in hostEntries)
                {
                    string line = $"{entry.Address} {entry.Host}";

                    if (!entry.IsActive)
                        line = $"# {line}";

                    if (!string.IsNullOrEmpty(entry.Comment))
                        line += $" # {entry.Comment}";

                    lines.Add(line);
                }

                File.WriteAllLines(hostsFilePath, lines);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }
    }

    public class HostEntry
    {
        public string Address { get; set; }
        public string Host { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }
    }
}
