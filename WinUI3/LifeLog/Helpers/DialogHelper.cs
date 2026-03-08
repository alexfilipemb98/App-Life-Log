using Microsoft.UI.Xaml;
using System;
using System.Threading.Tasks;
using Windows.Storage.Pickers;

namespace LifeLog.Helpers;

internal static class DialogHelper
{

    internal static async Task<string> SelectFolderAsync(string currentPath)
    {
        FolderPicker folderPicker = new FolderPicker();

        Window? window = (Application.Current as App)?.m_window;
        if (window == null) return currentPath;

        IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
        WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hWnd);

        folderPicker.SuggestedStartLocation = PickerLocationId.ComputerFolder;
        folderPicker.FileTypeFilter.Add("*");

        Windows.Storage.StorageFolder? folder = await folderPicker.PickSingleFolderAsync();

        return folder != null ? folder.Path : currentPath;
    }

  
    internal static async Task<string> SaveFileAsync(string defaultName, string extensionLabel, string extension)
    {
        FileSavePicker savePicker = new FileSavePicker();

        Window? window = (Application.Current as App)?.m_window;
        if (window == null) return string.Empty;

        IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
        WinRT.Interop.InitializeWithWindow.Initialize(savePicker, hWnd);

        savePicker.SuggestedFileName = defaultName;
        savePicker.FileTypeChoices.Add(extensionLabel, new System.Collections.Generic.List<string>() { extension });

        Windows.Storage.StorageFile? file = await savePicker.PickSaveFileAsync();
        return file != null ? file.Path : string.Empty;
    }
}