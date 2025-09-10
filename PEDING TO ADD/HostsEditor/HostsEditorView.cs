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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Life_Log.Views.Tools.HostsEditor
{
    /// <summary>
    /// Hosts editor view
    /// </summary>
	public partial class HostsEditorView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

        private readonly string hostsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
        public List<string> OriginalLines { get; private set; } = new List<string>();
        public BindingList<HostEntry> Entries { get; private set; } = new BindingList<HostEntry>();

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

            OriginalLines.Clear();
            Entries.Clear();

            if (!File.Exists(hostsFilePath))
                throw new FileNotFoundException("O ficheiro hosts não foi encontrado.");

            Regex regex = new Regex(@"^\s*(#?)\s*([\d\.]+|\[.*\])\s+([\w\.\-]+)(.*)?$", RegexOptions.Compiled);
            int lineIndex = 0;

            using (var reader = new StreamReader(hostsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    OriginalLines.Add(line); // Mantém todas as linhas

                    var match = regex.Match(line);
                    if (match.Success)
                    {
                        bool isActive = match.Groups[1].Value != "#";
                        Entries.Add(new HostEntry
                        {
                            LineIndex = lineIndex,
                            IsActive = isActive,
                            Address = match.Groups[2].Value.Trim(),
                            Host = match.Groups[3].Value.Trim(),
                            Comment = match.Groups[4].Value.TrimStart('#', ' ').Trim()
                        });
                    }
                    lineIndex++;
                }
            }

            gridControl.DataSource = Entries;
        }

        public void SaveHostsFile()
        {
            List<string> updatedLines = new List<string>();

            for (int i = 0; i < OriginalLines.Count; i++)
            {
                string originalLine = OriginalLines[i];
                HostEntry entry = Entries.FirstOrDefault(e => e.LineIndex == i);

                if (entry != null)
                {
                    string newLine = $"{(entry.IsActive ? "" : "#")} {entry.Address} {entry.Host} {entry.Comment}";
                    updatedLines.Add(newLine);
                }
                else
                    updatedLines.Add(originalLine);
            }

            File.WriteAllLines(hostsFilePath, updatedLines);
        }


        public void SaveHostsFileWithAdminCheck()
        {
            if (!AppHelper.IsRunningAsAdmin())
            {
                try
                {
                    var processInfo = new ProcessStartInfo
                    {
                        FileName = Application.ExecutablePath, // Executa o próprio programa
                        Verb = "runas", // Solicita permissões de administrador
                        Arguments = "/save" // Passa um argumento indicando que é uma operação de gravação
                    };
                    Process.Start(processInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao tentar executar como administrador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    SaveHostsFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gravar o ficheiro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveHostsFileWithAdminCheck();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        private void bbiShowFileOnExplorer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("explorer.exe", hostsFilePath);
        }
    }

    public class HostEntry
    {
        public int LineIndex { get; set; } // Guarda a posição original no ficheiro
        public string Address { get; set; }
        public string Host { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }
    }

}
